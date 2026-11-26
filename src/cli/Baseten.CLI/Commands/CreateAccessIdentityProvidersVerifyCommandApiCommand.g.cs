#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateAccessIdentityProvidersVerifyCommandApiCommand
{
    private static Option<global::Baseten.VerifyPredefinedIdentityProviderConfigV1?> Predefined { get; } = new(
        name: @"--predefined")
    {
        Description = @"The predefined provider to check, as you'd pass it when adding it. Pass this or `custom`.",
    };

    private static Option<global::Baseten.VerifyCustomIdentityProviderConfigV1?> Custom { get; } = new(
        name: @"--custom")
    {
        Description = @"The custom provider to check, as you'd pass it when adding it. Pass this or `predefined`.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
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
Runs the checks that adding the identity provider runs, without adding it: the issuer's format, that the organization doesn't have it yet, and, for a provider with a per-customer issuer or a custom provider, that its signing keys can be read. A failed check returns 200 with `valid` false and the reason. Only organization admins can call this endpoint.");
                        command.Options.Add(Predefined);
                        command.Options.Add(Custom);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.VerifyIdentityProviderRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var predefined = CliRuntime.WasSpecified(parseResult, Predefined) ? parseResult.GetValue(Predefined) : (__requestBase is { } __PredefinedBaseValue ? __PredefinedBaseValue.Predefined : default);
                        var custom = CliRuntime.WasSpecified(parseResult, Custom) ? parseResult.GetValue(Custom) : (__requestBase is { } __CustomBaseValue ? __CustomBaseValue.Custom : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateAccessIdentityProvidersVerifyAsync(
                                    predefined: predefined,
                                    custom: custom,
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