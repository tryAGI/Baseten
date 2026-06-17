#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditModelsByModelIdDeploymentsProductionAutoscalingSettingsCommandApiCommand
{
    private static Argument<string> ModelId { get; } = new(
        name: @"model-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };
    private static readonly UpdateAutoscalingSettingsV1OptionSet UpdateAutoscalingSettingsV1OptionSetOptions = UpdateAutoscalingSettingsV1OptionSet.Create();
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
        var command = new Command(@"edit-models-by-model-id-deployments-production-autoscaling-settings", @"Updates a production deployment's autoscaling settings
Updates a production deployment's autoscaling settings and returns the update status.");
                        command.Arguments.Add(ModelId);                        command.Options.Add(UpdateAutoscalingSettingsV1OptionSetOptions.MinReplica);
                        command.Options.Add(UpdateAutoscalingSettingsV1OptionSetOptions.MaxReplica);
                        command.Options.Add(UpdateAutoscalingSettingsV1OptionSetOptions.AutoscalingWindow);
                        command.Options.Add(UpdateAutoscalingSettingsV1OptionSetOptions.ScaleDownDelay);
                        command.Options.Add(UpdateAutoscalingSettingsV1OptionSetOptions.ConcurrencyTarget);
                        command.Options.Add(UpdateAutoscalingSettingsV1OptionSetOptions.TargetUtilizationPercentage);
                        command.Options.Add(UpdateAutoscalingSettingsV1OptionSetOptions.TargetInFlightTokens);
                        command.Options.Add(UpdateAutoscalingSettingsV1OptionSetOptions.MaxScaleDownRate);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.UpdateAutoscalingSettingsV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var modelId = parseResult.GetRequiredValue(ModelId);                        var minReplica = CliRuntime.WasSpecified(parseResult, UpdateAutoscalingSettingsV1OptionSetOptions.MinReplica) ? parseResult.GetValue(UpdateAutoscalingSettingsV1OptionSetOptions.MinReplica) : (__requestBase is { } __MinReplicaBaseValue ? __MinReplicaBaseValue.MinReplica : default);
                        var maxReplica = CliRuntime.WasSpecified(parseResult, UpdateAutoscalingSettingsV1OptionSetOptions.MaxReplica) ? parseResult.GetValue(UpdateAutoscalingSettingsV1OptionSetOptions.MaxReplica) : (__requestBase is { } __MaxReplicaBaseValue ? __MaxReplicaBaseValue.MaxReplica : default);
                        var autoscalingWindow = CliRuntime.WasSpecified(parseResult, UpdateAutoscalingSettingsV1OptionSetOptions.AutoscalingWindow) ? parseResult.GetValue(UpdateAutoscalingSettingsV1OptionSetOptions.AutoscalingWindow) : (__requestBase is { } __AutoscalingWindowBaseValue ? __AutoscalingWindowBaseValue.AutoscalingWindow : default);
                        var scaleDownDelay = CliRuntime.WasSpecified(parseResult, UpdateAutoscalingSettingsV1OptionSetOptions.ScaleDownDelay) ? parseResult.GetValue(UpdateAutoscalingSettingsV1OptionSetOptions.ScaleDownDelay) : (__requestBase is { } __ScaleDownDelayBaseValue ? __ScaleDownDelayBaseValue.ScaleDownDelay : default);
                        var concurrencyTarget = CliRuntime.WasSpecified(parseResult, UpdateAutoscalingSettingsV1OptionSetOptions.ConcurrencyTarget) ? parseResult.GetValue(UpdateAutoscalingSettingsV1OptionSetOptions.ConcurrencyTarget) : (__requestBase is { } __ConcurrencyTargetBaseValue ? __ConcurrencyTargetBaseValue.ConcurrencyTarget : default);
                        var targetUtilizationPercentage = CliRuntime.WasSpecified(parseResult, UpdateAutoscalingSettingsV1OptionSetOptions.TargetUtilizationPercentage) ? parseResult.GetValue(UpdateAutoscalingSettingsV1OptionSetOptions.TargetUtilizationPercentage) : (__requestBase is { } __TargetUtilizationPercentageBaseValue ? __TargetUtilizationPercentageBaseValue.TargetUtilizationPercentage : default);
                        var targetInFlightTokens = CliRuntime.WasSpecified(parseResult, UpdateAutoscalingSettingsV1OptionSetOptions.TargetInFlightTokens) ? parseResult.GetValue(UpdateAutoscalingSettingsV1OptionSetOptions.TargetInFlightTokens) : (__requestBase is { } __TargetInFlightTokensBaseValue ? __TargetInFlightTokensBaseValue.TargetInFlightTokens : default);
                        var maxScaleDownRate = CliRuntime.WasSpecified(parseResult, UpdateAutoscalingSettingsV1OptionSetOptions.MaxScaleDownRate) ? parseResult.GetValue(UpdateAutoscalingSettingsV1OptionSetOptions.MaxScaleDownRate) : (__requestBase is { } __MaxScaleDownRateBaseValue ? __MaxScaleDownRateBaseValue.MaxScaleDownRate : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.EditModelsByModelIdDeploymentsProductionAutoscalingSettingsAsync(
                                    modelId: modelId,
                                    minReplica: minReplica,
                                    maxReplica: maxReplica,
                                    autoscalingWindow: autoscalingWindow,
                                    scaleDownDelay: scaleDownDelay,
                                    concurrencyTarget: concurrencyTarget,
                                    targetUtilizationPercentage: targetUtilizationPercentage,
                                    targetInFlightTokens: targetInFlightTokens,
                                    maxScaleDownRate: maxScaleDownRate,
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