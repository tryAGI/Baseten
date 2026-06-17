#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record UpsertTrainingProjectV1OptionSet(
    Option<string> NameOption)
{
    public static UpsertTrainingProjectV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new UpsertTrainingProjectV1OptionSet(
                        NameOption: new Option<string>($"--{normalizedPrefix}name")
                {
                    Description = @"Name of the training project.",
                    Required = true,
                }
        );
    }
}