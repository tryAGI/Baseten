#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record PromotionEnvironmentSettingsUpdateV1OptionSet(
    Option<string?> Region,
                     Option<string?> InstanceTypeId)
{
    public static PromotionEnvironmentSettingsUpdateV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new PromotionEnvironmentSettingsUpdateV1OptionSet(
                        Region: new Option<string?>($"--{normalizedPrefix}region")
                {
                    Description = @"Region for the promoted deployment, from `GET /v1/teams/{team_id}/regions`. Use an empty string for Global. If omitted, the deployment keeps its region. Regional environments only accept Global deployments.",
                },
                InstanceTypeId: new Option<string?>($"--{normalizedPrefix}instance-type-id")
                {
                    Description = @"Instance type for the promoted deployment, from `GET /v1/instance_types`.",
                }
        );
    }
}