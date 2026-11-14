#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateAccessTrustRulesVerifyCommandApiCommand
{
    private static Option<string> IdentityProviderId { get; } = new(
        name: @"--identity-provider-id")
    {
        Description = @"The identity provider the rule is for, which decides the claims it must pin",
        Required = true,
    };

    private static Option<string> Condition { get; } = new(
        name: @"--condition")
    {
        Description = @"A CEL expression over the token's `claims` that must evaluate to true. It must pin a specific `claims.sub` in a top-level `&&` clause, plus any provider-required checks. Up to 4,096 characters.",
        Required = true,
    };

    private static Option<string> Audience { get; } = new(
        name: @"--audience")
    {
        Description = @"The token's `aud` must equal this, or contain it when `aud` is a list. Up to 1,024 characters.",
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
        var command = new Command(commandName ?? @"create-access-trust-rules-verify", @"Checks a trust rule's condition and audience
Runs the checks that creating or updating a trust rule runs on its condition and audience, without saving anything: that the condition compiles and pins the claims the identity provider requires. A failed check returns 200 with `valid` false and the reason.");
                        command.Options.Add(IdentityProviderId);
                        command.Options.Add(Condition);
                        command.Options.Add(Audience);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var identityProviderId = parseResult.GetRequiredValue(IdentityProviderId);
                        var condition = parseResult.GetRequiredValue(Condition);
                        var audience = parseResult.GetRequiredValue(Audience);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateAccessTrustRulesVerifyAsync(
                                    identityProviderId: identityProviderId,
                                    condition: condition,
                                    audience: audience,
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