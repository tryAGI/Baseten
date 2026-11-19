#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateAuthTokenCommandApiCommand
{
    private static Option<string> GrantType { get; } = new(
        name: @"--grant-type")
    {
        Description = @"Always `urn:ietf:params:oauth:grant-type:token-exchange`",
        Required = true,
    };

    private static Option<string> SubjectToken { get; } = new(
        name: @"--subject-token")
    {
        Description = @"The identity provider's JWT",
        Required = true,
    };

    private static Option<string> SubjectTokenType { get; } = new(
        name: @"--subject-token-type")
    {
        Description = @"`urn:ietf:params:oauth:token-type:jwt` or `urn:ietf:params:oauth:token-type:id_token`",
        Required = true,
    };

    private static Option<string> Audience { get; } = new(
        name: @"--audience")
    {
        Description = @"ID of the trust rule to check the JWT against",
        Required = true,
    };

    private static Option<string?> RequestedTokenType { get; } = new(
        name: @"--requested-token-type")
    {
        Description = @"Optional; only `urn:ietf:params:oauth:token-type:access_token` is issued",
    };

    private static Option<int?> AccessTokenLifetimeSeconds { get; } = new(
        name: @"--access-token-lifetime-seconds")
    {
        Description = @"Lifetime of the access token, in seconds. At most the rule's maximum.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.TokenExchangeResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.TokenExchangeResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-auth-token", @"Exchanges an identity provider's JWT for an access token
Exchanges a JWT from your identity provider for a short-lived Baseten access token, as described in RFC 8693. Send no API key: the JWT is the credential. Name the trust rule to check the JWT against as the `audience`, and send the access token as `Authorization: Bearer` on later requests. Errors follow RFC 6749 section 5.2: a 400 response with an `error` of `invalid_request`, `unsupported_grant_type`, or `invalid_grant`. A well-formed request that is refused always returns `invalid_grant`, whatever the reason.");
                        command.Options.Add(GrantType);
                        command.Options.Add(SubjectToken);
                        command.Options.Add(SubjectTokenType);
                        command.Options.Add(Audience);
                        command.Options.Add(RequestedTokenType);
                        command.Options.Add(AccessTokenLifetimeSeconds);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.TokenExchangeRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var grantType = parseResult.GetRequiredValue(GrantType);
                        var subjectToken = parseResult.GetRequiredValue(SubjectToken);
                        var subjectTokenType = parseResult.GetRequiredValue(SubjectTokenType);
                        var audience = parseResult.GetRequiredValue(Audience);
                        var requestedTokenType = CliRuntime.WasSpecified(parseResult, RequestedTokenType) ? parseResult.GetValue(RequestedTokenType) : (__requestBase is { } __RequestedTokenTypeBaseValue ? __RequestedTokenTypeBaseValue.RequestedTokenType : default);
                        var accessTokenLifetimeSeconds = CliRuntime.WasSpecified(parseResult, AccessTokenLifetimeSeconds) ? parseResult.GetValue(AccessTokenLifetimeSeconds) : (__requestBase is { } __AccessTokenLifetimeSecondsBaseValue ? __AccessTokenLifetimeSecondsBaseValue.AccessTokenLifetimeSeconds : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateAuthTokenAsync(
                                    grantType: grantType,
                                    subjectToken: subjectToken,
                                    subjectTokenType: subjectTokenType,
                                    audience: audience,
                                    requestedTokenType: requestedTokenType,
                                    accessTokenLifetimeSeconds: accessTokenLifetimeSeconds,
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