# CLAUDE.md -- Baseten SDK

## Overview

Auto-generated C# SDK for [Baseten](https://baseten.co/) -- a model serving and deployment platform with Truss framework for deploying ML models (vLLM, TensorRT).

## Build & Test

```bash
dotnet build Baseten.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key auth (`Api-Key` prefix in `Authorization` header):

```csharp
var client = new BasetenClient(apiKey); // BASETEN_API_KEY env var
```

The `Authorizing` partial hook in `Extensions/BasetenClient.Auth.cs` prepends `Api-Key ` to the raw API key value.

## Key Files

- `src/libs/Baseten/openapi.yaml` -- Downloaded from `https://api.baseten.co/v1/spec` (OpenAPI 3.1.0)
- `src/libs/Baseten/generate.sh` -- Runs autosdk with `--security-scheme Http:Header:Bearer`
- `src/libs/Baseten/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Baseten/Extensions/BasetenClient.Auth.cs` -- Auth hook (Bearer -> Api-Key prefix)
- `src/libs/Baseten/Extensions/BasetenClient.Tools.cs` -- MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with API key auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Endpoints (77 operations)

| Category | Examples |
|----------|----------|
| Models | List, get by ID, delete |
| Deployments | List, get production/development, activate, deactivate, promote, retry, autoscaling settings |
| Environments | Create, list, get, update, promote, rolling deployment controls |
| Chains | List, get, delete, deploy, environment management |
| Secrets | List, upsert (workspace and team scoped) |
| API Keys | List, create, delete |
| Instance Types | List types, get pricing |
| Billing | Usage summary |
| Training | Projects, jobs, checkpoints, logs, metrics |
| Library Listings | CRUD for listings and versions |
| LLM Models | BIS LLM deployment creation |

## MEAI AIFunction Tools

| Tool | Description |
|------|-------------|
| `AsListModelsTool()` | Lists all deployed ML models |
| `AsGetModelTool()` | Gets a specific model by ID |
| `AsGetDeploymentStatusTool()` | Gets production deployment status |
| `AsListSecretsTool()` | Lists workspace secrets |
