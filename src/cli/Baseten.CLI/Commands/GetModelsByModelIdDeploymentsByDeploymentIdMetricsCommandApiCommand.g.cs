#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetModelsByModelIdDeploymentsByDeploymentIdMetricsCommandApiCommand
{
    private static Argument<string> ModelId { get; } = new(
        name: @"model-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> DeploymentId { get; } = new(
        name: @"deployment-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<global::Baseten.DeploymentMetricModeV1?> Mode { get; } = new(
        name: @"--mode")
    {
        Description = @"'CURRENT': a single instantaneous snapshot at now; start/end must be omitted. 'SUMMARY': a single value set aggregating the whole window. 'SERIES': evenly-spaced value sets across the window, with the step derived from the window duration.",
    };

    private static Option<int?> StartEpochMillis { get; } = new(
        name: @"--start-epoch-millis")
    {
        Description = @"Epoch millis timestamp to start fetching metrics. Defaults to one hour before the end.",
    };

    private static Option<int?> EndEpochMillis { get; } = new(
        name: @"--end-epoch-millis")
    {
        Description = @"Epoch millis timestamp to end fetching metrics. Defaults to the current time. The window between start and end must not exceed 7 days.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Metrics { get; } = new(
        name: @"--metrics")
    {
        Description = @"Names of the metrics to return; see https://docs.baseten.co/observability/export-metrics/supported-metrics for the available names. When omitted, a default set is returned: baseten_replicas_active, baseten_inference_requests_total, and baseten_end_to_end_response_time_seconds. Unknown names are rejected; valid names that do not apply to the deployment are omitted from the response.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.GetDeploymentMetricsResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.GetDeploymentMetricsResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-models-by-model-id-deployments-by-deployment-id-metrics", @"Gets the metrics for a model deployment
Gets the metrics for a model deployment in the given time range.");
                        command.Arguments.Add(ModelId);
                        command.Arguments.Add(DeploymentId);
                        command.Options.Add(Mode);
                        command.Options.Add(StartEpochMillis);
                        command.Options.Add(EndEpochMillis);
                        command.Options.Add(Metrics);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var modelId = parseResult.GetRequiredValue(ModelId);
                        var deploymentId = parseResult.GetRequiredValue(DeploymentId);
                        var mode = parseResult.GetValue(Mode);
                        var startEpochMillis = parseResult.GetValue(StartEpochMillis);
                        var endEpochMillis = parseResult.GetValue(EndEpochMillis);
                        var metrics = parseResult.GetValue(Metrics);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetModelsByModelIdDeploymentsByDeploymentIdMetricsAsync(
                                    modelId: modelId,
                                    deploymentId: deploymentId,
                                    mode: mode,
                                    startEpochMillis: startEpochMillis,
                                    endEpochMillis: endEpochMillis,
                                    metrics: metrics,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Baseten.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}