
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A response to list training jobs.
    /// </summary>
    public sealed partial class ListTrainingJobsResponseV1
    {
        /// <summary>
        /// The training project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.TrainingProjectV1 TrainingProject { get; set; }

        /// <summary>
        /// List of training jobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_jobs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingJobV1> TrainingJobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTrainingJobsResponseV1" /> class.
        /// </summary>
        /// <param name="trainingProject">
        /// The training project.
        /// </param>
        /// <param name="trainingJobs">
        /// List of training jobs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListTrainingJobsResponseV1(
            global::Baseten.TrainingProjectV1 trainingProject,
            global::System.Collections.Generic.IList<global::Baseten.TrainingJobV1> trainingJobs)
        {
            this.TrainingProject = trainingProject ?? throw new global::System.ArgumentNullException(nameof(trainingProject));
            this.TrainingJobs = trainingJobs ?? throw new global::System.ArgumentNullException(nameof(trainingJobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListTrainingJobsResponseV1" /> class.
        /// </summary>
        public ListTrainingJobsResponseV1()
        {
        }
    }
}