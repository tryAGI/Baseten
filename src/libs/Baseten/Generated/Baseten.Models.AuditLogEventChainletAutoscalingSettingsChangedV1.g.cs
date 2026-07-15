
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A chainlet's autoscaling settings were changed.
    /// </summary>
    public sealed partial class AuditLogEventChainletAutoscalingSettingsChangedV1
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
        /// 
        /// </summary>
        /// <default>"CHAINLET_AUTOSCALING_SETTINGS_CHANGED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "CHAINLET_AUTOSCALING_SETTINGS_CHANGED";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainDeploymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_deployment_name")]
        public string? ChainDeploymentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chainlet_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainletName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chainlet_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainletId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_settings")]
        public global::Baseten.AuditLogEventAutoscalingSettingsV1? PreviousSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventChainletAutoscalingSettingsChangedV1" /> class.
        /// </summary>
        /// <param name="minReplica"></param>
        /// <param name="maxReplica"></param>
        /// <param name="concurrencyTarget"></param>
        /// <param name="chainId"></param>
        /// <param name="chainName"></param>
        /// <param name="chainDeploymentId"></param>
        /// <param name="chainletName"></param>
        /// <param name="chainletId"></param>
        /// <param name="autoscalingWindow"></param>
        /// <param name="scaleDownDelay"></param>
        /// <param name="targetUtilizationPercentage"></param>
        /// <param name="targetInFlightTokens"></param>
        /// <param name="maxScaleDownRate"></param>
        /// <param name="chainDeploymentName"></param>
        /// <param name="previousSettings"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventChainletAutoscalingSettingsChangedV1(
            int minReplica,
            int maxReplica,
            int concurrencyTarget,
            string chainId,
            string chainName,
            string chainDeploymentId,
            string chainletName,
            string chainletId,
            int? autoscalingWindow,
            int? scaleDownDelay,
            int? targetUtilizationPercentage,
            int? targetInFlightTokens,
            double? maxScaleDownRate,
            string? chainDeploymentName,
            global::Baseten.AuditLogEventAutoscalingSettingsV1? previousSettings,
            string eventType = "CHAINLET_AUTOSCALING_SETTINGS_CHANGED")
        {
            this.MinReplica = minReplica;
            this.MaxReplica = maxReplica;
            this.ConcurrencyTarget = concurrencyTarget;
            this.AutoscalingWindow = autoscalingWindow;
            this.ScaleDownDelay = scaleDownDelay;
            this.TargetUtilizationPercentage = targetUtilizationPercentage;
            this.TargetInFlightTokens = targetInFlightTokens;
            this.MaxScaleDownRate = maxScaleDownRate;
            this.EventType = eventType;
            this.ChainId = chainId ?? throw new global::System.ArgumentNullException(nameof(chainId));
            this.ChainName = chainName ?? throw new global::System.ArgumentNullException(nameof(chainName));
            this.ChainDeploymentId = chainDeploymentId ?? throw new global::System.ArgumentNullException(nameof(chainDeploymentId));
            this.ChainDeploymentName = chainDeploymentName;
            this.ChainletName = chainletName ?? throw new global::System.ArgumentNullException(nameof(chainletName));
            this.ChainletId = chainletId ?? throw new global::System.ArgumentNullException(nameof(chainletId));
            this.PreviousSettings = previousSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventChainletAutoscalingSettingsChangedV1" /> class.
        /// </summary>
        public AuditLogEventChainletAutoscalingSettingsChangedV1()
        {
        }

    }
}