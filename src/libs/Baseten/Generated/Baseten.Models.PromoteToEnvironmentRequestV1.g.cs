
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to promote a deployment to a environment.
    /// </summary>
    public sealed partial class PromoteToEnvironmentRequestV1
    {
        /// <summary>
        /// Whether to scale down the previous deployment after promoting<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_down_previous_deployment")]
        public bool? ScaleDownPreviousDeployment { get; set; }

        /// <summary>
        /// The id of the deployment to promote
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// Whether to use the promoting deployment's instance type or preserve target environment's instance type<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_env_instance_type")]
        public bool? PreserveEnvInstanceType { get; set; }

        /// <summary>
        /// Changes to the environment's settings. Omitted fields are unchanged. The promoted deployment uses the environment's current settings with these changes applied, and the environment keeps the result when the promotion completes.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_settings_update")]
        public global::Baseten.PromotionEnvironmentSettingsUpdateV1? EnvironmentSettingsUpdate { get; set; }

        /// <summary>
        /// Promotion settings for this promotion only. Omitted fields keep the environment's values, and the environment's promotion settings are unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotion_settings_override")]
        public global::Baseten.UpdatePromotionSettingsV1? PromotionSettingsOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteToEnvironmentRequestV1" /> class.
        /// </summary>
        /// <param name="deploymentId">
        /// The id of the deployment to promote
        /// </param>
        /// <param name="scaleDownPreviousDeployment">
        /// Whether to scale down the previous deployment after promoting<br/>
        /// Default Value: true
        /// </param>
        /// <param name="preserveEnvInstanceType">
        /// Whether to use the promoting deployment's instance type or preserve target environment's instance type<br/>
        /// Default Value: true
        /// </param>
        /// <param name="environmentSettingsUpdate">
        /// Changes to the environment's settings. Omitted fields are unchanged. The promoted deployment uses the environment's current settings with these changes applied, and the environment keeps the result when the promotion completes.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="promotionSettingsOverride">
        /// Promotion settings for this promotion only. Omitted fields keep the environment's values, and the environment's promotion settings are unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromoteToEnvironmentRequestV1(
            string deploymentId,
            bool? scaleDownPreviousDeployment,
            bool? preserveEnvInstanceType,
            global::Baseten.PromotionEnvironmentSettingsUpdateV1? environmentSettingsUpdate,
            global::Baseten.UpdatePromotionSettingsV1? promotionSettingsOverride)
        {
            this.ScaleDownPreviousDeployment = scaleDownPreviousDeployment;
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.PreserveEnvInstanceType = preserveEnvInstanceType;
            this.EnvironmentSettingsUpdate = environmentSettingsUpdate;
            this.PromotionSettingsOverride = promotionSettingsOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromoteToEnvironmentRequestV1" /> class.
        /// </summary>
        public PromoteToEnvironmentRequestV1()
        {
        }

    }
}