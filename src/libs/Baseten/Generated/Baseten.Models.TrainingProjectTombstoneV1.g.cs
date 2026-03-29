
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A training project tombstone.
    /// </summary>
    public sealed partial class TrainingProjectTombstoneV1
    {
        /// <summary>
        /// Unique identifier of the training project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the training project was deleted
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
        /// Initializes a new instance of the <see cref="TrainingProjectTombstoneV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the training project
        /// </param>
        /// <param name="deleted">
        /// Whether the training project was deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingProjectTombstoneV1(
            string id,
            bool deleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingProjectTombstoneV1" /> class.
        /// </summary>
        public TrainingProjectTombstoneV1()
        {
        }
    }
}