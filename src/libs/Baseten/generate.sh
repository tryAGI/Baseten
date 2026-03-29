dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api.baseten.co/v1/spec
autosdk generate openapi.yaml \
  --namespace Baseten \
  --clientClassName BasetenClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations
