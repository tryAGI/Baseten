#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetGridMachineUsersCommandApiCommand
{
    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Opaque cursor returned by a previous page. Omit to fetch the first page.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of items to return.",
    };

    private static Option<string?> TeamId { get; } = new(
        name: @"--team-id")
    {
        Description = @"Limit machine users to this team. Without it, every team you administer.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.GridMachineUsersResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.GridMachineUsersResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-grid-machine-users", @"Lists machine users
Lists machine users, newest first: the team's with `team_id`, which requires team admin for it, else those of every team you administer.");
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(TeamId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var teamId = parseResult.GetValue(TeamId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetGridMachineUsersAsync(
                                    cursor: cursor,
                                    limit: limit,
                                    teamId: teamId,
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