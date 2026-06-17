#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateModelsByModelIdDeploymentsByDeploymentIdPromoteCommandApiCommand
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
    private static readonly PromoteRequestV1OptionSet PromoteRequestV1OptionSetOptions = PromoteRequestV1OptionSet.Create();
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.DeploymentV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.DeploymentV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-models-by-model-id-deployments-by-deployment-id-promote", @"Promotes a deployment to production
Promotes an existing deployment to production and returns the same deployment.");
                        command.Arguments.Add(ModelId);
                        command.Arguments.Add(DeploymentId);                        command.Options.Add(PromoteRequestV1OptionSetOptions.ScaleDownPreviousProduction);
                        command.Options.Add(PromoteRequestV1OptionSetOptions.PreserveEnvInstanceType);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.PromoteRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var modelId = parseResult.GetRequiredValue(ModelId);
                        var deploymentId = parseResult.GetRequiredValue(DeploymentId);                        var scaleDownPreviousProduction = CliRuntime.WasSpecified(parseResult, PromoteRequestV1OptionSetOptions.ScaleDownPreviousProduction) ? parseResult.GetValue(PromoteRequestV1OptionSetOptions.ScaleDownPreviousProduction) : (__requestBase is { } __ScaleDownPreviousProductionBaseValue ? __ScaleDownPreviousProductionBaseValue.ScaleDownPreviousProduction : default);
                        var preserveEnvInstanceType = CliRuntime.WasSpecified(parseResult, PromoteRequestV1OptionSetOptions.PreserveEnvInstanceType) ? parseResult.GetValue(PromoteRequestV1OptionSetOptions.PreserveEnvInstanceType) : (__requestBase is { } __PreserveEnvInstanceTypeBaseValue ? __PreserveEnvInstanceTypeBaseValue.PreserveEnvInstanceType : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateModelsByModelIdDeploymentsByDeploymentIdPromoteAsync(
                                    modelId: modelId,
                                    deploymentId: deploymentId,
                                    scaleDownPreviousProduction: scaleDownPreviousProduction,
                                    preserveEnvInstanceType: preserveEnvInstanceType,
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