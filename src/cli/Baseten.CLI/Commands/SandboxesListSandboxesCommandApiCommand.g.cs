#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class SandboxesListSandboxesCommandApiCommand
{
    private static Option<string?> TeamId { get; } = new(
        name: @"--team-id")
    {
        Description = @"Optional team ID. Must match X-Team-Id when both are supplied. If neither selector is supplied, defaults to the caller's only accessible team. Callers with multiple accessible teams must select a team. Requests without access to any team are forbidden.",
    };

    private static Option<string?> XTeamId { get; } = new(
        name: @"--x-team-id")
    {
        Description = @"Optional team ID. Must match the team_id query parameter when both are supplied. If neither selector is supplied, defaults to the caller's only accessible team. Callers with multiple accessible teams must select a team. Requests without access to any team are forbidden.",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Opaque cursor from the previous page; omit for the first page.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of items to return.",
    };

    private static Option<string?> Q { get; } = new(
        name: @"--q")
    {
        Description = @"Search indexed sandbox names and labels. Search is applied before pagination.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Deployment statuses. Repeat the query parameter for each status, for example status=DEPLOYED&status=FAILED. Unknown values are rejected. Cannot be combined with external_id.",
    };

    private static Option<string?> ExternalId { get; } = new(
        name: @"--external-id")
    {
        Description = @"Filter by a caller-owned external identifier. Cannot be combined with status.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.ListSandboxesResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.ListSandboxesResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"list-sandboxes", @"List sandboxes
Return a cursor-paginated page of sandboxes. Terminated sandboxes are hidden by default.");
                        command.Options.Add(TeamId);
                        command.Options.Add(XTeamId);
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(Q);
                        command.Options.Add(Status);
                        command.Options.Add(ExternalId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var teamId = parseResult.GetValue(TeamId);
                        var xTeamId = parseResult.GetValue(XTeamId);
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var q = parseResult.GetValue(Q);
                        var status = parseResult.GetValue(Status);
                        var externalId = parseResult.GetValue(ExternalId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Sandboxes.ListSandboxesAsync(
                                    teamId: teamId,
                                    xTeamId: xTeamId,
                                    cursor: cursor,
                                    limit: limit,
                                    q: q,
                                    status: status,
                                    externalId: externalId,
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