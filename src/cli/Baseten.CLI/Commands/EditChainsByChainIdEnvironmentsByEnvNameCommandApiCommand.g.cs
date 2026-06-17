#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal static partial class EditChainsByChainIdEnvironmentsByEnvNameCommandApiCommand
{
    private static Argument<string> ChainId { get; } = new(
        name: @"chain-id")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };

    private static Argument<string> EnvName { get; } = new(
        name: @"env-name")
    {
        Description = @"This is a missing parameter that was added automatically. Please check the OpenAPI spec.",
    };
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

                    private static string FormatResponse(ParseResult parseResult, global::Baseten.UpdateChainEnvironmentResponseV1 value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Baseten.UpdateChainEnvironmentResponseV1 value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"edit-chains-by-chain-id-environments-by-env-name", @"Update a chain environment's settings
Update a chain environment's settings and returns the chain environment.");
                        command.Arguments.Add(ChainId);
                        command.Arguments.Add(EnvName);                        command.Options.Add(PromotionSettingsOptions.RedeployOnPromotion);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Baseten.UpdateChainEnvironmentRequestV1>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Baseten.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var chainId = parseResult.GetRequiredValue(ChainId);
                        var envName = parseResult.GetRequiredValue(EnvName);

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


                                var response = await client.EditChainsByChainIdEnvironmentsByEnvNameAsync(
                                    chainId: chainId,
                                    envName: envName,
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