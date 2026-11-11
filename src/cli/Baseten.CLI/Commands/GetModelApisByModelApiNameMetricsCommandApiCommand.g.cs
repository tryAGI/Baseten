#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetModelApisByModelApiNameMetricsCommandApiCommand
{
    private static Argument<string> ModelApiName { get; } = new(
        name: @"model-api-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<global::Baseten.MetricModeV1?> Mode { get; } = new(
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
        Description = @"Names of the metrics to return; see https://docs.baseten.co/observability/export-metrics/supported-metrics for the available names. When omitted, a default set is returned: baseten_model_api_inference_requests_total, baseten_model_api_incoming_inference_requests_total, and baseten_model_api_tokens_total. Unknown names are rejected; valid names that are not enabled for your organization are omitted from the response.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> TeamIds { get; } = new(
        name: @"--team-ids")
    {
        Description = @"Return only metrics for these teams, repeated once per team. Defaults to all teams you can manage. Any unauthorized team causes a 403.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.GetMetricsResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.GetMetricsResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-model-apis-by-model-api-name-metrics", @"Gets the metrics for a Model API
Gets the metrics for a Model API in the given time range for the teams you can manage, with each series labeled by team_id. Organization admins receive organization-wide metrics by default. For a Model API your lab organization lists, other organizations' consumption is included regardless of team_ids.");
                        command.Arguments.Add(ModelApiName);
                        command.Options.Add(Mode);
                        command.Options.Add(StartEpochMillis);
                        command.Options.Add(EndEpochMillis);
                        command.Options.Add(Metrics);
                        command.Options.Add(TeamIds);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var modelApiName = parseResult.GetRequiredValue(ModelApiName);
                        var mode = parseResult.GetValue(Mode);
                        var startEpochMillis = parseResult.GetValue(StartEpochMillis);
                        var endEpochMillis = parseResult.GetValue(EndEpochMillis);
                        var metrics = parseResult.GetValue(Metrics);
                        var teamIds = parseResult.GetValue(TeamIds);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetModelApisByModelApiNameMetricsAsync(
                                    modelApiName: modelApiName,
                                    mode: mode,
                                    startEpochMillis: startEpochMillis,
                                    endEpochMillis: endEpochMillis,
                                    metrics: metrics,
                                    teamIds: teamIds,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Baseten.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}