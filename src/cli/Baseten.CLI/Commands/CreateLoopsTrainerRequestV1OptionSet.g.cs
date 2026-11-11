#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record CreateLoopsTrainerRequestV1OptionSet(
    Option<string> SessionId,
                     Option<string> BaseModel,
                     Option<string?> NameOption,
                     Option<int?> MaxSeqLen,
                     Option<int?> LoraRank,
                     Option<int?> Seed,
                     Option<int?> ScaleDownDelaySeconds,
                     Option<global::Baseten.AvailabilityModelV1?> AvailabilityModel,
                     Option<int?> Replicas,
                     Option<string?> Path,
                     Option<string?> ReuseFromRunId,
                     Option<string?> ReuseFromSessionId,
                     Option<string?> BaseCheckpoint,
                     Option<global::Baseten.LoopsPlacementScopeV1?> Scope)
{
    public static CreateLoopsTrainerRequestV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new CreateLoopsTrainerRequestV1OptionSet(
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
                    Description = @"Seconds of inactivity before the run scales to zero. Must be between 1 and 3600 (1 hour). Defaults to 900 (15 minutes).",
                },
                AvailabilityModel: new Option<global::Baseten.AvailabilityModelV1?>($"--{normalizedPrefix}availability-model")
                {
                    Description = @"Capacity the trainer runs on. 'standard' is not preempted. 'spot' runs below inference and reaches idle reserved capacity, but the run is stopped if its GPUs are reclaimed and cannot be resumed.",
                },
                Replicas: new Option<int?>($"--{normalizedPrefix}replicas")
                {
                    Description = @"Number of data-parallel trainer replicas. Each replica is one full copy of the model's preset node group, so the trainer deployment runs (preset node_count * replicas) nodes (e.g. replicas=4 on a 4-node preset → 16 nodes, 4 DP workers). Must be a positive integer. Defaults to 1.",
                },
                Path: new Option<string?>($"--{normalizedPrefix}path")
                {
                    Description = @"Optional bt:// URI of an existing checkpoint to load weights from on startup. Form: bt://loops:<run_id>/weights/<checkpoint_name>.",
                },
                ReuseFromRunId: new Option<string?>($"--{normalizedPrefix}reuse-from-run-id")
                {
                    Description = @"Optional ID of a prior Loops run whose trainer and/or sampler should be reused for this run instead of provisioning fresh. The prior run must use the same base model and belong to the same team.",
                },
                ReuseFromSessionId: new Option<string?>($"--{normalizedPrefix}reuse-from-session-id")
                {
                    Description = @"Optional ID of a prior Loops session whose trainer and/or sampler should be reused for this run. Deprecated in favor of reuse_from_run_id.",
                },
                BaseCheckpoint: new Option<string?>($"--{normalizedPrefix}base-checkpoint")
                {
                    Description = @"Optional checkpoint to start training from instead of the base model's weights: a Hugging Face repo (hf://<org>/<repo>[@<revision>]), an object store path (s3://, gs://, r2://, cw://, or azure://), or a full Baseten Training checkpoint in the run's team (bt://<project>@<job_id>/<checkpoint>, with the checkpoint named). It must be a complete, merged checkpoint in safetensors format with the same architecture as base_model, which still selects the hardware and training configuration. It must include tokenizer files: the run's sampler loads the tokenizer and chat template from the checkpoint. A Hugging Face revision is pinned to a commit when the run is created, and its files are checked then. Any other source is read again by each sampler and resumed run, so do not change it while the run is in use. Checkpoints from a run on a source outside Hugging Face cannot be deployed yet. Cannot be combined with path, reuse_from_run_id, or reuse_from_session_id.",
                },
                Scope: new Option<global::Baseten.LoopsPlacementScopeV1?>($"--{normalizedPrefix}scope")
                {
                    Description = @"Choose where this runs. 'default' lets Baseten choose. 'serverless' runs on Baseten's shared capacity, and fails instead of falling back when shared capacity can't serve the request. 'dedicated' gives it its own deployment, which you size and pay for.",
                }
        );
    }
}