#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditOrganizationsMeCommandApiCommand
{
    private static Option<bool?> AllowPersonalApiKeys { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--allow-personal-api-keys",
        description: @"Whether members can create new personal API keys. Null is not accepted.");

    private static Option<bool?> AllowServiceAccountApiKeys { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--allow-service-account-api-keys",
        description: @"Whether new team and organization API keys can be created. Null is not accepted.");
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.OrganizationInfoV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.OrganizationInfoV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"edit-organizations-me", @"Updates the authenticated organization
Updates settings of the organization of the user making the request. Only organization admins can call it. Omitted fields are unchanged.");
                        command.Options.Add(AllowPersonalApiKeys);
                        command.Options.Add(AllowServiceAccountApiKeys);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.UpdateOrganizationRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var allowPersonalApiKeys = CliRuntime.WasSpecified(parseResult, AllowPersonalApiKeys) ? parseResult.GetValue(AllowPersonalApiKeys) : (__requestBase is { } __AllowPersonalApiKeysBaseValue ? __AllowPersonalApiKeysBaseValue.AllowPersonalApiKeys : default);
                        var allowServiceAccountApiKeys = CliRuntime.WasSpecified(parseResult, AllowServiceAccountApiKeys) ? parseResult.GetValue(AllowServiceAccountApiKeys) : (__requestBase is { } __AllowServiceAccountApiKeysBaseValue ? __AllowServiceAccountApiKeysBaseValue.AllowServiceAccountApiKeys : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditOrganizationsMeAsync(
                                    allowPersonalApiKeys: allowPersonalApiKeys,
                                    allowServiceAccountApiKeys: allowServiceAccountApiKeys,
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