
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Autoscaling settings for a deployment or environment.
    /// </summary>
    public sealed partial class AuditLogEventAutoscalingSettingsV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_replica")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinReplica { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_replica")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxReplica { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency_target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConcurrencyTarget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_window")]
        public int? AutoscalingWindow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_down_delay")]
        public int? ScaleDownDelay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_utilization_percentage")]
        public int? TargetUtilizationPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_in_flight_tokens")]
        public int? TargetInFlightTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_scale_down_rate")]
        public double? MaxScaleDownRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventAutoscalingSettingsV1" /> class.
        /// </summary>
        /// <param name="minReplica"></param>
        /// <param name="maxReplica"></param>
        /// <param name="concurrencyTarget"></param>
        /// <param name="autoscalingWindow"></param>
        /// <param name="scaleDownDelay"></param>
        /// <param name="targetUtilizationPercentage"></param>
        /// <param name="targetInFlightTokens"></param>
        /// <param name="maxScaleDownRate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventAutoscalingSettingsV1(
            int minReplica,
            int maxReplica,
            int concurrencyTarget,
            int? autoscalingWindow,
            int? scaleDownDelay,
            int? targetUtilizationPercentage,
            int? targetInFlightTokens,
            double? maxScaleDownRate)
        {
            this.MinReplica = minReplica;
            this.MaxReplica = maxReplica;
            this.ConcurrencyTarget = concurrencyTarget;
            this.AutoscalingWindow = autoscalingWindow;
            this.ScaleDownDelay = scaleDownDelay;
            this.TargetUtilizationPercentage = targetUtilizationPercentage;
            this.TargetInFlightTokens = targetInFlightTokens;
            this.MaxScaleDownRate = maxScaleDownRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventAutoscalingSettingsV1" /> class.
        /// </summary>
        public AuditLogEventAutoscalingSettingsV1()
        {
        }

    }
}