
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A response to stopping a training job.
    /// </summary>
    public sealed partial class StopTrainingJobResponseV1
    {
        /// <summary>
        /// The stopped training job.
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
        /// Initializes a new instance of the <see cref="StopTrainingJobResponseV1" /> class.
        /// </summary>
        /// <param name="trainingJob">
        /// The stopped training job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StopTrainingJobResponseV1(
            global::Baseten.TrainingJobV1 trainingJob)
        {
            this.TrainingJob = trainingJob ?? throw new global::System.ArgumentNullException(nameof(trainingJob));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopTrainingJobResponseV1" /> class.
        /// </summary>
        public StopTrainingJobResponseV1()
        {
        }
    }
}