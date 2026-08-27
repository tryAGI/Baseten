
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoscalingScheduleSettingsV1
    {
        /// <summary>
        /// Minimum number of replicas
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_replica")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinReplica { get; set; }

        /// <summary>
        /// Maximum number of replicas
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_replica")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxReplica { get; set; }

        /// <summary>
        /// Timeframe of traffic considered for autoscaling decisions. Null inherits the environment value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_window")]
        public int? AutoscalingWindow { get; set; }

        /// <summary>
        /// Waiting period before scaling down any active replica. Null inherits the environment value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_down_delay")]
        public int? ScaleDownDelay { get; set; }

        /// <summary>
        /// Number of requests per replica before scaling up. Null inherits the environment value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency_target")]
        public int? ConcurrencyTarget { get; set; }

        /// <summary>
        /// Target utilization percentage for scaling up/down. Null inherits the environment value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_utilization_percentage")]
        public int? TargetUtilizationPercentage { get; set; }

        /// <summary>
        /// Target number of in-flight tokens for autoscaling decisions. Null inherits the environment value. Early access only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_in_flight_tokens")]
        public int? TargetInFlightTokens { get; set; }

        /// <summary>
        /// Maximum percentage of replicas that can be removed per autoscaling window. Null inherits the environment value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_scale_down_rate")]
        public int? MaxScaleDownRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoscalingScheduleSettingsV1" /> class.
        /// </summary>
        /// <param name="minReplica">
        /// Minimum number of replicas
        /// </param>
        /// <param name="maxReplica">
        /// Maximum number of replicas
        /// </param>
        /// <param name="autoscalingWindow">
        /// Timeframe of traffic considered for autoscaling decisions. Null inherits the environment value.
        /// </param>
        /// <param name="scaleDownDelay">
        /// Waiting period before scaling down any active replica. Null inherits the environment value.
        /// </param>
        /// <param name="concurrencyTarget">
        /// Number of requests per replica before scaling up. Null inherits the environment value.
        /// </param>
        /// <param name="targetUtilizationPercentage">
        /// Target utilization percentage for scaling up/down. Null inherits the environment value.
        /// </param>
        /// <param name="targetInFlightTokens">
        /// Target number of in-flight tokens for autoscaling decisions. Null inherits the environment value. Early access only.
        /// </param>
        /// <param name="maxScaleDownRate">
        /// Maximum percentage of replicas that can be removed per autoscaling window. Null inherits the environment value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoscalingScheduleSettingsV1(
            int minReplica,
            int maxReplica,
            int? autoscalingWindow,
            int? scaleDownDelay,
            int? concurrencyTarget,
            int? targetUtilizationPercentage,
            int? targetInFlightTokens,
            int? maxScaleDownRate)
        {
            this.MinReplica = minReplica;
            this.MaxReplica = maxReplica;
            this.AutoscalingWindow = autoscalingWindow;
            this.ScaleDownDelay = scaleDownDelay;
            this.ConcurrencyTarget = concurrencyTarget;
            this.TargetUtilizationPercentage = targetUtilizationPercentage;
            this.TargetInFlightTokens = targetInFlightTokens;
            this.MaxScaleDownRate = maxScaleDownRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoscalingScheduleSettingsV1" /> class.
        /// </summary>
        public AutoscalingScheduleSettingsV1()
        {
        }

    }
}