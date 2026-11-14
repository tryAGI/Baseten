#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateAccessIdentityProvidersVerifyCommandApiCommand
{
    private static Option<global::Baseten.VerifyPredefinedIdentityProviderConfigV1> Predefined { get; } = new(
        name: @"--predefined")
    {
        Description = @"The predefined provider to check, as you'd pass it when adding it",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.VerificationV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.VerificationV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-access-identity-providers-verify", @"Checks an identity provider before adding it
Runs the checks that adding the identity provider runs, without adding it: the issuer's format, that the organization doesn't have it yet, and, for a provider with a per-customer issuer, that its signing keys can be fetched. A failed check returns 200 with `valid` false and the reason. Only organization admins can call this endpoint.");
                        command.Options.Add(Predefined);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var predefined = parseResult.GetRequiredValue(Predefined);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateAccessIdentityProvidersVerifyAsync(
                                    predefined: predefined,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Baseten.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}