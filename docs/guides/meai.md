# Microsoft.Extensions.AI Integration

The Baseten SDK provides `AIFunction` tools that can be used with any `Microsoft.Extensions.AI.IChatClient` to give AI agents access to model management, deployment monitoring, and secrets on the Baseten platform.

## Available Tools

| Tool | Function Name | Description |
|------|--------------|-------------|
| `AsListModelsTool()` | `BasetenListModels` | Lists all ML models deployed on Baseten |
| `AsGetModelTool()` | `BasetenGetModel` | Gets details of a specific model by ID |
| `AsGetDeploymentStatusTool()` | `BasetenGetDeploymentStatus` | Gets production deployment status for a model |
| `AsListSecretsTool()` | `BasetenListSecrets` | Lists workspace secrets (values never returned) |

## Usage

```csharp
using Baseten;
using Microsoft.Extensions.AI;

// Create the Baseten client
var basetenClient = new BasetenClient(apiKey);

// Create tools for use with any IChatClient
var tools = new[]
{
    basetenClient.AsListModelsTool(),
    basetenClient.AsGetModelTool(),
    basetenClient.AsGetDeploymentStatusTool(),
    basetenClient.AsListSecretsTool(),
};

// Use with any IChatClient (OpenAI, Anthropic, Ollama, etc.)
var chatOptions = new ChatOptions { Tools = [.. tools] };
var response = await chatClient.GetResponseAsync(
    "What models are currently deployed and what's their status?",
    chatOptions);
```

## Authentication

The Baseten API uses `Api-Key` authentication. Pass your API key to the constructor:

```csharp
var client = new BasetenClient(apiKey);
```

The SDK automatically prefixes the key with `Api-Key ` in the `Authorization` header.
