
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to upsert a training project.
    /// </summary>
    public sealed partial class UpsertTrainingProjectRequestV1
    {
        /// <summary>
        /// The training project to upsert.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.UpsertTrainingProjectV1 TrainingProject { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertTrainingProjectRequestV1" /> class.
        /// </summary>
        /// <param name="trainingProject">
        /// The training project to upsert.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertTrainingProjectRequestV1(
            global::Baseten.UpsertTrainingProjectV1 trainingProject)
        {
            this.TrainingProject = trainingProject ?? throw new global::System.ArgumentNullException(nameof(trainingProject));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertTrainingProjectRequestV1" /> class.
        /// </summary>
        public UpsertTrainingProjectRequestV1()
        {
        }
    }
}