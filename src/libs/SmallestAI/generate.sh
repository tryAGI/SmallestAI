#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

install_autosdk_cli
rm -rf Generated

# -----------------------------------------------------------------------------
# REST API (OpenAPI) → main `SmallestAI` namespace.
#
# Smallest publishes its OpenAPI through a Fern multi-API selector page rather
# than a stable document URL, so `select-fern-openapi.py` walks the candidates
# and picks the first one that declares every `--required-path`. Keep
# `/waves/v1/stt/` in that list: Pulse STT arrived silently via an upstream spec
# refresh, and without the guard a future Fern reshuffle would drop the whole
# speech-to-text client with CI still green.
# -----------------------------------------------------------------------------
fern_index_url="https://docs.smallest.ai/openapi.json"
python3 scripts/select-fern-openapi.py \
  --index-url "$fern_index_url" \
  --output openapi.yaml \
  --required-path /waves/v1/tts \
  --required-path /waves/v1/tts/live \
  --required-path /waves/v1/stt/ \
  --required-path /waves/v1/pronunciation-dicts \
  --required-path /waves/v1/voice-cloning

# Fix 1: `POST /waves/v1/stt/` accepts audio either as raw bytes
#        (`application/octet-stream`) or, for `?model=pulse`, as
#        `application/json` with `{"url": "..."}`. Upstream only declares the
#        binary variant, so the audio-by-URL flow documented in the very same
#        operation description is unreachable from generated code. Declaring it
#        makes AutoSDK emit a second overload instead of forcing every consumer
#        to download and buffer the file first.
yq -i -o json '
  .components.schemas.TranscriptionUrlRequest = {
    "type": "object",
    "required": ["url"],
    "properties": {
      "url": {
        "type": "string",
        "format": "uri",
        "description": "Publicly reachable URL of the audio file to transcribe. Supported by `?model=pulse` only."
      }
    }
  } |
  .paths."/waves/v1/stt/".post.requestBody.content."application/json".schema = {
    "$ref": "#/components/schemas/TranscriptionUrlRequest"
  }
' openapi.yaml

autosdk generate openapi.yaml \
  --namespace SmallestAI \
  --clientClassName SmallestAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --generate-http-exception-hierarchy \
  --generate-retry-handler \
  --ignore-openapi-errors \
  --exclude-deprecated-operations

# -----------------------------------------------------------------------------
# Realtime API (AsyncAPI) → `SmallestAI.Realtime` namespace.
#
# Smallest publishes no AsyncAPI document — both WebSocket endpoints exist only
# as prose inside the OpenAPI operation descriptions — so `asyncapi.yaml` is
# handcrafted from the docs (same precedent as the Inworld SDK):
#   - https://docs.smallest.ai/models/documentation/speech-to-text-pulse/realtime-web-socket/quickstart
#   - https://docs.smallest.ai/waves/documentation/speech-to-text-pulse/features/diarization
#   - https://docs.smallest.ai/waves/api-reference/api-reference/text-to-speech/tts
#
# Modelling the connection query in `bindings.ws.query` is deliberate: it is
# what makes AutoSDK emit a typed `ConnectAsync` with one named parameter per
# query parameter, instead of leaving consumers to build URIs by hand.
#
# Binary audio frames are intentionally not modelled — the generated client
# already exposes `SendAsync(ArraySegment<byte>, WebSocketMessageType, ...)`,
# which the session wrappers in Extensions/ use for PCM upload.
#
# Two channels means `--websocket-class-name` acts as a prefix, producing
# `SmallestAISttLiveRealtimeClient` and `SmallestAITtsLiveRealtimeClient`.
# -----------------------------------------------------------------------------
autosdk generate asyncapi.yaml \
  --namespace SmallestAI.Realtime \
  --websocket-class-name SmallestAIRealtimeClient \
  --json-serializer-context RealtimeSourceGenerationContext \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer
