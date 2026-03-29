
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A chain tombstone.
    /// </summary>
    public sealed partial class ChainTombstoneV1
    {
        /// <summary>
        /// Unique identifier of the chain
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the chain was deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainTombstoneV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the chain
        /// </param>
        /// <param name="deleted">
        /// Whether the chain was deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChainTombstoneV1(
            string id,
            bool deleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainTombstoneV1" /> class.
        /// </summary>
        public ChainTombstoneV1()
        {
        }
    }
}