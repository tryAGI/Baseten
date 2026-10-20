
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Promotion settings for promoting models
    /// </summary>
    public sealed partial class ModelPromotionSettingsV1
    {
        /// <summary>
        /// Whether to deploy on all promotions. Enabling this flag allows model code to safely handle environment-specific logic. When a deployment is promoted, a new deployment will be created with a copy of the image.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redeploy_on_promotion")]
        public bool? RedeployOnPromotion { get; set; }

        /// <summary>
        /// Whether the environment should rely on rolling deploy orchestration.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rolling_deploy")]
        public bool? RollingDeploy { get; set; }

        /// <summary>
        /// The cleanup strategy to use after a promotion completes.<br/>
        /// Default Value: SCALE_TO_ZERO
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotion_cleanup_strategy")]
        public global::Baseten.PromotionCleanupStrategyV1? PromotionCleanupStrategy { get; set; }

        /// <summary>
        /// Rolling deploy configuration for promotions<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rolling_deploy_config")]
        public global::Baseten.RollingDeployConfigV1? RollingDeployConfig { get; set; }

        /// <summary>
        /// Deprecated: models don't support canary promotions. Use `rolling_deploy`.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ramp_up_while_promoting")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? RampUpWhilePromoting { get; set; }

        /// <summary>
        /// Deprecated: models don't support canary promotions.<br/>
        /// Default Value: 600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ramp_up_duration_seconds")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? RampUpDurationSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPromotionSettingsV1" /> class.
        /// </summary>
        /// <param name="redeployOnPromotion">
        /// Whether to deploy on all promotions. Enabling this flag allows model code to safely handle environment-specific logic. When a deployment is promoted, a new deployment will be created with a copy of the image.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="rollingDeploy">
        /// Whether the environment should rely on rolling deploy orchestration.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="promotionCleanupStrategy">
        /// The cleanup strategy to use after a promotion completes.<br/>
        /// Default Value: SCALE_TO_ZERO
        /// </param>
        /// <param name="rollingDeployConfig">
        /// Rolling deploy configuration for promotions<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPromotionSettingsV1(
            bool? redeployOnPromotion,
            bool? rollingDeploy,
            global::Baseten.PromotionCleanupStrategyV1? promotionCleanupStrategy,
            global::Baseten.RollingDeployConfigV1? rollingDeployConfig)
        {
            this.RedeployOnPromotion = redeployOnPromotion;
            this.RollingDeploy = rollingDeploy;
            this.PromotionCleanupStrategy = promotionCleanupStrategy;
            this.RollingDeployConfig = rollingDeployConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPromotionSettingsV1" /> class.
        /// </summary>
        public ModelPromotionSettingsV1()
        {
        }

    }
}