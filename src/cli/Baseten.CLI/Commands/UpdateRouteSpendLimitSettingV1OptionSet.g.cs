#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record UpdateRouteSpendLimitSettingV1OptionSet(
    Option<string?> UserMonthlyLimitUsd,
                     Option<string?> MonthOverrideUsd)
{
    public static UpdateRouteSpendLimitSettingV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new UpdateRouteSpendLimitSettingV1OptionSet(
                        UserMonthlyLimitUsd: new Option<string?>($"--{normalizedPrefix}user-monthly-limit-usd")
                {
                    Description = @"Standing spend limit in USD for each UTC calendar month. Send null to remove the limit; omit to leave it unchanged.",
                },
                MonthOverrideUsd: new Option<string?>($"--{normalizedPrefix}month-override-usd")
                {
                    Description = @"Spend limit in USD for the current UTC calendar month, which supersedes the standing limit. Send null to remove it; omit to leave it unchanged.",
                }
        );
    }
}