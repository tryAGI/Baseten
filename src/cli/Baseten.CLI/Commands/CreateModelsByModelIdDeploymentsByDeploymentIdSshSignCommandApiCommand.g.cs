#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateModelsByModelIdDeploymentsByDeploymentIdSshSignCommandApiCommand
{
    private static Argument<string> ModelId { get; } = new(
        name: @"model-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> DeploymentId { get; } = new(
        name: @"deployment-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };
    private static readonly SignSSHCertificateRequestV1OptionSet SignSSHCertificateRequestV1OptionSetOptions = SignSSHCertificateRequestV1OptionSet.Create();
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.SignSSHCertificateResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.SignSSHCertificateResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-models-by-model-id-deployments-by-deployment-id-ssh-sign", @"Signs an SSH certificate for an inference model
Signs a short-lived SSH certificate granting access to a running inference model pod. Returns the signed SSH certificate, a JWT token for SSH proxy authentication, the proxy address to connect through, and the certificate expiry time.");
                        command.Arguments.Add(ModelId);
                        command.Arguments.Add(DeploymentId);                        command.Options.Add(SignSSHCertificateRequestV1OptionSetOptions.PublicKey);
                        command.Options.Add(SignSSHCertificateRequestV1OptionSetOptions.ReplicaId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.SignSSHCertificateRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var modelId = parseResult.GetRequiredValue(ModelId);
                        var deploymentId = parseResult.GetRequiredValue(DeploymentId);                        var publicKey = parseResult.GetRequiredValue(SignSSHCertificateRequestV1OptionSetOptions.PublicKey);
                        var replicaId = CliRuntime.WasSpecified(parseResult, SignSSHCertificateRequestV1OptionSetOptions.ReplicaId) ? parseResult.GetValue(SignSSHCertificateRequestV1OptionSetOptions.ReplicaId) : (__requestBase is { } __ReplicaIdBaseValue ? __ReplicaIdBaseValue.ReplicaId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateModelsByModelIdDeploymentsByDeploymentIdSshSignAsync(
                                    modelId: modelId,
                                    deploymentId: deploymentId,
                                    publicKey: publicKey,
                                    replicaId: replicaId,
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