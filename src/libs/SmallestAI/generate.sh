#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location \
  "https://docs.smallest.ai/openapi.yaml?api=148120e3-2d93-487e-9a21-5704cd2be0c4" \
  -o openapi.yaml

autosdk generate openapi.yaml \
  --namespace SmallestAI \
  --clientClassName SmallestAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --ignore-openapi-errors \
  --exclude-deprecated-operations
