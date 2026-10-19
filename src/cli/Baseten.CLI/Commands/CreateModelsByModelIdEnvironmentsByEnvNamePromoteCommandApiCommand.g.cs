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
    private static readonly PromotionEnvironmentSettingsUpdateV1OptionSet EnvironmentSettingsUpdateOptions = PromotionEnvironmentSettingsUpdateV1OptionSet.Create(@"environment-settings-update");

    private static readonly UpdatePromotionSettingsV1OptionSet PromotionSettingsOverrideOptions = UpdatePromotionSettingsV1OptionSet.Create(@"promotion-settings-override");
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


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-models-by-model-id-environments-by-env-name-promote", @"Promotes a deployment to an environment
Promotes an existing deployment to an environment and returns the promoted deployment.");
                        command.Arguments.Add(ModelId);
                        command.Arguments.Add(EnvName);
                        command.Options.Add(ScaleDownPreviousDeployment);
                        command.Options.Add(DeploymentId);
                        command.Options.Add(PreserveEnvInstanceType);                        command.Options.Add(EnvironmentSettingsUpdateOptions.Region);
                        command.Options.Add(EnvironmentSettingsUpdateOptions.InstanceTypeId);                        command.Options.Add(PromotionSettingsOverrideOptions.RedeployOnPromotion);
                        command.Options.Add(PromotionSettingsOverrideOptions.RollingDeploy);
                        command.Options.Add(PromotionSettingsOverrideOptions.RampUpWhilePromoting);
                        command.Options.Add(PromotionSettingsOverrideOptions.RampUpDurationSeconds);
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

                        var __EnvironmentSettingsUpdateBase = __requestBase is { } __EnvironmentSettingsUpdateBaseValue ? __EnvironmentSettingsUpdateBaseValue.EnvironmentSettingsUpdate : default;                        var environmentSettingsUpdateRegion = CliRuntime.WasSpecified(parseResult, EnvironmentSettingsUpdateOptions.Region) ? parseResult.GetValue(EnvironmentSettingsUpdateOptions.Region) : (__EnvironmentSettingsUpdateBase is { } __EnvironmentSettingsUpdateregionBaseValue ? __EnvironmentSettingsUpdateregionBaseValue.Region : default);
                        var environmentSettingsUpdateInstanceTypeId = CliRuntime.WasSpecified(parseResult, EnvironmentSettingsUpdateOptions.InstanceTypeId) ? parseResult.GetValue(EnvironmentSettingsUpdateOptions.InstanceTypeId) : (__EnvironmentSettingsUpdateBase is { } __EnvironmentSettingsUpdateinstanceTypeIdBaseValue ? __EnvironmentSettingsUpdateinstanceTypeIdBaseValue.InstanceTypeId : default);
                        var __EnvironmentSettingsUpdateSpecified = CliRuntime.WasSpecified(parseResult, EnvironmentSettingsUpdateOptions.Region) || CliRuntime.WasSpecified(parseResult, EnvironmentSettingsUpdateOptions.InstanceTypeId);
                        var environmentSettingsUpdate =
                            __EnvironmentSettingsUpdateSpecified || __EnvironmentSettingsUpdateBase is not null
                                ? new global::Baseten.PromotionEnvironmentSettingsUpdateV1
                                {
	                                Region = environmentSettingsUpdateRegion,
                                InstanceTypeId = environmentSettingsUpdateInstanceTypeId,

                                }
                                : __EnvironmentSettingsUpdateBase;

                        var __PromotionSettingsOverrideBase = __requestBase is { } __PromotionSettingsOverrideBaseValue ? __PromotionSettingsOverrideBaseValue.PromotionSettingsOverride : default;                        var promotionSettingsOverrideRedeployOnPromotion = CliRuntime.WasSpecified(parseResult, PromotionSettingsOverrideOptions.RedeployOnPromotion) ? parseResult.GetValue(PromotionSettingsOverrideOptions.RedeployOnPromotion) : (__PromotionSettingsOverrideBase is { } __PromotionSettingsOverrideredeployOnPromotionBaseValue ? __PromotionSettingsOverrideredeployOnPromotionBaseValue.RedeployOnPromotion : default);
                        var promotionSettingsOverrideRollingDeploy = CliRuntime.WasSpecified(parseResult, PromotionSettingsOverrideOptions.RollingDeploy) ? parseResult.GetValue(PromotionSettingsOverrideOptions.RollingDeploy) : (__PromotionSettingsOverrideBase is { } __PromotionSettingsOverriderollingDeployBaseValue ? __PromotionSettingsOverriderollingDeployBaseValue.RollingDeploy : default);
                        var promotionSettingsOverrideRampUpWhilePromoting = CliRuntime.WasSpecified(parseResult, PromotionSettingsOverrideOptions.RampUpWhilePromoting) ? parseResult.GetValue(PromotionSettingsOverrideOptions.RampUpWhilePromoting) : (__PromotionSettingsOverrideBase is { } __PromotionSettingsOverriderampUpWhilePromotingBaseValue ? __PromotionSettingsOverriderampUpWhilePromotingBaseValue.RampUpWhilePromoting : default);
                        var promotionSettingsOverrideRampUpDurationSeconds = CliRuntime.WasSpecified(parseResult, PromotionSettingsOverrideOptions.RampUpDurationSeconds) ? parseResult.GetValue(PromotionSettingsOverrideOptions.RampUpDurationSeconds) : (__PromotionSettingsOverrideBase is { } __PromotionSettingsOverriderampUpDurationSecondsBaseValue ? __PromotionSettingsOverriderampUpDurationSecondsBaseValue.RampUpDurationSeconds : default);
                        var __PromotionSettingsOverrideSpecified = CliRuntime.WasSpecified(parseResult, PromotionSettingsOverrideOptions.RedeployOnPromotion) || CliRuntime.WasSpecified(parseResult, PromotionSettingsOverrideOptions.RollingDeploy) || CliRuntime.WasSpecified(parseResult, PromotionSettingsOverrideOptions.RampUpWhilePromoting) || CliRuntime.WasSpecified(parseResult, PromotionSettingsOverrideOptions.RampUpDurationSeconds);
                        var promotionSettingsOverride =
                            __PromotionSettingsOverrideSpecified || __PromotionSettingsOverrideBase is not null
                                ? new global::Baseten.UpdatePromotionSettingsV1
                                {
	                                RedeployOnPromotion = promotionSettingsOverrideRedeployOnPromotion,
                                RollingDeploy = promotionSettingsOverrideRollingDeploy,
                                RampUpWhilePromoting = promotionSettingsOverrideRampUpWhilePromoting,
                                RampUpDurationSeconds = promotionSettingsOverrideRampUpDurationSeconds,

                                }
                                : __PromotionSettingsOverrideBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateModelsByModelIdEnvironmentsByEnvNamePromoteAsync(
                                    modelId: modelId,
                                    envName: envName,
                                    scaleDownPreviousDeployment: scaleDownPreviousDeployment,
                                    deploymentId: deploymentId,
                                    preserveEnvInstanceType: preserveEnvInstanceType,
                                    environmentSettingsUpdate: environmentSettingsUpdate,
                                    promotionSettingsOverride: promotionSettingsOverride,
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