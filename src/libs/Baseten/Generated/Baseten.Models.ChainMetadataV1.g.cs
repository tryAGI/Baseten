
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChainMetadataV1
    {
        /// <summary>
        /// Unique identifier of the chain
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainId { get; set; }

        /// <summary>
        /// Name of the chain<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_name")]
        public string? ChainName { get; set; }

        /// <summary>
        /// Unique identifier of the chain deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainDeploymentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainMetadataV1" /> class.
        /// </summary>
        /// <param name="chainId">
        /// Unique identifier of the chain
        /// </param>
        /// <param name="chainDeploymentId">
        /// Unique identifier of the chain deployment
        /// </param>
        /// <param name="chainName">
        /// Name of the chain<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChainMetadataV1(
            string chainId,
            string chainDeploymentId,
            string? chainName)
        {
            this.ChainId = chainId ?? throw new global::System.ArgumentNullException(nameof(chainId));
            this.ChainName = chainName;
            this.ChainDeploymentId = chainDeploymentId ?? throw new global::System.ArgumentNullException(nameof(chainDeploymentId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainMetadataV1" /> class.
        /// </summary>
        public ChainMetadataV1()
        {
        }
    }
}