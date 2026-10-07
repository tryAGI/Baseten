#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record SandboxLifecycleV1OptionSet(
    Option<string?> TerminatedRetention)
{
    public static SandboxLifecycleV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new SandboxLifecycleV1OptionSet(
                        TerminatedRetention: new Option<string?>($"--{normalizedPrefix}terminated-retention")
                {
                    Description = @"Duration to keep the sandbox record after termination for log access (e.g., '1h', '24h', '7d'). Defaults to 5m. Subject to maximum quota limits.",
                }
        );
    }
}