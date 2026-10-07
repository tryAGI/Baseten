#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class ImagesListImagesCommandApiCommand
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

    private static Option<string?> Sort { get; } = new(
        name: @"--sort")
    {
        Description = @"Sort by repository name or creation time: name:asc, name:desc, createdAt:asc, or createdAt:desc. Keep the same sort when following a cursor.",
    };

    private static Option<string?> Q { get; } = new(
        name: @"--q")
    {
        Description = @"Case-sensitive repository name prefix. Search is applied before pagination.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.ListImagesResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.ListImagesResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"list-images", @"List sandbox images
Return one cursor-paginated page of image repository summaries. Tags are listed separately. Pages can be empty when non-sandbox repositories are excluded; follow pagination.cursor while pagination.has_more is true. Prefix search forces ascending name order.");
                        command.Options.Add(TeamId);
                        command.Options.Add(XTeamId);
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(Sort);
                        command.Options.Add(Q);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var teamId = parseResult.GetValue(TeamId);
                        var xTeamId = parseResult.GetValue(XTeamId);
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var sort = parseResult.GetValue(Sort);
                        var q = parseResult.GetValue(Q);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Images.ListImagesAsync(
                                    teamId: teamId,
                                    xTeamId: xTeamId,
                                    cursor: cursor,
                                    limit: limit,
                                    sort: sort,
                                    q: q,
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