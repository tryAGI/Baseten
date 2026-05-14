
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGroupRequestV1
    {
        /// <summary>
        /// Group identity + display metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GroupMetadataV1 Metadata { get; set; }

        /// <summary>
        /// Per-model rate and usage limit configuration. Defines the group's complete model set. Must be non-empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ModelConfigV1> Models { get; set; }

        /// <summary>
        /// Parent linkage and limit enforcement mode. Immutable after creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GroupHierarchyV1 Hierarchy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupRequestV1" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Group identity + display metadata.
        /// </param>
        /// <param name="models">
        /// Per-model rate and usage limit configuration. Defines the group's complete model set. Must be non-empty.
        /// </param>
        /// <param name="hierarchy">
        /// Parent linkage and limit enforcement mode. Immutable after creation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGroupRequestV1(
            global::Baseten.GroupMetadataV1 metadata,
            global::System.Collections.Generic.IList<global::Baseten.ModelConfigV1> models,
            global::Baseten.GroupHierarchyV1 hierarchy)
        {
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.Hierarchy = hierarchy ?? throw new global::System.ArgumentNullException(nameof(hierarchy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupRequestV1" /> class.
        /// </summary>
        public CreateGroupRequestV1()
        {
        }

    }
}