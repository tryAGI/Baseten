#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record CreateAPIKeyRequestV1OptionSet(
    Option<string?> NameOption,
                     Option<global::Baseten.APIKeyCategory> Type,
                     Option<string?> TeamId)
{
    public static CreateAPIKeyRequestV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateAPIKeyRequestV1OptionSet(
                        NameOption: new Option<string?>($"--{normalizedPrefix}name")
                {
                    Description = @"Optional name for the API key",
                },
                Type: new Option<global::Baseten.APIKeyCategory>($"--{normalizedPrefix}type")
                {
                    Description = @"Type of the API key.",
                    Required = true,
                },
                TeamId: new Option<string?>($"--{normalizedPrefix}team-id")
                {
                    Description = @"Team ID for a team-scoped key. When omitted, uses the team in the URL if present, otherwise your organization's default team. Must match the URL team when both are provided. Not supported for PERSONAL or WORKSPACE_MANAGE_API_KEYS keys.",
                }
        );
    }
}