#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record UpdateEnvironmentGroupManageAccessV1OptionSet(
    Option<bool> IsRestricted,
                     Option<global::System.Collections.Generic.IList<string>?> UserIds)
{
    public static UpdateEnvironmentGroupManageAccessV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new UpdateEnvironmentGroupManageAccessV1OptionSet(
                        IsRestricted: new Option<bool>($"--{normalizedPrefix}is-restricted")
                {
                    Description = @"Whether to restrict this environment to a specific set of users.",
                    Required = true,
                },
                UserIds: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}user-ids")
                {
                    Description = @"IDs of users granted manage access while restricted. Only meaningful when is_restricted is true.",
                }
        );
    }
}