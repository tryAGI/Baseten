
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to update autoscaling settings for a deployment. All fields are optional, and we only update ones passed in.
    /// </summary>
    public sealed partial class UpdateAutoscalingSettingsV1
    {
        /// <summary>
        /// Minimum number of replicas<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_replica")]
        public int? MinReplica { get; set; }

        /// <summary>
        /// Maximum number of replicas<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_replica")]
        public int? MaxReplica { get; set; }

        /// <summary>
        /// Timeframe of traffic considered for autoscaling decisions<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_window")]
        public int? AutoscalingWindow { get; set; }

        /// <summary>
        /// Waiting period before scaling down any active replica<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_down_delay")]
        public int? ScaleDownDelay { get; set; }

        /// <summary>
        /// Number of requests per replica before scaling up<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency_target")]
        public int? ConcurrencyTarget { get; set; }

        /// <summary>
        /// Target utilization percentage for scaling up/down.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
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
        /// Initializes a new instance of the <see cref="UpdateAutoscalingSettingsV1" /> class.
        /// </summary>
        /// <param name="minReplica">
        /// Minimum number of replicas<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="maxReplica">
        /// Maximum number of replicas<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="autoscalingWindow">
        /// Timeframe of traffic considered for autoscaling decisions<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="scaleDownDelay">
        /// Waiting period before scaling down any active replica<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="concurrencyTarget">
        /// Number of requests per replica before scaling up<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="targetUtilizationPercentage">
        /// Target utilization percentage for scaling up/down.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="targetInFlightTokens">
        /// Target number of in-flight tokens for autoscaling decisions. Early access only.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAutoscalingSettingsV1(
            int? minReplica,
            int? maxReplica,
            int? autoscalingWindow,
            int? scaleDownDelay,
            int? concurrencyTarget,
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
        /// Initializes a new instance of the <see cref="UpdateAutoscalingSettingsV1" /> class.
        /// </summary>
        public UpdateAutoscalingSettingsV1()
        {
        }
    }
}