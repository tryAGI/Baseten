
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A response to fetch a training job.
    /// </summary>
    public sealed partial class GetTrainingJobResponseV1
    {
        /// <summary>
        /// The training project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.TrainingProjectV1 TrainingProject { get; set; }

        /// <summary>
        /// The fetched training job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.TrainingJobV1 TrainingJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingJobResponseV1" /> class.
        /// </summary>
        /// <param name="trainingProject">
        /// The training project.
        /// </param>
        /// <param name="trainingJob">
        /// The fetched training job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrainingJobResponseV1(
            global::Baseten.TrainingProjectV1 trainingProject,
            global::Baseten.TrainingJobV1 trainingJob)
        {
            this.TrainingProject = trainingProject ?? throw new global::System.ArgumentNullException(nameof(trainingProject));
            this.TrainingJob = trainingJob ?? throw new global::System.ArgumentNullException(nameof(trainingJob));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingJobResponseV1" /> class.
        /// </summary>
        public GetTrainingJobResponseV1()
        {
        }
    }
}