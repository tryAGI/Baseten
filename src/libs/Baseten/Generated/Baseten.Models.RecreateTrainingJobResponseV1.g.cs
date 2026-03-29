
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A response that sends the new training job
    /// </summary>
    public sealed partial class RecreateTrainingJobResponseV1
    {
        /// <summary>
        /// The created training job.
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
        /// Initializes a new instance of the <see cref="RecreateTrainingJobResponseV1" /> class.
        /// </summary>
        /// <param name="trainingJob">
        /// The created training job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecreateTrainingJobResponseV1(
            global::Baseten.TrainingJobV1 trainingJob)
        {
            this.TrainingJob = trainingJob ?? throw new global::System.ArgumentNullException(nameof(trainingJob));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecreateTrainingJobResponseV1" /> class.
        /// </summary>
        public RecreateTrainingJobResponseV1()
        {
        }
    }
}