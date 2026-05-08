#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location \
  "https://docs.smallest.ai/openapi.json?api=d5f0317c-16fc-4dfa-9474-f5d7a4096b56" \
  -o openapi.yaml

autosdk generate openapi.yaml \
  --namespace SmallestAI \
  --clientClassName SmallestAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --ignore-openapi-errors \
  --exclude-deprecated-operations
