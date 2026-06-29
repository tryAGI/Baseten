#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record CreateLLMModelRequestV1OptionSet(
    Option<string?> LlmVersion,
                     Option<string> NameOption)
{
    public static CreateLLMModelRequestV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateLLMModelRequestV1OptionSet(
                        LlmVersion: new Option<string?>($"--{normalizedPrefix}llm-version")
                {
                    Description = @"Version of the helm chart to use.",
                },
                NameOption: new Option<string>($"--{normalizedPrefix}name")
                {
                    Description = @"Name of the model",
                    Required = true,
                }
        );
    }
}