#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record UpsertSecretRequestV1OptionSet(
    Option<string> NameOption,
                     Option<string> Value)
{
    public static UpsertSecretRequestV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new UpsertSecretRequestV1OptionSet(
                        NameOption: new Option<string>($"--{normalizedPrefix}name")
                {
                    Description = @"Name of the new or existing secret",
                    Required = true,
                },
                Value: new Option<string>($"--{normalizedPrefix}value")
                {
                    Description = @"Value of the secret",
                    Required = true,
                }
        );
    }
}