using Microsoft.Extensions.AI;

namespace Baseten;

/// <summary>
/// Extensions for using BasetenClient as MEAI AIFunction tools with any IChatClient.
/// </summary>
public static class BasetenToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all models deployed on Baseten,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Baseten client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListModelsTool(
        this BasetenClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.GetModelsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatModelsResponse(response);
            },
            name: "BasetenListModels",
            description: "Lists all ML models deployed on the Baseten platform. Returns model names, IDs, deployment counts, instance types, and team associations.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets a specific model by ID,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Baseten client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetModelTool(
        this BasetenClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string modelId, CancellationToken cancellationToken) =>
            {
                var model = await client.GetModelsByModelIdAsync(
                    modelId: modelId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatModelResponse(model);
            },
            name: "BasetenGetModel",
            description: "Gets details of a specific ML model deployed on Baseten by its model ID. Returns model name, deployment count, instance type, and team.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that gets the production deployment status for a model,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Baseten client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsGetDeploymentStatusTool(
        this BasetenClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string modelId, CancellationToken cancellationToken) =>
            {
                var deployment = await client.GetModelsByModelIdDeploymentsProductionAsync(
                    modelId: modelId,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatDeploymentResponse(deployment);
            },
            name: "BasetenGetDeploymentStatus",
            description: "Gets the production deployment status for a specific model on Baseten. Returns deployment status, active replica count, autoscaling settings, and instance type.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all secrets in the workspace,
    /// suitable for use as a tool with any IChatClient.
    /// </summary>
    /// <param name="client">The Baseten client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListSecretsTool(
        this BasetenClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.GetSecretsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatSecretsResponse(response);
            },
            name: "BasetenListSecrets",
            description: "Lists all secrets configured in the Baseten workspace. Returns secret names, creation dates, and associated teams. Note: secret values are never returned.");
    }

    private static string FormatModelsResponse(ModelsV1 response)
    {
        var parts = new List<string>();

        if (response.Models is { Count: > 0 })
        {
            parts.Add($"Models ({response.Models.Count}):");
            foreach (var model in response.Models)
            {
                parts.Add(FormatModelResponse(model));
            }
        }
        else
        {
            parts.Add("No models found.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatModelResponse(ModelV1 model)
    {
        var entry = $"- {model.Name} (ID: {model.Id})";
        entry += $" | Instance: {model.InstanceTypeName}";
        entry += $" | Deployments: {model.DeploymentsCount}";
        entry += $" | Team: {model.TeamName}";

        if (model.ProductionDeploymentId is not null)
        {
            entry += $" | Production: {model.ProductionDeploymentId}";
        }

        return entry;
    }

    private static string FormatDeploymentResponse(DeploymentV1 deployment)
    {
        var parts = new List<string>
        {
            $"Deployment: {deployment.Name} (ID: {deployment.Id})",
            $"  Model ID: {deployment.ModelId}",
            $"  Status: {deployment.Status}",
            $"  Active Replicas: {deployment.ActiveReplicaCount}",
            $"  Is Production: {deployment.IsProduction}",
            $"  Is Development: {deployment.IsDevelopment}",
        };

        if (deployment.InstanceTypeName is not null)
        {
            parts.Add($"  Instance Type: {deployment.InstanceTypeName}");
        }

        if (deployment.Environment is not null)
        {
            parts.Add($"  Environment: {deployment.Environment}");
        }

        if (deployment.AutoscalingSettings is { } autoscaling)
        {
            parts.Add($"  Autoscaling: min={autoscaling.MinReplica}, max={autoscaling.MaxReplica}, concurrency={autoscaling.ConcurrencyTarget}");
        }

        return string.Join("\n", parts);
    }

    private static string FormatSecretsResponse(SecretsV1 response)
    {
        var parts = new List<string>();

        if (response.Secrets is { Count: > 0 })
        {
            parts.Add($"Secrets ({response.Secrets.Count}):");
            foreach (var secret in response.Secrets)
            {
                parts.Add($"- {secret.Name} | Team: {secret.TeamName} | Created: {secret.CreatedAt:yyyy-MM-dd}");
            }
        }
        else
        {
            parts.Add("No secrets found.");
        }

        return string.Join("\n", parts);
    }
}
