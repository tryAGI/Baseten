
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A deployment of a chain.
    /// </summary>
    public sealed partial class ChainDeploymentV1
    {
        /// <summary>
        /// Unique identifier of the chain deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Time the chain deployment was created in ISO 8601 format
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
        /// Environment the chain deployment is deployed in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Chainlets in the chain deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chainlets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ChainletV1> Chainlets { get; set; }

        /// <summary>
        /// Status of the chain deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.DeploymentStatusV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentStatusV1 Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainDeploymentV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the chain deployment
        /// </param>
        /// <param name="createdAt">
        /// Time the chain deployment was created in ISO 8601 format
        /// </param>
        /// <param name="chainId">
        /// Unique identifier of the chain
        /// </param>
        /// <param name="chainlets">
        /// Chainlets in the chain deployment
        /// </param>
        /// <param name="status">
        /// Status of the chain deployment
        /// </param>
        /// <param name="environment">
        /// Environment the chain deployment is deployed in
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChainDeploymentV1(
            string id,
            global::System.DateTime createdAt,
            string chainId,
            global::System.Collections.Generic.IList<global::Baseten.ChainletV1> chainlets,
            global::Baseten.DeploymentStatusV1 status,
            string? environment)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.ChainId = chainId ?? throw new global::System.ArgumentNullException(nameof(chainId));
            this.Environment = environment;
            this.Chainlets = chainlets ?? throw new global::System.ArgumentNullException(nameof(chainlets));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainDeploymentV1" /> class.
        /// </summary>
        public ChainDeploymentV1()
        {
        }
    }
}