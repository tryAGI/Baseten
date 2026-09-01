#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateVolumesTokenCommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<global::Baseten.VolumeTokenScopeV1>> Scopes { get; } = new(
        name: @"--scopes")
    {
        Description = @"Capabilities the token grants, at least one. Requesting PUSH or TAG requires organization-level model management permission.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<string>> Namespaces { get; } = new(
        name: @"--namespaces")
    {
        Description = @"Volume namespaces the token is limited to, lowercase ASCII, at least one. Pass only the namespaces the operation needs.",
        Required = true,
    };

    private static Option<string?> CorrelationId { get; } = new(
        name: @"--correlation-id")
    {
        Description = @"Optional client-chosen identifier, at most 128 printable ASCII characters. Echoed into server logs to link the issued token to a client operation.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.CreateVolumeTokenResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.CreateVolumeTokenResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-volumes-token", @"Creates a volume access token
Exchanges your API key for a short-lived token that authenticates against Baseten volume storage. A volume token is needed only to push and pull volume data; other volume operations use your API key directly. Tokens expire after one hour and cannot be renewed; exchange again for a fresh token. Push and tag capabilities require organization-level model management permission. Pass correlation_id to link the issued token to a client operation in server logs.");
                        command.Options.Add(Scopes);
                        command.Options.Add(Namespaces);
                        command.Options.Add(CorrelationId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.CreateVolumeTokenRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var scopes = parseResult.GetRequiredValue(Scopes);
                        var namespaces = parseResult.GetRequiredValue(Namespaces);
                        var correlationId = CliRuntime.WasSpecified(parseResult, CorrelationId) ? parseResult.GetValue(CorrelationId) : (__requestBase is { } __CorrelationIdBaseValue ? __CorrelationIdBaseValue.CorrelationId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateVolumesTokenAsync(
                                    scopes: scopes,
                                    namespaces: namespaces,
                                    correlationId: correlationId,
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