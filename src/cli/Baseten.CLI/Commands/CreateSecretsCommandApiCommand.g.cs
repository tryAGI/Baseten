#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateSecretsCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"Name of the new or existing secret",
    };
    private static readonly UpsertSecretRequestV1OptionSet UpsertSecretRequestV1OptionSetOptions = UpsertSecretRequestV1OptionSet.Create();

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.SecretV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.SecretV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-secrets", @"Upserts a secret
Creates or updates a secret by name. Scoped to the caller's primary team; use the team-scoped variant to target a specific team.");
                        command.Arguments.Add(NameOption);                        command.Options.Add(UpsertSecretRequestV1OptionSetOptions.Value);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var name = parseResult.GetRequiredValue(NameOption);                        var value = parseResult.GetRequiredValue(UpsertSecretRequestV1OptionSetOptions.Value);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateSecretsAsync(
                                    name: name,
                                    value: value,
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