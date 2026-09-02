# CLAUDE.md — SmallestAI SDK

## Overview

Auto-generated C# SDK for [Smallest AI](https://smallest.ai/) — **Lightning** text-to-speech and
**Pulse** speech-to-text, plus voice cloning and pronunciation dictionaries. Covers both the REST
API (OpenAPI) and both WebSocket channels (AsyncAPI).

## Build & Test

```bash
dotnet build SmallestAI.slnx
dotnet test src/tests/IntegrationTests/
```

Tests read `SMALLESTAI_API_KEY`, falling back to `SMALLEST_API_KEY`, and report **inconclusive**
(not failed) when neither is set.

## Auth

Standard bearer:

```csharp
using var client = new SmallestAIClient(apiKey);
```

The WebSocket clients take the same key and set `Authorization: bearer <key>` themselves — AutoSDK
generates that natively from `--security-scheme Http:Header:Bearer`, so unlike Deepgram/Inworld this
SDK needs **no** hand-written auth hook.

## Key Files

- `src/libs/SmallestAI/generate.sh` — regeneration (OpenAPI + handcrafted AsyncAPI)
- `src/libs/SmallestAI/scripts/select-fern-openapi.py` — picks the right document out of Smallest's
  Fern multi-API selector page
- `src/libs/SmallestAI/asyncapi.yaml` — **handcrafted**; see below
- `src/libs/SmallestAI/Generated/` — **never edit**
- `src/libs/SmallestAI/Extensions/SmallestAIClient.SpeechToTextClient.cs` — MEAI `ISpeechToTextClient`
- `src/libs/SmallestAI/Extensions/SmallestAISpeechToTextPropertyNames.cs` — `AdditionalProperties` keys
- `src/libs/SmallestAI/Extensions/SmallestAIRealtimeClient.Convenience.cs` — realtime helpers
- `src/tests/IntegrationTests/Tests.Audio.cs` — builds the two-speaker fixture at test time
- `src/tests/IntegrationTests/Examples/` — example tests, and the single source for `docs/examples/`

## Two-spec architecture

| Spec | Namespace | Client(s) | Purpose |
|------|-----------|-----------|---------|
| `openapi.yaml` (upstream, via Fern) | `SmallestAI` | `SmallestAIClient` | REST: TTS, pre-recorded STT, voices, cloning, pronunciation dicts, Electron chat |
| `asyncapi.yaml` (**handcrafted**) | `SmallestAI.Realtime` | `SmallestAISttLiveRealtimeClient`, `SmallestAITtsLiveRealtimeClient` | WebSocket: Pulse realtime STT, Lightning streaming TTS |

### Why `asyncapi.yaml` is handcrafted

Smallest publishes no AsyncAPI document. Both WebSocket endpoints exist only as prose inside the
OpenAPI operation descriptions, so the spec is maintained by hand from the docs (same precedent as
the Inworld SDK). Sources are listed in the file's `info.description`; the protocol was
cross-checked against pipecat's `SmallestSTTService` and `smallest-inc/smallest-ai-vercel-provider`.

Two details matter when editing it:

- **Model the connection query in `bindings.ws.query`.** That is what makes AutoSDK emit a typed
  `ConnectAsync` with one named parameter per query parameter instead of leaving consumers to build
  URIs by hand.
- **Do not model binary audio frames as messages.** The generated client already exposes
  `SendAsync(ArraySegment<byte>, WebSocketMessageType, bool, CancellationToken)`; `SendAudioAsync`
  in `Extensions/` wraps it.

## Pulse diarization

Speaker labels are the headline Pulse feature and work in both modes.

- **Pre-recorded:** `SpeechToText.TranscribeAsync(..., diarize: true, wordTimestamps: true)`.
  `TranscriptionResponse.Words` carries `Speaker` + `SpeakerConfidence`; `Utterances` carries
  `Speaker`.
- **Realtime:** `SmallestAISttLiveRealtimeClient.ConnectAsync(diarize: SttLiveDiarize.True, ...)`.

Constraints worth remembering:

- Only frames with `is_final` carry `words[]`. **Never render speaker attribution from interim
  frames** — `SttTranscriptionEvent.HasSpeakerLabels` encodes this check.
- Speaker ids are zero-indexed and stable **within one response or session only**.
- `pulse-pro` does not diarize and has no streaming worker — `wss://.../stt/live?model=pulse-pro`
  returns `400` before the upgrade. The realtime `SttLiveModel` enum therefore has only `Pulse`, and
  the MEAI adapter rejects `pulse-pro` up front with an explicit message.

## MEAI Integration

- **Interface:** `ISpeechToTextClient` (both `GetTextAsync` and `GetStreamingTextAsync`).
- **Namespace conflict: yes.** The generated `SmallestAI.ISpeechToTextClient` sub-client interface
  collides by simple name with `Microsoft.Extensions.AI.ISpeechToTextClient`. Inside the
  `SmallestAI` namespace, alias it: `using Meai = Microsoft.Extensions.AI;`.
- Pulse knobs go in through `SpeechToTextOptions.AdditionalProperties` and speaker-labelled results
  come back through the response's `AdditionalProperties`, keyed by
  `SmallestAISpeechToTextPropertyNames`. `RawRepresentation` carries the full typed payload.
- `<NoWarn>$(NoWarn);MEAI001</NoWarn>` is required in both the library and the tests project.

### Wire flags are mapped by name, never by ordinal

Pulse spells its boolean query parameters as the strings `"true"`/`"false"`, so AutoSDK emits them
as two-member enums — **alphabetically, `False` first**. `ToWireFlag<TEnum>` therefore resolves via
`Enum.Parse<TEnum>("True"/"False")`. An ordinal mapping would silently invert every flag, including
`diarize`.

## Spec Notes

`generate.sh` applies these before generation:

1. **`--required-path /waves/v1/stt/`** in the Fern selector. Pulse STT arrived silently via an
   upstream spec refresh; without the guard a future reshuffle could pick a document without STT and
   delete the whole speech-to-text client with CI still green.
2. **Audio-by-URL request variant** on `/waves/v1/stt/`. Upstream documents
   `Content-Type: application/json` with `{"url": ...}` in the operation description but declares
   only `application/octet-stream`, so the flow was unreachable. The patch yields
   `TranscribeWithJsonAsync` (including a convenience `string url` overload).

The `yq` step also pretty-prints the spec, so auto-update diffs are reviewable rather than one
74 KB line.

CLI flags: `--security-scheme Http:Header:Bearer`, `--generate-http-exception-hierarchy`,
`--generate-retry-handler`, `--ignore-openapi-errors`, `--exclude-deprecated-operations`.

**Spec sources:**

- OpenAPI: selected from `https://docs.smallest.ai/openapi.json` (a Fern multi-API selector page,
  not a spec — hence `select-fern-openapi.py`)
- AsyncAPI: handcrafted in-repo

## NuGet

- **PackageId:** `SmallestAI`
