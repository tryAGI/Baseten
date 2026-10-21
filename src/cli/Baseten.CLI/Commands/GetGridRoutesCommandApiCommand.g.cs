#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetGridRoutesCommandApiCommand
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
        Description = @"Limit routes to this team. Without it, routes from every team where you can invoke routes.",
    };

    private static Option<bool?> ForHarnesses { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--for-harnesses",
        description: @"Set by harness setup and sync. Returns routes from exactly one team: `team_id`, else the team you belong to; when you belong to several and name none, the request fails with a 400.");

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Filter by exact route name. Preserved by the cursor; if repeated, must match the original filter.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.GridRoutesResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.GridRoutesResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-grid-routes", @"Lists routes
Lists routes you can invoke, newest first, optionally filtered by exact name. Without `team_id`, routes from every team where you can invoke routes. With `for_harnesses`, exactly one team: `team_id`, else the team you belong to; when you belong to several and name none, the request fails with a 400.");
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(TeamId);
                        command.Options.Add(ForHarnesses);
                        command.Options.Add(NameOption);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var teamId = parseResult.GetValue(TeamId);
                        var forHarnesses = parseResult.GetValue(ForHarnesses);
                        var name = parseResult.GetValue(NameOption);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetGridRoutesAsync(
                                    cursor: cursor,
                                    limit: limit,
                                    teamId: teamId,
                                    forHarnesses: forHarnesses,
                                    name: name,
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