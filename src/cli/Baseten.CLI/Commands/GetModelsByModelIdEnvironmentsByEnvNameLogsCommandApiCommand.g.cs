#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetModelsByModelIdEnvironmentsByEnvNameLogsCommandApiCommand
{
    private static Argument<string> ModelId { get; } = new(
        name: @"model-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> EnvName { get; } = new(
        name: @"env-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<int?> StartEpochMillis { get; } = new(
        name: @"--start-epoch-millis")
    {
        Description = @"Epoch milliseconds at which to start fetching logs. Defaults to 30 minutes before the end. The window from start to end must not exceed 7 days.",
    };

    private static Option<int?> EndEpochMillis { get; } = new(
        name: @"--end-epoch-millis")
    {
        Description = @"Epoch milliseconds at which to stop fetching logs. Defaults to the current time.",
    };

    private static Option<global::Baseten.SortOrderV1?> Direction { get; } = new(
        name: @"--direction")
    {
        Description = @"Sort order for logs",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Limit of logs to fetch in a single request",
    };

    private static Option<global::Baseten.LogLevelV1?> MinLevel { get; } = new(
        name: @"--min-level")
    {
        Description = @"Minimum log severity to include. Omit to return all log lines, including lines that have no level. Any explicit value returns lines at or above that severity and drops lines without a level.",
    };

    private static Option<string?> Replica { get; } = new(
        name: @"--replica")
    {
        Description = @"Only return logs emitted by this replica (5-char short ID).",
    };

    private static Option<string?> RequestId { get; } = new(
        name: @"--request-id")
    {
        Description = @"Only return logs tagged with this inference request ID.",
    };

    private static Option<string?> Component { get; } = new(
        name: @"--component")
    {
        Description = @"Only return logs from this component.",
    };

    private static Option<string?> SearchPattern { get; } = new(
        name: @"--search-pattern")
    {
        Description = @"RE2 regular expression matched against the log message. Prefer `includes` and `excludes` for plain substring matches.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Includes { get; } = new(
        name: @"--includes")
    {
        Description = @"Case-sensitive substrings that must all appear in the log message.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Excludes { get; } = new(
        name: @"--excludes")
    {
        Description = @"Case-sensitive substrings; lines containing any of these are dropped.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.GetLogsResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.GetLogsResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-models-by-model-id-environments-by-env-name-logs", @"Gets the logs for a model environment
Gets logs across all deployments that were active on the environment in the given time range, which defaults to the last 30 minutes. Pass `start_epoch_millis` to widen the window back to an earlier deployment's build/deploy time.");
                        command.Arguments.Add(ModelId);
                        command.Arguments.Add(EnvName);
                        command.Options.Add(StartEpochMillis);
                        command.Options.Add(EndEpochMillis);
                        command.Options.Add(Direction);
                        command.Options.Add(Limit);
                        command.Options.Add(MinLevel);
                        command.Options.Add(Replica);
                        command.Options.Add(RequestId);
                        command.Options.Add(Component);
                        command.Options.Add(SearchPattern);
                        command.Options.Add(Includes);
                        command.Options.Add(Excludes);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var modelId = parseResult.GetRequiredValue(ModelId);
                        var envName = parseResult.GetRequiredValue(EnvName);
                        var startEpochMillis = parseResult.GetValue(StartEpochMillis);
                        var endEpochMillis = parseResult.GetValue(EndEpochMillis);
                        var direction = parseResult.GetValue(Direction);
                        var limit = parseResult.GetValue(Limit);
                        var minLevel = parseResult.GetValue(MinLevel);
                        var replica = parseResult.GetValue(Replica);
                        var requestId = parseResult.GetValue(RequestId);
                        var component = parseResult.GetValue(Component);
                        var searchPattern = parseResult.GetValue(SearchPattern);
                        var includes = parseResult.GetValue(Includes);
                        var excludes = parseResult.GetValue(Excludes);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetModelsByModelIdEnvironmentsByEnvNameLogsAsync(
                                    modelId: modelId,
                                    envName: envName,
                                    startEpochMillis: startEpochMillis,
                                    endEpochMillis: endEpochMillis,
                                    direction: direction,
                                    limit: limit,
                                    minLevel: minLevel,
                                    replica: replica,
                                    requestId: requestId,
                                    component: component,
                                    searchPattern: searchPattern,
                                    includes: includes,
                                    excludes: excludes,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"Logs",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Baseten.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}