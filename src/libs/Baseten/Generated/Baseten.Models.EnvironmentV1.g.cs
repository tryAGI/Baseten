
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Environment for oracles.
    /// </summary>
    public sealed partial class EnvironmentV1
    {
        /// <summary>
        /// Name of the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Time the environment was created in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Unique identifier of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Current deployment of the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_deployment")]
        public global::Baseten.DeploymentV1? CurrentDeployment { get; set; }

        /// <summary>
        /// Candidate deployment being promoted to the environment, if a promotion is in progress<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidate_deployment")]
        public global::Baseten.DeploymentV1? CandidateDeployment { get; set; }

        /// <summary>
        /// Details of the in-progress promotion, if any<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("in_progress_promotion")]
        public global::Baseten.InProgressPromotionV1? InProgressPromotion { get; set; }

        /// <summary>
        /// Autoscaling settings for the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AutoscalingSettingsV1 AutoscalingSettings { get; set; }

        /// <summary>
        /// Promotion settings for the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotion_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.PromotionSettingsV1 PromotionSettings { get; set; }

        /// <summary>
        /// Instance type for the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.InstanceTypeV1 InstanceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the environment
        /// </param>
        /// <param name="createdAt">
        /// Time the environment was created in ISO 8601 format
        /// </param>
        /// <param name="modelId">
        /// Unique identifier of the model
        /// </param>
        /// <param name="autoscalingSettings">
        /// Autoscaling settings for the environment
        /// </param>
        /// <param name="promotionSettings">
        /// Promotion settings for the environment
        /// </param>
        /// <param name="instanceType">
        /// Instance type for the environment
        /// </param>
        /// <param name="currentDeployment">
        /// Current deployment of the environment
        /// </param>
        /// <param name="candidateDeployment">
        /// Candidate deployment being promoted to the environment, if a promotion is in progress<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="inProgressPromotion">
        /// Details of the in-progress promotion, if any<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentV1(
            string name,
            global::System.DateTime createdAt,
            string modelId,
            global::Baseten.AutoscalingSettingsV1 autoscalingSettings,
            global::Baseten.PromotionSettingsV1 promotionSettings,
            global::Baseten.InstanceTypeV1 instanceType,
            global::Baseten.DeploymentV1? currentDeployment,
            global::Baseten.DeploymentV1? candidateDeployment,
            global::Baseten.InProgressPromotionV1? inProgressPromotion)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.CurrentDeployment = currentDeployment;
            this.CandidateDeployment = candidateDeployment;
            this.InProgressPromotion = inProgressPromotion;
            this.AutoscalingSettings = autoscalingSettings ?? throw new global::System.ArgumentNullException(nameof(autoscalingSettings));
            this.PromotionSettings = promotionSettings ?? throw new global::System.ArgumentNullException(nameof(promotionSettings));
            this.InstanceType = instanceType ?? throw new global::System.ArgumentNullException(nameof(instanceType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentV1" /> class.
        /// </summary>
        public EnvironmentV1()
        {
        }
    }
}