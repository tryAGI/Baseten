# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Baseten SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Baseten's model deployment management, deployment status monitoring, and workspace secret listing.

## Installation

```bash
dotnet add package Baseten
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsListModelsTool()` | `BasetenListModels` | List all deployed ML models with names, IDs, and instance types |
| `AsGetModelTool()` | `BasetenGetModel` | Get details of a specific model by ID |
| `AsGetDeploymentStatusTool()` | `BasetenGetDeploymentStatus` | Get production deployment status, replica count, and autoscaling settings |
| `AsListSecretsTool()` | `BasetenListSecrets` | List workspace secrets (names only, values never returned) |

## Usage

```csharp
using Baseten;
using Microsoft.Extensions.AI;

var basetenClient = new BasetenClient(
    apiKey: Environment.GetEnvironmentVariable("BASETEN_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        basetenClient.AsListModelsTool(),
        basetenClient.AsGetModelTool(),
        basetenClient.AsGetDeploymentStatusTool(),
        basetenClient.AsListSecretsTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "List all deployed models and check the production deployment status for each."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
