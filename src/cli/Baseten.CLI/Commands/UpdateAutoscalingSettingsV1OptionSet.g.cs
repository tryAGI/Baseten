#nullable enable

using System.CommandLine;

namespace Baseten.CLI.Commands;

internal sealed record UpdateAutoscalingSettingsV1OptionSet(
    Option<int?> MinReplica,
                     Option<int?> MaxReplica,
                     Option<int?> AutoscalingWindow,
                     Option<int?> ScaleDownDelay,
                     Option<int?> ConcurrencyTarget,
                     Option<int?> TargetUtilizationPercentage,
                     Option<int?> TargetInFlightTokens,
                     Option<int?> MaxScaleDownRate)
{
    public static UpdateAutoscalingSettingsV1OptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new UpdateAutoscalingSettingsV1OptionSet(
                        MinReplica: new Option<int?>($"--{normalizedPrefix}min-replica")
                {
                    Description = @"Minimum number of replicas",
                },
                MaxReplica: new Option<int?>($"--{normalizedPrefix}max-replica")
                {
                    Description = @"Maximum number of replicas",
                },
                AutoscalingWindow: new Option<int?>($"--{normalizedPrefix}autoscaling-window")
                {
                    Description = @"Timeframe of traffic considered for autoscaling decisions",
                },
                ScaleDownDelay: new Option<int?>($"--{normalizedPrefix}scale-down-delay")
                {
                    Description = @"Waiting period before scaling down any active replica",
                },
                ConcurrencyTarget: new Option<int?>($"--{normalizedPrefix}concurrency-target")
                {
                    Description = @"Number of requests per replica before scaling up",
                },
                TargetUtilizationPercentage: new Option<int?>($"--{normalizedPrefix}target-utilization-percentage")
                {
                    Description = @"Target utilization percentage for scaling up/down.",
                },
                TargetInFlightTokens: new Option<int?>($"--{normalizedPrefix}target-in-flight-tokens")
                {
                    Description = @"Target number of in-flight tokens for autoscaling decisions. Early access only.",
                },
                MaxScaleDownRate: new Option<int?>($"--{normalizedPrefix}max-scale-down-rate")
                {
                    Description = @"Maximum percentage of replicas that can be removed per autoscaling window (1–50). E.g. 20 means at most 20% of replicas are removed per window.",
                }
        );
    }
}