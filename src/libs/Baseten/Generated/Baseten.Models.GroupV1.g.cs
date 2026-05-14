
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupV1
    {
        /// <summary>
        /// Internal Baseten ID for the group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Group identity + display metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GroupMetadataV1 Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::Baseten.ModelConfigV1>? Models { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_models")]
        public global::System.Collections.Generic.IList<global::Baseten.EffectiveModelConfigV1>? EffectiveModels { get; set; }

        /// <summary>
        /// Parent linkage and limit enforcement mode. Parent is null for root groups.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarchy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GroupHierarchyV1 Hierarchy { get; set; }

        /// <summary>
        /// When this group was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Internal Baseten ID for the group.
        /// </param>
        /// <param name="metadata">
        /// Group identity + display metadata.
        /// </param>
        /// <param name="hierarchy">
        /// Parent linkage and limit enforcement mode. Parent is null for root groups.
        /// </param>
        /// <param name="createdAt">
        /// When this group was created.
        /// </param>
        /// <param name="models"></param>
        /// <param name="effectiveModels"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupV1(
            string id,
            global::Baseten.GroupMetadataV1 metadata,
            global::Baseten.GroupHierarchyV1 hierarchy,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::Baseten.ModelConfigV1>? models,
            global::System.Collections.Generic.IList<global::Baseten.EffectiveModelConfigV1>? effectiveModels)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Models = models;
            this.EffectiveModels = effectiveModels;
            this.Hierarchy = hierarchy ?? throw new global::System.ArgumentNullException(nameof(hierarchy));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupV1" /> class.
        /// </summary>
        public GroupV1()
        {
        }

    }
}