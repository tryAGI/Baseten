#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record CreateLoopsSamplerRequestV1OptionSet(
    Option<string> SessionId,
                     Option<string?> BaseModel,
                     Option<string?> RunId,
                     Option<int?> MaxSeqLength,
                     Option<string?> ModelPath,
                     Option<string?> ReuseFromSessionId)
{
    public static CreateLoopsSamplerRequestV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateLoopsSamplerRequestV1OptionSet(
                        SessionId: new Option<string>($"--{normalizedPrefix}session-id")
                {
                    Description = @"ID of the Loops session this sampler belongs to.",
                    Required = true,
                },
                BaseModel: new Option<string?>($"--{normalizedPrefix}base-model")
                {
                    Description = @"Base model ID for a standalone sampler (for example, a baseline).",
                },
                RunId: new Option<string?>($"--{normalizedPrefix}run-id")
                {
                    Description = @"ID of an existing run to attach this sampler to. When set, the sampler is paired to the run and weight-syncs from its trainer, and base_model is inherited from the run. Omit to create a standalone sampler.",
                },
                MaxSeqLength: new Option<int?>($"--{normalizedPrefix}max-seq-length")
                {
                    Description = @"Maximum prompt length (in tokens) the sampler must handle. Set this to the longest prompt you plan to send.",
                },
                ModelPath: new Option<string?>($"--{normalizedPrefix}model-path")
                {
                    Description = @"bt:// URI of an existing sampler checkpoint to serve. Form: bt://loops:<run_id>/sampler_weights/<checkpoint_name>.",
                },
                ReuseFromSessionId: new Option<string?>($"--{normalizedPrefix}reuse-from-session-id")
                {
                    Description = @"Optional ID of a prior Loops session to reuse a trainer and/or sampler from. Deprecated.",
                }
        );
    }
}