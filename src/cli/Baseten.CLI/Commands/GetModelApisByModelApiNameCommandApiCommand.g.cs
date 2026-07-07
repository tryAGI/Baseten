#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class GetModelApisByModelApiNameCommandApiCommand
{
    private static Argument<string> ModelApiName { get; } = new(
        name: @"model-api-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.ModelAPIV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.ModelAPIV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-model-apis-by-model-api-name", @"Gets a Model API
Fetches a Model API by name, with workspace overlay when added.");
                        command.Arguments.Add(ModelApiName);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var modelApiName = parseResult.GetRequiredValue(ModelApiName);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.GetModelApisByModelApiNameAsync(
                                    modelApiName: modelApiName,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Baseten.SourceGenerationContext.Default,
                                        @"RateLimits",
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