#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateTokenCommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<global::Baseten.TokenScopeV1>> Scopes { get; } = new(
        name: @"--scopes")
    {
        Description = @"What the token should grant access to. Only `sandboxes` is supported today; the token then authenticates against the sandbox API.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.TokenV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.TokenV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-token", @"Creates a sandbox access token
Exchanges your Baseten credentials for a short-lived token that authenticates against the sandbox API. The token carries every team you belong to. Tokens expire after two hours and cannot be renewed; request a new one when needed. This endpoint is experimental and may change or be removed without notice.");
                        command.Options.Add(Scopes);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var scopes = parseResult.GetRequiredValue(Scopes);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateTokenAsync(
                                    scopes: scopes,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Baseten.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}