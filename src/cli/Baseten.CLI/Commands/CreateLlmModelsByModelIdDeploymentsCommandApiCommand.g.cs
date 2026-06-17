#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class CreateLlmModelsByModelIdDeploymentsCommandApiCommand
{
    private static Argument<string> ModelId { get; } = new(
        name: @"model-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Option<object> Resources { get; } = new(
        name: @"--resources")
    {
        Description = @"Resources allocated to the model",
        Required = true,
    };

    private static Option<string?> LlmVersion { get; } = new(
        name: @"--llm-version")
    {
        Description = @"Version of the helm chart to use",
    };

    private static Option<object?> LlmConfig { get; } = new(
        name: @"--llm-config")
    {
        Description = @"Configuration specific to the LLM model",
    };

    private static Option<object?> EnvironmentVariables { get; } = new(
        name: @"--environment-variables")
    {
        Description = @"Environment variables for the model",
    };

    private static Option<object?> ModelMetadata { get; } = new(
        name: @"--model-metadata")
    {
        Description = @"Model metadata persisted into model_config",
    };

    private static Option<object?> AdditionalAutoscalingConfig { get; } = new(
        name: @"--additional-autoscaling-config")
    {
        Description = @"Additional autoscaling configuration (e.g. target in-flight tokens)",
    };

    private static Option<object?> Metadata { get; } = new(
        name: @"--metadata")
    {
        Description = @"User-defined metadata for the deployment",
    };

    private static Option<global::System.Collections.Generic.IList<object>?> Weights { get; } = new(
        name: @"--weights")
    {
        Description = @"Weight configurations for BDN model weight distribution",
    };
    private static readonly UpdateAutoscalingSettingsV1OptionSet AutoscalingSettingsOptions = UpdateAutoscalingSettingsV1OptionSet.Create(@"autoscaling-settings");
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.LLMModelHandleV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.LLMModelHandleV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-llm-models-by-model-id-deployments", @"Creates a new BIS LLM deployment version");
                        command.Arguments.Add(ModelId);
                        command.Options.Add(Resources);
                        command.Options.Add(LlmVersion);
                        command.Options.Add(LlmConfig);
                        command.Options.Add(EnvironmentVariables);
                        command.Options.Add(ModelMetadata);
                        command.Options.Add(AdditionalAutoscalingConfig);
                        command.Options.Add(Metadata);
                        command.Options.Add(Weights);                        command.Options.Add(AutoscalingSettingsOptions.MinReplica);
                        command.Options.Add(AutoscalingSettingsOptions.MaxReplica);
                        command.Options.Add(AutoscalingSettingsOptions.AutoscalingWindow);
                        command.Options.Add(AutoscalingSettingsOptions.ScaleDownDelay);
                        command.Options.Add(AutoscalingSettingsOptions.ConcurrencyTarget);
                        command.Options.Add(AutoscalingSettingsOptions.TargetUtilizationPercentage);
                        command.Options.Add(AutoscalingSettingsOptions.TargetInFlightTokens);
                        command.Options.Add(AutoscalingSettingsOptions.MaxScaleDownRate);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.CreateLLMModelVersionRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var modelId = parseResult.GetRequiredValue(ModelId);
                        var resources = parseResult.GetRequiredValue(Resources);
                        var llmVersion = CliRuntime.WasSpecified(parseResult, LlmVersion) ? parseResult.GetValue(LlmVersion) : (__requestBase is { } __LlmVersionBaseValue ? __LlmVersionBaseValue.LlmVersion : default);
                        var llmConfig = CliRuntime.WasSpecified(parseResult, LlmConfig) ? parseResult.GetValue(LlmConfig) : (__requestBase is { } __LlmConfigBaseValue ? __LlmConfigBaseValue.LlmConfig : default);
                        var environmentVariables = CliRuntime.WasSpecified(parseResult, EnvironmentVariables) ? parseResult.GetValue(EnvironmentVariables) : (__requestBase is { } __EnvironmentVariablesBaseValue ? __EnvironmentVariablesBaseValue.EnvironmentVariables : default);
                        var modelMetadata = CliRuntime.WasSpecified(parseResult, ModelMetadata) ? parseResult.GetValue(ModelMetadata) : (__requestBase is { } __ModelMetadataBaseValue ? __ModelMetadataBaseValue.ModelMetadata : default);
                        var additionalAutoscalingConfig = CliRuntime.WasSpecified(parseResult, AdditionalAutoscalingConfig) ? parseResult.GetValue(AdditionalAutoscalingConfig) : (__requestBase is { } __AdditionalAutoscalingConfigBaseValue ? __AdditionalAutoscalingConfigBaseValue.AdditionalAutoscalingConfig : default);
                        var metadata = CliRuntime.WasSpecified(parseResult, Metadata) ? parseResult.GetValue(Metadata) : (__requestBase is { } __MetadataBaseValue ? __MetadataBaseValue.Metadata : default);
                        var weights = CliRuntime.WasSpecified(parseResult, Weights) ? parseResult.GetValue(Weights) : (__requestBase is { } __WeightsBaseValue ? __WeightsBaseValue.Weights : default);

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
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateLlmModelsByModelIdDeploymentsAsync(
                                    modelId: modelId,
                                    resources: resources,
                                    llmVersion: llmVersion,
                                    llmConfig: llmConfig,
                                    environmentVariables: environmentVariables,
                                    modelMetadata: modelMetadata,
                                    additionalAutoscalingConfig: additionalAutoscalingConfig,
                                    metadata: metadata,
                                    weights: weights,
                                    autoscalingSettings: autoscalingSettings,
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