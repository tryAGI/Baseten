#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record ServiceAccountPresetPermissionsRequestV1OptionSet(
    Option<global::Baseten.ServiceAccountPresetTypeV1> Type)
{
    public static ServiceAccountPresetPermissionsRequestV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ServiceAccountPresetPermissionsRequestV1OptionSet(
                        Type: new Option<global::Baseten.ServiceAccountPresetTypeV1>($"--{normalizedPrefix}type")
                {
                    Description = @"What the service account may do. WORKSPACE_MANAGE_API_KEYS is for organization-level accounts only; every other type needs a team.",
                    Required = true,
                }
        );
    }
}