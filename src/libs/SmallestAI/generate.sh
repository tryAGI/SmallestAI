#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location \
  "https://docs.smallest.ai/api/fern-docs/openapi?api=c3b800f0-a025-4c0f-b701-02c936c869e7" \
  -o openapi.yaml

autosdk generate openapi.yaml \
  --namespace SmallestAI \
  --clientClassName SmallestAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --ignore-openapi-errors \
  --exclude-deprecated-operations
