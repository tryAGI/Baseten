#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditModelsByModelIdEnvironmentsByEnvNameCommandApiCommand
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
    private static readonly UpdateAutoscalingSettingsV1OptionSet AutoscalingSettingsOptions = UpdateAutoscalingSettingsV1OptionSet.Create(@"autoscaling-settings");

    private static readonly UpdatePromotionSettingsV1OptionSet PromotionSettingsOptions = UpdatePromotionSettingsV1OptionSet.Create(@"promotion-settings");
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.UpdateAutoscalingSettingsResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.UpdateAutoscalingSettingsResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"edit-models-by-model-id-environments-by-env-name", @"Update an environment's settings
Asynchronously updates an environment's settings. Poll the GET endpoint for the applied state.");
                        command.Arguments.Add(ModelId);
                        command.Arguments.Add(EnvName);                        command.Options.Add(AutoscalingSettingsOptions.MinReplica);
                        command.Options.Add(AutoscalingSettingsOptions.MaxReplica);
                        command.Options.Add(AutoscalingSettingsOptions.AutoscalingWindow);
                        command.Options.Add(AutoscalingSettingsOptions.ScaleDownDelay);
                        command.Options.Add(AutoscalingSettingsOptions.ConcurrencyTarget);
                        command.Options.Add(AutoscalingSettingsOptions.TargetUtilizationPercentage);
                        command.Options.Add(AutoscalingSettingsOptions.TargetInFlightTokens);
                        command.Options.Add(AutoscalingSettingsOptions.MaxScaleDownRate);                        command.Options.Add(PromotionSettingsOptions.RedeployOnPromotion);
                        command.Options.Add(PromotionSettingsOptions.RollingDeploy);
                        command.Options.Add(PromotionSettingsOptions.RampUpWhilePromoting);
                        command.Options.Add(PromotionSettingsOptions.RampUpDurationSeconds);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.UpdateEnvironmentRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var modelId = parseResult.GetRequiredValue(ModelId);
                        var envName = parseResult.GetRequiredValue(EnvName);

                        var __AutoscalingSettingsBase = __requestBase is { } __AutoscalingSettingsBaseValue ? __AutoscalingSettingsBaseValue.AutoscalingSettings : default;                        var autoscalingSettingsMinReplica = CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.MinReplica) ? parseResult.GetValue(AutoscalingSettingsOptions.MinReplica) : (__AutoscalingSettingsBase is { } __AutoscalingSettingsminReplicaBaseValue ? __AutoscalingSettingsminReplicaBaseValue.MinReplica : default);
                        var autoscalingSettingsMaxReplica = CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.MaxReplica) ? parseResult.GetValue(AutoscalingSettingsOptions.MaxReplica) : (__AutoscalingSettingsBase is { } __AutoscalingSettingsmaxReplicaBaseValue ? __AutoscalingSettingsmaxReplicaBaseValue.MaxReplica : default);
                        var autoscalingSettingsAutoscalingWindow = CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.AutoscalingWindow) ? parseResult.GetValue(AutoscalingSettingsOptions.AutoscalingWindow) : (__AutoscalingSettingsBase is { } __AutoscalingSettingsautoscalingWindowBaseValue ? __AutoscalingSettingsautoscalingWindowBaseValue.AutoscalingWindow : default);
                        var autoscalingSettingsScaleDownDelay = CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.ScaleDownDelay) ? parseResult.GetValue(AutoscalingSettingsOptions.ScaleDownDelay) : (__AutoscalingSettingsBase is { } __AutoscalingSettingsscaleDownDelayBaseValue ? __AutoscalingSettingsscaleDownDelayBaseValue.ScaleDownDelay : default);
                        var autoscalingSettingsConcurrencyTarget = CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.ConcurrencyTarget) ? parseResult.GetValue(AutoscalingSettingsOptions.ConcurrencyTarget) : (__AutoscalingSettingsBase is { } __AutoscalingSettingsconcurrencyTargetBaseValue ? __AutoscalingSettingsconcurrencyTargetBaseValue.ConcurrencyTarget : default);
                        var autoscalingSettingsTargetUtilizationPercentage = CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.TargetUtilizationPercentage) ? parseResult.GetValue(AutoscalingSettingsOptions.TargetUtilizationPercentage) : (__AutoscalingSettingsBase is { } __AutoscalingSettingstargetUtilizationPercentageBaseValue ? __AutoscalingSettingstargetUtilizationPercentageBaseValue.TargetUtilizationPercentage : default);
                        var autoscalingSettingsTargetInFlightTokens = CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.TargetInFlightTokens) ? parseResult.GetValue(AutoscalingSettingsOptions.TargetInFlightTokens) : (__AutoscalingSettingsBase is { } __AutoscalingSettingstargetInFlightTokensBaseValue ? __AutoscalingSettingstargetInFlightTokensBaseValue.TargetInFlightTokens : default);
                        var autoscalingSettingsMaxScaleDownRate = CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.MaxScaleDownRate) ? parseResult.GetValue(AutoscalingSettingsOptions.MaxScaleDownRate) : (__AutoscalingSettingsBase is { } __AutoscalingSettingsmaxScaleDownRateBaseValue ? __AutoscalingSettingsmaxScaleDownRateBaseValue.MaxScaleDownRate : default);
                        var __AutoscalingSettingsSpecified = CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.MinReplica) || CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.MaxReplica) || CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.AutoscalingWindow) || CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.ScaleDownDelay) || CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.ConcurrencyTarget) || CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.TargetUtilizationPercentage) || CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.TargetInFlightTokens) || CliRuntime.WasSpecified(parseResult, AutoscalingSettingsOptions.MaxScaleDownRate);
                        var autoscalingSettings =
                            __AutoscalingSettingsSpecified || __AutoscalingSettingsBase is not null
                                ? new global::Baseten.UpdateAutoscalingSettingsV1
                                {
	                                MinReplica = autoscalingSettingsMinReplica,
                                MaxReplica = autoscalingSettingsMaxReplica,
                                AutoscalingWindow = autoscalingSettingsAutoscalingWindow,
                                ScaleDownDelay = autoscalingSettingsScaleDownDelay,
                                ConcurrencyTarget = autoscalingSettingsConcurrencyTarget,
                                TargetUtilizationPercentage = autoscalingSettingsTargetUtilizationPercentage,
                                TargetInFlightTokens = autoscalingSettingsTargetInFlightTokens,
                                MaxScaleDownRate = autoscalingSettingsMaxScaleDownRate,

                                }
                                : __AutoscalingSettingsBase;

                        var __PromotionSettingsBase = __requestBase is { } __PromotionSettingsBaseValue ? __PromotionSettingsBaseValue.PromotionSettings : default;                        var promotionSettingsRedeployOnPromotion = CliRuntime.WasSpecified(parseResult, PromotionSettingsOptions.RedeployOnPromotion) ? parseResult.GetValue(PromotionSettingsOptions.RedeployOnPromotion) : (__PromotionSettingsBase is { } __PromotionSettingsredeployOnPromotionBaseValue ? __PromotionSettingsredeployOnPromotionBaseValue.RedeployOnPromotion : default);
                        var promotionSettingsRollingDeploy = CliRuntime.WasSpecified(parseResult, PromotionSettingsOptions.RollingDeploy) ? parseResult.GetValue(PromotionSettingsOptions.RollingDeploy) : (__PromotionSettingsBase is { } __PromotionSettingsrollingDeployBaseValue ? __PromotionSettingsrollingDeployBaseValue.RollingDeploy : default);
                        var promotionSettingsRampUpWhilePromoting = CliRuntime.WasSpecified(parseResult, PromotionSettingsOptions.RampUpWhilePromoting) ? parseResult.GetValue(PromotionSettingsOptions.RampUpWhilePromoting) : (__PromotionSettingsBase is { } __PromotionSettingsrampUpWhilePromotingBaseValue ? __PromotionSettingsrampUpWhilePromotingBaseValue.RampUpWhilePromoting : default);
                        var promotionSettingsRampUpDurationSeconds = CliRuntime.WasSpecified(parseResult, PromotionSettingsOptions.RampUpDurationSeconds) ? parseResult.GetValue(PromotionSettingsOptions.RampUpDurationSeconds) : (__PromotionSettingsBase is { } __PromotionSettingsrampUpDurationSecondsBaseValue ? __PromotionSettingsrampUpDurationSecondsBaseValue.RampUpDurationSeconds : default);
                        var __PromotionSettingsSpecified = CliRuntime.WasSpecified(parseResult, PromotionSettingsOptions.RedeployOnPromotion) || CliRuntime.WasSpecified(parseResult, PromotionSettingsOptions.RollingDeploy) || CliRuntime.WasSpecified(parseResult, PromotionSettingsOptions.RampUpWhilePromoting) || CliRuntime.WasSpecified(parseResult, PromotionSettingsOptions.RampUpDurationSeconds);
                        var promotionSettings =
                            __PromotionSettingsSpecified || __PromotionSettingsBase is not null
                                ? new global::Baseten.UpdatePromotionSettingsV1
                                {
	                                RedeployOnPromotion = promotionSettingsRedeployOnPromotion,
                                RollingDeploy = promotionSettingsRollingDeploy,
                                RampUpWhilePromoting = promotionSettingsRampUpWhilePromoting,
                                RampUpDurationSeconds = promotionSettingsRampUpDurationSeconds,

                                }
                                : __PromotionSettingsBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditModelsByModelIdEnvironmentsByEnvNameAsync(
                                    modelId: modelId,
                                    envName: envName,
                                    autoscalingSettings: autoscalingSettings,
                                    promotionSettings: promotionSettings,
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