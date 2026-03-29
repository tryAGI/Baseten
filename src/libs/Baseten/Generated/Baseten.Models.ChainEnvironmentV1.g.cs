
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Environment for oracles.
    /// </summary>
    public sealed partial class ChainEnvironmentV1
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
        /// Unique identifier of the chain
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainId { get; set; }

        /// <summary>
        /// Promotion settings for the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotion_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.PromotionSettingsV1 PromotionSettings { get; set; }

        /// <summary>
        /// Environment settings for the chainlets
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chainlet_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentSettingsV1> ChainletSettings { get; set; }

        /// <summary>
        /// Current chain deployment of the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_deployment")]
        public global::Baseten.ChainDeploymentV1? CurrentDeployment { get; set; }

        /// <summary>
        /// Candidate chain deployment being promoted to the environment, if a promotion is in progress<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidate_deployment")]
        public global::Baseten.ChainDeploymentV1? CandidateDeployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainEnvironmentV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the environment
        /// </param>
        /// <param name="createdAt">
        /// Time the environment was created in ISO 8601 format
        /// </param>
        /// <param name="chainId">
        /// Unique identifier of the chain
        /// </param>
        /// <param name="promotionSettings">
        /// Promotion settings for the environment
        /// </param>
        /// <param name="chainletSettings">
        /// Environment settings for the chainlets
        /// </param>
        /// <param name="currentDeployment">
        /// Current chain deployment of the environment
        /// </param>
        /// <param name="candidateDeployment">
        /// Candidate chain deployment being promoted to the environment, if a promotion is in progress<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChainEnvironmentV1(
            string name,
            global::System.DateTime createdAt,
            string chainId,
            global::Baseten.PromotionSettingsV1 promotionSettings,
            global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentSettingsV1> chainletSettings,
            global::Baseten.ChainDeploymentV1? currentDeployment,
            global::Baseten.ChainDeploymentV1? candidateDeployment)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.ChainId = chainId ?? throw new global::System.ArgumentNullException(nameof(chainId));
            this.PromotionSettings = promotionSettings ?? throw new global::System.ArgumentNullException(nameof(promotionSettings));
            this.ChainletSettings = chainletSettings ?? throw new global::System.ArgumentNullException(nameof(chainletSettings));
            this.CurrentDeployment = currentDeployment;
            this.CandidateDeployment = candidateDeployment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainEnvironmentV1" /> class.
        /// </summary>
        public ChainEnvironmentV1()
        {
        }
    }
}