#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateKeysCommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<string>?> ModelIds { get; } = new(
        name: @"--model-ids")
    {
        Description = @"List of model IDs to scope the API key to, only present if type is 'WORKSPACE_EXPORT_METRICS' or 'WORKSPACE_INVOKE'",
    };
    private static readonly CreateAPIKeyRequestV1OptionSet CreateAPIKeyRequestV1OptionSetOptions = CreateAPIKeyRequestV1OptionSet.Create();
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.APIKeyV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.APIKeyV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-keys", @"Creates an API key
Creates an API key with the provided name and type. The API key is returned in the response.");
                        command.Options.Add(ModelIds);                        command.Options.Add(CreateAPIKeyRequestV1OptionSetOptions.NameOption);
                        command.Options.Add(CreateAPIKeyRequestV1OptionSetOptions.Type);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.CreateAPIKeyRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var modelIds = CliRuntime.WasSpecified(parseResult, ModelIds) ? parseResult.GetValue(ModelIds) : (__requestBase is { } __ModelIdsBaseValue ? __ModelIdsBaseValue.ModelIds : default);                        var name = CliRuntime.WasSpecified(parseResult, CreateAPIKeyRequestV1OptionSetOptions.NameOption) ? parseResult.GetValue(CreateAPIKeyRequestV1OptionSetOptions.NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var type = parseResult.GetRequiredValue(CreateAPIKeyRequestV1OptionSetOptions.Type);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateKeysAsync(
                                    modelIds: modelIds,
                                    name: name,
                                    type: type,
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