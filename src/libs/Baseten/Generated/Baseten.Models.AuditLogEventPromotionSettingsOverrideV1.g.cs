
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Promotion settings overridden for one promotion. Null means the environment's value. Not<br/>
    /// itself a payload in the discriminated union.
    /// </summary>
    public sealed partial class AuditLogEventPromotionSettingsOverrideV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redeploy_on_promotion")]
        public bool? RedeployOnPromotion { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventPromotionSettingsOverrideV1" /> class.
        /// </summary>
        /// <param name="redeployOnPromotion"></param>
        /// <param name="rollingDeploy"></param>
        /// <param name="rollingDeployStrategy"></param>
        /// <param name="maxUnavailablePercent"></param>
        /// <param name="maxSurgePercent"></param>
        /// <param name="stabilizationTimeSeconds"></param>
        /// <param name="replicaOverheadPercent"></param>
        /// <param name="promotionCleanupStrategy"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventPromotionSettingsOverrideV1(
            bool? redeployOnPromotion,
            bool? rollingDeploy,
            string? rollingDeployStrategy,
            int? maxUnavailablePercent,
            int? maxSurgePercent,
            int? stabilizationTimeSeconds,
            int? replicaOverheadPercent,
            string? promotionCleanupStrategy)
        {
            this.RedeployOnPromotion = redeployOnPromotion;
            this.RollingDeploy = rollingDeploy;
            this.RollingDeployStrategy = rollingDeployStrategy;
            this.MaxUnavailablePercent = maxUnavailablePercent;
            this.MaxSurgePercent = maxSurgePercent;
            this.StabilizationTimeSeconds = stabilizationTimeSeconds;
            this.ReplicaOverheadPercent = replicaOverheadPercent;
            this.PromotionCleanupStrategy = promotionCleanupStrategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventPromotionSettingsOverrideV1" /> class.
        /// </summary>
        public AuditLogEventPromotionSettingsOverrideV1()
        {
        }

    }
}