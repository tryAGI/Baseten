#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record SignSSHCertificateRequestV1OptionSet(
    Option<string> PublicKey,
                     Option<string?> ReplicaId)
{
    public static SignSSHCertificateRequestV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new SignSSHCertificateRequestV1OptionSet(
                        PublicKey: new Option<string>($"--{normalizedPrefix}public-key")
                {
                    Description = @"The user's SSH public key (e.g., 'ssh-ed25519 AAAA... user@host').",
                    Required = true,
                },
                ReplicaId: new Option<string?>($"--{normalizedPrefix}replica-id")
                {
                    Description = @"The replica to connect to. Required for training jobs (e.g. '0'). Optional for inference (server picks a running replica if omitted).",
                }
        );
    }
}