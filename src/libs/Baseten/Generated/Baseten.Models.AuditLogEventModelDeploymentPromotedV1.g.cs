
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A model deployment was promoted to an environment.
    /// </summary>
    public sealed partial class AuditLogEventModelDeploymentPromotedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"MODEL_DEPLOYMENT_PROMOTED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "MODEL_DEPLOYMENT_PROMOTED";

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
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_name")]
        public string? EnvironmentName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region_update")]
        public string? RegionUpdate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type_id_update")]
        public string? InstanceTypeIdUpdate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotion_settings_override")]
        public global::Baseten.AuditLogEventPromotionSettingsOverrideV1? PromotionSettingsOverride { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_settings_update")]
        public global::Baseten.AuditLogEventAutoscalingSettingsUpdateV1? AutoscalingSettingsUpdate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_backpressure_settings_update")]
        public global::Baseten.AuditLogEventRequestBackpressureSettingsUpdateV1? RequestBackpressureSettingsUpdate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_schedule_settings_update")]
        public global::Baseten.AuditLogEventAutoscalingScheduleOperationsV1? AutoscalingScheduleSettingsUpdate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventModelDeploymentPromotedV1" /> class.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="modelName"></param>
        /// <param name="deploymentId"></param>
        /// <param name="deploymentName"></param>
        /// <param name="environmentName"></param>
        /// <param name="environmentId"></param>
        /// <param name="regionUpdate"></param>
        /// <param name="instanceTypeIdUpdate"></param>
        /// <param name="promotionSettingsOverride"></param>
        /// <param name="autoscalingSettingsUpdate"></param>
        /// <param name="requestBackpressureSettingsUpdate"></param>
        /// <param name="autoscalingScheduleSettingsUpdate"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventModelDeploymentPromotedV1(
            string modelId,
            string modelName,
            string deploymentId,
            string deploymentName,
            string? environmentName,
            string? environmentId,
            string? regionUpdate,
            string? instanceTypeIdUpdate,
            global::Baseten.AuditLogEventPromotionSettingsOverrideV1? promotionSettingsOverride,
            global::Baseten.AuditLogEventAutoscalingSettingsUpdateV1? autoscalingSettingsUpdate,
            global::Baseten.AuditLogEventRequestBackpressureSettingsUpdateV1? requestBackpressureSettingsUpdate,
            global::Baseten.AuditLogEventAutoscalingScheduleOperationsV1? autoscalingScheduleSettingsUpdate,
            string eventType = "MODEL_DEPLOYMENT_PROMOTED")
        {
            this.EventType = eventType;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.DeploymentName = deploymentName ?? throw new global::System.ArgumentNullException(nameof(deploymentName));
            this.EnvironmentName = environmentName;
            this.EnvironmentId = environmentId;
            this.RegionUpdate = regionUpdate;
            this.InstanceTypeIdUpdate = instanceTypeIdUpdate;
            this.PromotionSettingsOverride = promotionSettingsOverride;
            this.AutoscalingSettingsUpdate = autoscalingSettingsUpdate;
            this.RequestBackpressureSettingsUpdate = requestBackpressureSettingsUpdate;
            this.AutoscalingScheduleSettingsUpdate = autoscalingScheduleSettingsUpdate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventModelDeploymentPromotedV1" /> class.
        /// </summary>
        public AuditLogEventModelDeploymentPromotedV1()
        {
        }

    }
}