#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

install_autosdk_cli
rm -rf Generated

fern_index_url="https://docs.smallest.ai/openapi.json"
python3 scripts/select-fern-openapi.py \
  --index-url "$fern_index_url" \
  --output openapi.yaml \
  --required-path /waves/v1/tts \
  --required-path /waves/v1/tts/live \
  --required-path /waves/v1/pronunciation-dicts \
  --required-path /waves/v1/voice-cloning

autosdk generate openapi.yaml \
  --namespace SmallestAI \
  --clientClassName SmallestAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --ignore-openapi-errors \
  --exclude-deprecated-operations
