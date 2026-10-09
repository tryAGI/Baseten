#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetModelsByModelIdEnvironmentsByEnvNameColdStartsSummaryCommandApiCommand
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

    private static Option<int> StartEpochMillis { get; } = new(
        name: @"--start-epoch-millis")
    {
        Description = @"Start of the query window, in epoch milliseconds.",
        Required = true,
    };

    private static Option<int> EndEpochMillis { get; } = new(
        name: @"--end-epoch-millis")
    {
        Description = @"End of the query window, in epoch milliseconds. Must be after the start.",
        Required = true,
    };

    private static Option<int?> MinDurationMs { get; } = new(
        name: @"--min-duration-ms")
    {
        Description = @"Only include cold starts that lasted at least this many milliseconds.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.ColdStartSummaryV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.ColdStartSummaryV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-models-by-model-id-environments-by-env-name-cold-starts-summary", @"Gets the cold start summary for a model environment
Gets the distribution of replica cold start durations, in total and per phase, across every deployment that was active on the environment in the given time range.");
                        command.Arguments.Add(ModelId);
                        command.Arguments.Add(EnvName);
                        command.Options.Add(StartEpochMillis);
                        command.Options.Add(EndEpochMillis);
                        command.Options.Add(MinDurationMs);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var modelId = parseResult.GetRequiredValue(ModelId);
                        var envName = parseResult.GetRequiredValue(EnvName);
                        var startEpochMillis = parseResult.GetRequiredValue(StartEpochMillis);
                        var endEpochMillis = parseResult.GetRequiredValue(EndEpochMillis);
                        var minDurationMs = parseResult.GetValue(MinDurationMs);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetModelsByModelIdEnvironmentsByEnvNameColdStartsSummaryAsync(
                                    modelId: modelId,
                                    envName: envName,
                                    startEpochMillis: startEpochMillis,
                                    endEpochMillis: endEpochMillis,
                                    minDurationMs: minDurationMs,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"PhaseDurationMs",
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
        CustomizeCommand(ref command);
        return command;
    }
}