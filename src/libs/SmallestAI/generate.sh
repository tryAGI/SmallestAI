#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

fern_index_url="https://docs.smallest.ai/openapi.json"
tmp_dir="$(mktemp -d)"
trap 'rm -rf "$tmp_dir"' EXIT

curl --fail --silent --show-error --location "$fern_index_url" -o "$tmp_dir/openapi-index.html"

api_ids_file="$tmp_dir/api-ids.txt"
python3 - "$tmp_dir/openapi-index.html" > "$api_ids_file" <<'PY'
import re
import sys

with open(sys.argv[1], encoding="utf-8") as file:
    html = file.read()

for api_id in dict.fromkeys(re.findall(r"\?api=([0-9a-f-]{36})", html)):
    print(api_id)
PY

selected_api_id=""
while IFS= read -r api_id; do
  candidate_spec="$tmp_dir/$api_id.json"
  curl --fail --silent --show-error --location "$fern_index_url?api=$api_id" -o "$candidate_spec"

  if python3 - "$candidate_spec" <<'PY'
import json
import sys

with open(sys.argv[1], encoding="utf-8") as file:
    spec = json.load(file)

required_paths = {
    "/waves/v1/lightning-v3.1/get_speech",
    "/waves/v1/lightning-v3.1/stream",
    "/waves/v1/pulse/get_text",
    "/waves/v1/pronunciation-dicts",
    "/waves/v1/voice-cloning",
}

paths = set(spec.get("paths", {}))
missing_paths = required_paths - paths
if missing_paths:
    raise SystemExit(1)
PY
  then
    cp "$candidate_spec" openapi.yaml
    selected_api_id="$api_id"
    break
  fi
done < "$api_ids_file"

if [[ -z "$selected_api_id" ]]; then
  echo "No SmallestAI Waves OpenAPI spec found in $fern_index_url" >&2
  exit 1
fi

echo "Selected SmallestAI Fern OpenAPI spec $selected_api_id" >&2

autosdk generate openapi.yaml \
  --namespace SmallestAI \
  --clientClassName SmallestAIClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --ignore-openapi-errors \
  --exclude-deprecated-operations
