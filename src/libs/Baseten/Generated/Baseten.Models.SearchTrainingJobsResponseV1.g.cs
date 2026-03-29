
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A response to search training jobs.
    /// </summary>
    public sealed partial class SearchTrainingJobsResponseV1
    {
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
        /// Initializes a new instance of the <see cref="SearchTrainingJobsResponseV1" /> class.
        /// </summary>
        /// <param name="trainingJobs">
        /// List of training jobs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchTrainingJobsResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.TrainingJobV1> trainingJobs)
        {
            this.TrainingJobs = trainingJobs ?? throw new global::System.ArgumentNullException(nameof(trainingJobs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTrainingJobsResponseV1" /> class.
        /// </summary>
        public SearchTrainingJobsResponseV1()
        {
        }
    }
}