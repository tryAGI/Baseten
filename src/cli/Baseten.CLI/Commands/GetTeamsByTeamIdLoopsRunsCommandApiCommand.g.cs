#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetTeamsByTeamIdLoopsRunsCommandApiCommand
{
    private static Argument<string> TeamId { get; } = new(
        name: @"team-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<string?> RunId { get; } = new(
        name: @"--run-id")
    {
        Description = @"Filter by run ID.",
    };

    private static Option<string?> BaseModel { get; } = new(
        name: @"--base-model")
    {
        Description = @"Filter runs by base model name.",
    };

    private static Option<string?> Scope { get; } = new(
        name: @"--scope")
    {
        Description = @"Defaults to the caller's own runs; pass 'org' to list every run in the caller's organization.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.ListLoopsRunsResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.ListLoopsRunsResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-teams-by-team-id-loops-runs", @"Lists a team's Loops runs
Lists Loops runs in the given team, visible to the requesting user, optionally filtered by run id and/or base model.");
                        command.Arguments.Add(TeamId);
                        command.Options.Add(RunId);
                        command.Options.Add(BaseModel);
                        command.Options.Add(Scope);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var teamId = parseResult.GetRequiredValue(TeamId);
                        var runId = parseResult.GetValue(RunId);
                        var baseModel = parseResult.GetValue(BaseModel);
                        var scope = parseResult.GetValue(Scope);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetTeamsByTeamIdLoopsRunsAsync(
                                    teamId: teamId,
                                    runId: runId,
                                    baseModel: baseModel,
                                    scope: scope,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"Runs",
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