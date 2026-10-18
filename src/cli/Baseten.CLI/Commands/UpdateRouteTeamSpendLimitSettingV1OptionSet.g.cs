#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record UpdateRouteTeamSpendLimitSettingV1OptionSet(
    Option<string?> PerMemberMonthlyLimitUsd,
                     Option<string?> TeamWideMonthlyLimitUsd)
{
    public static UpdateRouteTeamSpendLimitSettingV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new UpdateRouteTeamSpendLimitSettingV1OptionSet(
                        PerMemberMonthlyLimitUsd: new Option<string?>($"--{normalizedPrefix}per-member-monthly-limit-usd")
                {
                    Description = @"Spend limit in USD for each UTC calendar month that applies to each member's Grid spend in this team, unless the member has a limit of their own. Send null to remove it; omit to leave it unchanged.",
                },
                TeamWideMonthlyLimitUsd: new Option<string?>($"--{normalizedPrefix}team-wide-monthly-limit-usd")
                {
                    Description = @"Spend limit in USD for each UTC calendar month on the Grid spend of all members in this team together. Send null to remove it; omit to leave it unchanged.",
                }
        );
    }
}