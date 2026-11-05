#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record UpsertTrainingProjectV1OptionSet(
    Option<string> NameOption,
                     Option<string?> ProjectAccelerator)
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
                },
                ProjectAccelerator: new Option<string?>($"--{normalizedPrefix}project-accelerator")
                {
                    Description = @"Optional default GPU type for cache-enabled CPU job placement, such as H100. GPU jobs use their requested GPU type; uncached CPU jobs use normal CPU routing. Omitting this field preserves the stored default; providing a value updates it. Existing cache-affinity requirements still apply.",
                }
        );
    }
}