
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Autoscaling settings for a deployment.
    /// </summary>
    public sealed partial class AutoscalingSettingsV1
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
        /// Timeframe of traffic considered for autoscaling decisions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_window")]
        public int? AutoscalingWindow { get; set; }

        /// <summary>
        /// Waiting period before scaling down any active replica
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_down_delay")]
        public int? ScaleDownDelay { get; set; }

        /// <summary>
        /// Number of requests per replica before scaling up
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency_target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConcurrencyTarget { get; set; }

        /// <summary>
        /// Target utilization percentage for scaling up/down.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_utilization_percentage")]
        public int? TargetUtilizationPercentage { get; set; }

        /// <summary>
        /// Target number of in-flight tokens for autoscaling decisions. Early access only.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_in_flight_tokens")]
        public int? TargetInFlightTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoscalingSettingsV1" /> class.
        /// </summary>
        /// <param name="minReplica">
        /// Minimum number of replicas
        /// </param>
        /// <param name="maxReplica">
        /// Maximum number of replicas
        /// </param>
        /// <param name="concurrencyTarget">
        /// Number of requests per replica before scaling up
        /// </param>
        /// <param name="autoscalingWindow">
        /// Timeframe of traffic considered for autoscaling decisions
        /// </param>
        /// <param name="scaleDownDelay">
        /// Waiting period before scaling down any active replica
        /// </param>
        /// <param name="targetUtilizationPercentage">
        /// Target utilization percentage for scaling up/down.
        /// </param>
        /// <param name="targetInFlightTokens">
        /// Target number of in-flight tokens for autoscaling decisions. Early access only.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoscalingSettingsV1(
            int minReplica,
            int maxReplica,
            int concurrencyTarget,
            int? autoscalingWindow,
            int? scaleDownDelay,
            int? targetUtilizationPercentage,
            int? targetInFlightTokens)
        {
            this.MinReplica = minReplica;
            this.MaxReplica = maxReplica;
            this.AutoscalingWindow = autoscalingWindow;
            this.ScaleDownDelay = scaleDownDelay;
            this.ConcurrencyTarget = concurrencyTarget;
            this.TargetUtilizationPercentage = targetUtilizationPercentage;
            this.TargetInFlightTokens = targetInFlightTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoscalingSettingsV1" /> class.
        /// </summary>
        public AutoscalingSettingsV1()
        {
        }
    }
}