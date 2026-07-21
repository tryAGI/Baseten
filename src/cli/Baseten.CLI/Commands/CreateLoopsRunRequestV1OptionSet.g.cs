#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record CreateLoopsRunRequestV1OptionSet(
    Option<string> SessionId,
                     Option<string> BaseModel,
                     Option<string?> NameOption,
                     Option<int?> MaxSeqLen,
                     Option<int?> LoraRank,
                     Option<int?> Seed,
                     Option<int?> ScaleDownDelaySeconds,
                     Option<int?> Replicas,
                     Option<string?> Path,
                     Option<string?> ReuseFromSessionId)
{
    public static CreateLoopsRunRequestV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateLoopsRunRequestV1OptionSet(
                        SessionId: new Option<string>($"--{normalizedPrefix}session-id")
                {
                    Description = @"ID of the Loops session this run belongs to.",
                    Required = true,
                },
                BaseModel: new Option<string>($"--{normalizedPrefix}base-model")
                {
                    Description = @"Base model ID (e.g. 'Qwen/Qwen3-8B').",
                    Required = true,
                },
                NameOption: new Option<string?>($"--{normalizedPrefix}name")
                {
                    Description = @"Optional display name for the run. Defaults to the base model name when omitted.",
                },
                MaxSeqLen: new Option<int?>($"--{normalizedPrefix}max-seq-len")
                {
                    Description = @"Maximum prompt length (in tokens) the run must handle. Set this to the longest training example you plan to send. Defaults to the maximum supported by the model configuration.",
                },
                LoraRank: new Option<int?>($"--{normalizedPrefix}lora-rank")
                {
                    Description = @"LoRA rank.",
                },
                Seed: new Option<int?>($"--{normalizedPrefix}seed")
                {
                    Description = @"Random seed for reproducibility.",
                },
                ScaleDownDelaySeconds: new Option<int?>($"--{normalizedPrefix}scale-down-delay-seconds")
                {
                    Description = @"Seconds of inactivity before the run scales to zero. Must be between 1 and 3600 (1 hour). Defaults to 3600.",
                },
                Replicas: new Option<int?>($"--{normalizedPrefix}replicas")
                {
                    Description = @"Number of data-parallel trainer replicas. Each replica is one full copy of the model's preset node group, so the trainer deployment runs (preset node_count * replicas) nodes (e.g. replicas=4 on a 4-node preset → 16 nodes, 4 DP workers). Must be a positive integer. Defaults to 1.",
                },
                Path: new Option<string?>($"--{normalizedPrefix}path")
                {
                    Description = @"Optional bt:// URI of an existing checkpoint to load weights from on startup. Form: bt://loops:<run_id>/weights/<checkpoint_name>.",
                },
                ReuseFromSessionId: new Option<string?>($"--{normalizedPrefix}reuse-from-session-id")
                {
                    Description = @"Optional Loops session ID whose trainer deployment should be reused for this run, sharing the infrastructure across sessions instead of provisioning fresh. The named session must belong to the same team. Reuse is best-effort: if the prior deployment is stopped, failed, its sampler is unhealthy, or this run requests replicas != 1, a new deployment is provisioned instead.",
                }
        );
    }
}