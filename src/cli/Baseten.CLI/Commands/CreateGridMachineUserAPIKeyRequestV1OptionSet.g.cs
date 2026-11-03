#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record CreateGridMachineUserAPIKeyRequestV1OptionSet(
    Option<string?> NameOption)
{
    public static CreateGridMachineUserAPIKeyRequestV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateGridMachineUserAPIKeyRequestV1OptionSet(
                        NameOption: new Option<string?>($"--{normalizedPrefix}name")
                {
                    Description = @"Name of the API key: lowercase letters, numbers, and hyphens, at most 255 characters, and unique among the machine user's active keys. Defaults to a name derived from the machine user's.",
                }
        );
    }
}