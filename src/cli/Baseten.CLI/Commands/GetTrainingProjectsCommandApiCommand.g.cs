#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetTrainingProjectsCommandApiCommand
{
    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Return only the project with this exact name.",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Opaque cursor from the pagination.cursor field of a previous response. Omit both cursor and limit to get every project in one response.",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of projects to return, up to 1000.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.ListTrainingProjectsResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.ListTrainingProjectsResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-training-projects", @"Lists training projects
Lists the organization's training projects, newest first.");
                        command.Options.Add(NameOption);
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var name = parseResult.GetValue(NameOption);
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetTrainingProjectsAsync(
                                    name: name,
                                    cursor: cursor,
                                    limit: limit,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"TrainingProjects",
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