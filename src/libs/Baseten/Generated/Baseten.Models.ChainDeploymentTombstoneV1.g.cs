
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A chain deployment tombstone.
    /// </summary>
    public sealed partial class ChainDeploymentTombstoneV1
    {
        /// <summary>
        /// Unique identifier of the chain deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the chain deployment was deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Unique identifier of the chain
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chain_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainDeploymentTombstoneV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the chain deployment
        /// </param>
        /// <param name="deleted">
        /// Whether the chain deployment was deleted
        /// </param>
        /// <param name="chainId">
        /// Unique identifier of the chain
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChainDeploymentTombstoneV1(
            string id,
            bool deleted,
            string chainId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
            this.ChainId = chainId ?? throw new global::System.ArgumentNullException(nameof(chainId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainDeploymentTombstoneV1" /> class.
        /// </summary>
        public ChainDeploymentTombstoneV1()
        {
        }
    }
}