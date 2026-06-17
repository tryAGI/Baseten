#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record UpdatePromotionSettingsV1OptionSet(
    Option<bool?> RedeployOnPromotion,
                     Option<bool?> RollingDeploy,
                     Option<bool?> RampUpWhilePromoting,
                     Option<int?> RampUpDurationSeconds)
{
    public static UpdatePromotionSettingsV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new UpdatePromotionSettingsV1OptionSet(
                        RedeployOnPromotion: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}redeploy-on-promotion", description: @"Whether to deploy on all promotions. Enabling this flag allows model code to safely handle environment-specific logic. When a deployment is promoted, a new deployment will be created with a copy of the image."),
                RollingDeploy: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}rolling-deploy", description: @"Whether the environment should rely on rolling deploy orchestration."),
                RampUpWhilePromoting: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}ramp-up-while-promoting", description: @"Whether to ramp up traffic while promoting"),
                RampUpDurationSeconds: new Option<int?>($"--{normalizedPrefix}ramp-up-duration-seconds")
                {
                    Description = @"Duration of the ramp up in seconds",
                }
        );
    }
}