#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record UpdateModelPromotionSettingsV1OptionSet(
    Option<bool?> RedeployOnPromotion,
                     Option<bool?> RollingDeploy,
                     Option<bool?> RampUpWhilePromoting,
                     Option<int?> RampUpDurationSeconds)
{
    public static UpdateModelPromotionSettingsV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new UpdateModelPromotionSettingsV1OptionSet(
                        RedeployOnPromotion: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}redeploy-on-promotion", description: @"Whether to deploy on all promotions. Enabling this flag allows model code to safely handle environment-specific logic. When a deployment is promoted, a new deployment will be created with a copy of the image."),
                RollingDeploy: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}rolling-deploy", description: @"Whether the environment should rely on rolling deploy orchestration."),
                RampUpWhilePromoting: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}ramp-up-while-promoting", description: @"Deprecated: models don't support canary promotions, and `true` is rejected. Use `rolling_deploy`."),
                RampUpDurationSeconds: new Option<int?>($"--{normalizedPrefix}ramp-up-duration-seconds")
                {
                    Description = @"Deprecated: models don't support canary promotions.",
                }
        );
    }
}