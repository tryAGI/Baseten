#!/usr/bin/env bash
set -euo pipefail

dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location \
  --retry 5 --retry-delay 10 --retry-all-errors \
  --connect-timeout 30 --max-time 300 \
  -o openapi.yaml \
  https://api.baseten.co/v1/spec
autosdk generate openapi.yaml \
  --namespace Baseten \
  --clientClassName BasetenClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations
