#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record CreateModelWeightSnapshotRequestV1OptionSet(
    Option<string> Model,
                     Option<string> SnapshotUri)
{
    public static CreateModelWeightSnapshotRequestV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateModelWeightSnapshotRequestV1OptionSet(
                        Model: new Option<string>($"--{normalizedPrefix}model")
                {
                    Description = @"Unique identifier of the model",
                    Required = true,
                },
                SnapshotUri: new Option<string>($"--{normalizedPrefix}snapshot-uri")
                {
                    Description = @"Path to the model weight snapshot",
                    Required = true,
                }
        );
    }
}