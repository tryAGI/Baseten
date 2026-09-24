#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetExploreMetadataCommandApiCommand
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

    private static Option<string?> Provider { get; } = new(
        name: @"--provider")
    {
        Description = @"Filter to a provider by slug prefix, e.g. 'anthropic'. Preserved by the cursor; if repeated, must match the original filter.",
    };

    private static Option<string?> Q { get; } = new(
        name: @"--q")
    {
        Description = @"Case-insensitive substring search over metadata slugs. Preserved by the cursor; if repeated, must match the original filter.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.ExploreMetadataResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.ExploreMetadataResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-explore-metadata", @"Lists model metadata
Lists all live model metadata rows, e.g. for model pickers.");
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(Provider);
                        command.Options.Add(Q);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var provider = parseResult.GetValue(Provider);
                        var q = parseResult.GetValue(Q);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetExploreMetadataAsync(
                                    cursor: cursor,
                                    limit: limit,
                                    provider: provider,
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
        return command;
    }
}