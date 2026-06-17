#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record CreateAPIKeyRequestV1OptionSet(
    Option<string?> NameOption,
                     Option<global::Baseten.APIKeyCategory> Type)
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
                }
        );
    }
}