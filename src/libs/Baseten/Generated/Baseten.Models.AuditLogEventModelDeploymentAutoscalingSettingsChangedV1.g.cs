
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A model deployment's autoscaling settings were changed.
    /// </summary>
    public sealed partial class AuditLogEventModelDeploymentAutoscalingSettingsChangedV1
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
        /// <default>"MODEL_DEPLOYMENT_AUTOSCALING_SETTINGS_CHANGED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "MODEL_DEPLOYMENT_AUTOSCALING_SETTINGS_CHANGED";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_type")]
        public string? DeploymentType { get; set; }

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
        /// Initializes a new instance of the <see cref="AuditLogEventModelDeploymentAutoscalingSettingsChangedV1" /> class.
        /// </summary>
        /// <param name="minReplica"></param>
        /// <param name="maxReplica"></param>
        /// <param name="concurrencyTarget"></param>
        /// <param name="modelId"></param>
        /// <param name="modelName"></param>
        /// <param name="deploymentId"></param>
        /// <param name="deploymentName"></param>
        /// <param name="autoscalingWindow"></param>
        /// <param name="scaleDownDelay"></param>
        /// <param name="targetUtilizationPercentage"></param>
        /// <param name="targetInFlightTokens"></param>
        /// <param name="maxScaleDownRate"></param>
        /// <param name="deploymentType"></param>
        /// <param name="previousSettings"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventModelDeploymentAutoscalingSettingsChangedV1(
            int minReplica,
            int maxReplica,
            int concurrencyTarget,
            string modelId,
            string modelName,
            string deploymentId,
            string deploymentName,
            int? autoscalingWindow,
            int? scaleDownDelay,
            int? targetUtilizationPercentage,
            int? targetInFlightTokens,
            double? maxScaleDownRate,
            string? deploymentType,
            global::Baseten.AuditLogEventAutoscalingSettingsV1? previousSettings,
            string eventType = "MODEL_DEPLOYMENT_AUTOSCALING_SETTINGS_CHANGED")
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
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.DeploymentName = deploymentName ?? throw new global::System.ArgumentNullException(nameof(deploymentName));
            this.DeploymentType = deploymentType;
            this.PreviousSettings = previousSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventModelDeploymentAutoscalingSettingsChangedV1" /> class.
        /// </summary>
        public AuditLogEventModelDeploymentAutoscalingSettingsChangedV1()
        {
        }

    }
}