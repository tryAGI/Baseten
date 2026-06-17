#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateModelsByModelIdEnvironmentsByEnvNamePromoteCommandApiCommand
{
    private static Argument<string> ModelId { get; } = new(
        name: @"model-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> EnvName { get; } = new(
        name: @"env-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<bool?> ScaleDownPreviousDeployment { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--scale-down-previous-deployment",
        description: @"Whether to scale down the previous deployment after promoting");

    private static Option<string> DeploymentId { get; } = new(
        name: @"--deployment-id")
    {
        Description = @"The id of the deployment to promote",
        Required = true,
    };

    private static Option<bool?> PreserveEnvInstanceType { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--preserve-env-instance-type",
        description: @"Whether to use the promoting deployment's instance type or preserve target environment's instance type");
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
        var command = new Command(@"create-models-by-model-id-environments-by-env-name-promote", @"Promotes a deployment to an environment
Promotes an existing deployment to an environment and returns the promoted deployment.");
                        command.Arguments.Add(ModelId);
                        command.Arguments.Add(EnvName);
                        command.Options.Add(ScaleDownPreviousDeployment);
                        command.Options.Add(DeploymentId);
                        command.Options.Add(PreserveEnvInstanceType);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.PromoteToEnvironmentRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var modelId = parseResult.GetRequiredValue(ModelId);
                        var envName = parseResult.GetRequiredValue(EnvName);
                        var scaleDownPreviousDeployment = CliRuntime.WasSpecified(parseResult, ScaleDownPreviousDeployment) ? parseResult.GetValue(ScaleDownPreviousDeployment) : (__requestBase is { } __ScaleDownPreviousDeploymentBaseValue ? __ScaleDownPreviousDeploymentBaseValue.ScaleDownPreviousDeployment : default);
                        var deploymentId = parseResult.GetRequiredValue(DeploymentId);
                        var preserveEnvInstanceType = CliRuntime.WasSpecified(parseResult, PreserveEnvInstanceType) ? parseResult.GetValue(PreserveEnvInstanceType) : (__requestBase is { } __PreserveEnvInstanceTypeBaseValue ? __PreserveEnvInstanceTypeBaseValue.PreserveEnvInstanceType : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateModelsByModelIdEnvironmentsByEnvNamePromoteAsync(
                                    modelId: modelId,
                                    envName: envName,
                                    scaleDownPreviousDeployment: scaleDownPreviousDeployment,
                                    deploymentId: deploymentId,
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