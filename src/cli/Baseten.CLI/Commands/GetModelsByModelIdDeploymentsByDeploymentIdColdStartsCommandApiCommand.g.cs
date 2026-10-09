#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetModelsByModelIdDeploymentsByDeploymentIdColdStartsCommandApiCommand
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

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Opaque cursor returned by a previous page. Omit to fetch the first page. Pass the same filters and sort as the request that returned it.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of attempts to return.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Baseten.ColdStartOutcomeV1>?> Outcomes { get; } = new(
        name: @"--outcomes")
    {
        Description = @"Only include attempts with one of these outcomes. Repeat to pass several.",
    };

    private static Option<global::Baseten.ColdStartPhaseV1?> Phase { get; } = new(
        name: @"--phase")
    {
        Description = @"Only include attempts that spent longer than 0 ms in this phase.",
    };

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Only include attempts whose replica ID matches exactly, or whose deployment name contains this text (case-insensitive).",
    };

    private static Option<global::Baseten.ColdStartSortFieldV1?> SortBy { get; } = new(
        name: @"--sort-by")
    {
        Description = @"Field to sort attempts by. Defaults to `STARTED_AT`.",
    };

    private static Option<global::Baseten.SortOrderV1?> Direction { get; } = new(
        name: @"--direction")
    {
        Description = @"Sort direction. Defaults to `desc`.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.ColdStartAttemptsV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.ColdStartAttemptsV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-models-by-model-id-deployments-by-deployment-id-cold-starts", @"Lists the cold starts of a model deployment
Lists replica cold starts in the given time range, newest first by default. Pass the `cursor` from a response to fetch the next page.");
                        command.Arguments.Add(ModelId);
                        command.Arguments.Add(DeploymentId);
                        command.Options.Add(StartEpochMillis);
                        command.Options.Add(EndEpochMillis);
                        command.Options.Add(MinDurationMs);
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(Outcomes);
                        command.Options.Add(Phase);
                        command.Options.Add(Search);
                        command.Options.Add(SortBy);
                        command.Options.Add(Direction);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var modelId = parseResult.GetRequiredValue(ModelId);
                        var deploymentId = parseResult.GetRequiredValue(DeploymentId);
                        var startEpochMillis = parseResult.GetRequiredValue(StartEpochMillis);
                        var endEpochMillis = parseResult.GetRequiredValue(EndEpochMillis);
                        var minDurationMs = parseResult.GetValue(MinDurationMs);
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var outcomes = parseResult.GetValue(Outcomes);
                        var phase = parseResult.GetValue(Phase);
                        var search = parseResult.GetValue(Search);
                        var sortBy = parseResult.GetValue(SortBy);
                        var direction = parseResult.GetValue(Direction);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetModelsByModelIdDeploymentsByDeploymentIdColdStartsAsync(
                                    modelId: modelId,
                                    deploymentId: deploymentId,
                                    startEpochMillis: startEpochMillis,
                                    endEpochMillis: endEpochMillis,
                                    minDurationMs: minDurationMs,
                                    cursor: cursor,
                                    limit: limit,
                                    outcomes: outcomes,
                                    phase: phase,
                                    search: search,
                                    sortBy: sortBy,
                                    direction: direction,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"Items",
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