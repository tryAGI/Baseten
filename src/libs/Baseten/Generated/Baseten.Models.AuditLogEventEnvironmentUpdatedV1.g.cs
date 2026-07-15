
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A model environment's settings were updated.
    /// </summary>
    public sealed partial class AuditLogEventEnvironmentUpdatedV1
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
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_type")]
        public string? DeploymentType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redeploy_on_promotion")]
        public bool? RedeployOnPromotion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ramp_up_while_promoting")]
        public bool? RampUpWhilePromoting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ramp_up_duration_seconds")]
        public int? RampUpDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ramp_up_step_size")]
        public int? RampUpStepSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rolling_deploy")]
        public bool? RollingDeploy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rolling_deploy_strategy")]
        public string? RollingDeployStrategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_unavailable_percent")]
        public int? MaxUnavailablePercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_surge_percent")]
        public int? MaxSurgePercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stabilization_time_seconds")]
        public int? StabilizationTimeSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_overhead_percent")]
        public int? ReplicaOverheadPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotion_cleanup_strategy")]
        public string? PromotionCleanupStrategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"ENVIRONMENT_UPDATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "ENVIRONMENT_UPDATED";

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
        /// Initializes a new instance of the <see cref="AuditLogEventEnvironmentUpdatedV1" /> class.
        /// </summary>
        /// <param name="minReplica"></param>
        /// <param name="maxReplica"></param>
        /// <param name="concurrencyTarget"></param>
        /// <param name="modelId"></param>
        /// <param name="modelName"></param>
        /// <param name="environmentName"></param>
        /// <param name="autoscalingWindow"></param>
        /// <param name="scaleDownDelay"></param>
        /// <param name="targetUtilizationPercentage"></param>
        /// <param name="targetInFlightTokens"></param>
        /// <param name="maxScaleDownRate"></param>
        /// <param name="deploymentType"></param>
        /// <param name="redeployOnPromotion"></param>
        /// <param name="rampUpWhilePromoting"></param>
        /// <param name="rampUpDurationSeconds"></param>
        /// <param name="rampUpStepSize"></param>
        /// <param name="rollingDeploy"></param>
        /// <param name="rollingDeployStrategy"></param>
        /// <param name="maxUnavailablePercent"></param>
        /// <param name="maxSurgePercent"></param>
        /// <param name="stabilizationTimeSeconds"></param>
        /// <param name="replicaOverheadPercent"></param>
        /// <param name="promotionCleanupStrategy"></param>
        /// <param name="previousSettings"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventEnvironmentUpdatedV1(
            int minReplica,
            int maxReplica,
            int concurrencyTarget,
            string modelId,
            string modelName,
            string environmentName,
            int? autoscalingWindow,
            int? scaleDownDelay,
            int? targetUtilizationPercentage,
            int? targetInFlightTokens,
            double? maxScaleDownRate,
            string? deploymentType,
            bool? redeployOnPromotion,
            bool? rampUpWhilePromoting,
            int? rampUpDurationSeconds,
            int? rampUpStepSize,
            bool? rollingDeploy,
            string? rollingDeployStrategy,
            int? maxUnavailablePercent,
            int? maxSurgePercent,
            int? stabilizationTimeSeconds,
            int? replicaOverheadPercent,
            string? promotionCleanupStrategy,
            global::Baseten.AuditLogEventAutoscalingSettingsV1? previousSettings,
            string eventType = "ENVIRONMENT_UPDATED")
        {
            this.MinReplica = minReplica;
            this.MaxReplica = maxReplica;
            this.ConcurrencyTarget = concurrencyTarget;
            this.AutoscalingWindow = autoscalingWindow;
            this.ScaleDownDelay = scaleDownDelay;
            this.TargetUtilizationPercentage = targetUtilizationPercentage;
            this.TargetInFlightTokens = targetInFlightTokens;
            this.MaxScaleDownRate = maxScaleDownRate;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.EnvironmentName = environmentName ?? throw new global::System.ArgumentNullException(nameof(environmentName));
            this.DeploymentType = deploymentType;
            this.RedeployOnPromotion = redeployOnPromotion;
            this.RampUpWhilePromoting = rampUpWhilePromoting;
            this.RampUpDurationSeconds = rampUpDurationSeconds;
            this.RampUpStepSize = rampUpStepSize;
            this.RollingDeploy = rollingDeploy;
            this.RollingDeployStrategy = rollingDeployStrategy;
            this.MaxUnavailablePercent = maxUnavailablePercent;
            this.MaxSurgePercent = maxSurgePercent;
            this.StabilizationTimeSeconds = stabilizationTimeSeconds;
            this.ReplicaOverheadPercent = replicaOverheadPercent;
            this.PromotionCleanupStrategy = promotionCleanupStrategy;
            this.EventType = eventType;
            this.PreviousSettings = previousSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventEnvironmentUpdatedV1" /> class.
        /// </summary>
        public AuditLogEventEnvironmentUpdatedV1()
        {
        }

    }
}