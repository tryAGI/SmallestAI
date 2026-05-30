#!/usr/bin/env python3
import argparse
import json
import re
import shutil
import subprocess
import sys
import tempfile
from pathlib import Path
from urllib.parse import urljoin


def download(url: str, output: Path) -> None:
    subprocess.run(
        [
            "curl",
            "--fail",
            "--silent",
            "--show-error",
            "--location",
            url,
            "-o",
            str(output),
        ],
        check=True,
    )


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(
        description="Select an OpenAPI document from a Fern multi-API selector page."
    )
    parser.add_argument("--index-url", required=True)
    parser.add_argument("--output", required=True)
    parser.add_argument("--required-path", action="append", default=[])
    return parser.parse_args()


def main() -> int:
    args = parse_args()
    index_url = args.index_url
    output = Path(args.output)
    required_paths = set(args.required_path)

    with tempfile.TemporaryDirectory() as tmp_dir:
        tmp_path = Path(tmp_dir)
        index_path = tmp_path / "openapi-index.html"
        download(index_url, index_path)

        html = index_path.read_text(encoding="utf-8")
        candidate_urls = []

        for api_id in re.findall(r"\?api=([0-9a-fA-F-]{36})", html):
            candidate_urls.append((api_id, f"{index_url}?api={api_id}"))

        for href in re.findall(r'href=["\']([^"\']*openapi/[0-9a-fA-F-]{36}\.json)["\']', html):
            api_id = Path(href).stem
            candidate_urls.append((api_id, urljoin(index_url, href)))

        for href in re.findall(r'href=["\']([^"\']*openapi/[^"\']+\.json)["\']', html):
            api_id = Path(href).stem
            candidate_urls.append((api_id, urljoin(index_url, href)))

        candidate_urls = list(dict.fromkeys(candidate_urls))
        if not candidate_urls:
            print(f"No Fern API IDs found in {index_url}", file=sys.stderr)
            return 1

        for api_id, spec_url in candidate_urls:
            candidate = tmp_path / f"{api_id}.json"
            download(spec_url, candidate)

            with candidate.open(encoding="utf-8") as file:
                spec = json.load(file)

            paths = set(spec.get("paths", {}))
            if required_paths - paths:
                continue

            output.parent.mkdir(parents=True, exist_ok=True)
            shutil.copyfile(candidate, output)
            print(f"Selected Fern OpenAPI spec {api_id} from {index_url}", file=sys.stderr)
            return 0

    print(f"No matching Fern OpenAPI spec found in {index_url}", file=sys.stderr)
    return 1


if __name__ == "__main__":
    raise SystemExit(main())
