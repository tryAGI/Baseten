#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateAccessTrustRulesCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"Name, unique in the organization. Can be changed later.",
    };

    private static Option<string?> DescriptionOption { get; } = new(
        name: @"--description")
    {
        Description = @"Optional description",
    };

    private static Option<string> IdentityProviderId { get; } = new(
        name: @"--identity-provider-id")
    {
        Description = @"Whose tokens the rule accepts. Can't be changed.",
        Required = true,
    };

    private static Option<string> ServiceAccountId { get; } = new(
        name: @"--service-account-id")
    {
        Description = @"The service account its tokens act as. Can be changed later.",
        Required = true,
    };

    private static Option<string> Condition { get; } = new(
        name: @"--condition")
    {
        Description = @"A CEL expression over the token's `claims` that must evaluate to true. It must pin a specific `claims.sub` in a top-level `&&` clause, plus any provider-required checks. Up to 4,096 characters. Can be changed later.",
        Required = true,
    };

    private static Option<string> Audience { get; } = new(
        name: @"--audience")
    {
        Description = @"The token's `aud` must equal this, or contain it when `aud` is a list. Up to 1,024 characters. Can be changed later.",
        Required = true,
    };

    private static Option<int?> MaxAccessTokenLifetimeSeconds { get; } = new(
        name: @"--max-access-token-lifetime-seconds")
    {
        Description = @"Longest lifetime of a token the rule issues, 60 to 3600 seconds. Can be changed later.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.AccessTrustRuleV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.AccessTrustRuleV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-access-trust-rules", @"Creates a trust rule
Creates a rule that lets tokens from an identity provider act as a service account. Organization admins can create rules for any service account, team admins for their own team's. An organization API key manager key can't target organization accounts.");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(DescriptionOption);
                        command.Options.Add(IdentityProviderId);
                        command.Options.Add(ServiceAccountId);
                        command.Options.Add(Condition);
                        command.Options.Add(Audience);
                        command.Options.Add(MaxAccessTokenLifetimeSeconds);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.CreateAccessTrustRuleRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var description = CliRuntime.WasSpecified(parseResult, DescriptionOption) ? parseResult.GetValue(DescriptionOption) : (__requestBase is { } __DescriptionBaseValue ? __DescriptionBaseValue.Description : default);
                        var identityProviderId = parseResult.GetRequiredValue(IdentityProviderId);
                        var serviceAccountId = parseResult.GetRequiredValue(ServiceAccountId);
                        var condition = parseResult.GetRequiredValue(Condition);
                        var audience = parseResult.GetRequiredValue(Audience);
                        var maxAccessTokenLifetimeSeconds = CliRuntime.WasSpecified(parseResult, MaxAccessTokenLifetimeSeconds) ? parseResult.GetValue(MaxAccessTokenLifetimeSeconds) : (__requestBase is { } __MaxAccessTokenLifetimeSecondsBaseValue ? __MaxAccessTokenLifetimeSecondsBaseValue.MaxAccessTokenLifetimeSeconds : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateAccessTrustRulesAsync(
                                    name: name,
                                    description: description,
                                    identityProviderId: identityProviderId,
                                    serviceAccountId: serviceAccountId,
                                    condition: condition,
                                    audience: audience,
                                    maxAccessTokenLifetimeSeconds: maxAccessTokenLifetimeSeconds,
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