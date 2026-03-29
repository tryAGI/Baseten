
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A training job tombstone.
    /// </summary>
    public sealed partial class TrainingJobTombstoneV1
    {
        /// <summary>
        /// Unique identifier of the training job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the training job was deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Unique identifier of the training project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingJobTombstoneV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the training job
        /// </param>
        /// <param name="deleted">
        /// Whether the training job was deleted
        /// </param>
        /// <param name="trainingProjectId">
        /// Unique identifier of the training project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingJobTombstoneV1(
            string id,
            bool deleted,
            string trainingProjectId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
            this.TrainingProjectId = trainingProjectId ?? throw new global::System.ArgumentNullException(nameof(trainingProjectId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingJobTombstoneV1" /> class.
        /// </summary>
        public TrainingJobTombstoneV1()
        {
        }
    }
}