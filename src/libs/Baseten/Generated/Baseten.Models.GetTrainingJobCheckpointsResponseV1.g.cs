
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A response to fetch checkpoints for a training job.
    /// </summary>
    public sealed partial class GetTrainingJobCheckpointsResponseV1
    {
        /// <summary>
        /// The training job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.TrainingJobV1 TrainingJob { get; set; }

        /// <summary>
        /// The checkpoints for the training job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingJobCheckpointV1> Checkpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingJobCheckpointsResponseV1" /> class.
        /// </summary>
        /// <param name="trainingJob">
        /// The training job.
        /// </param>
        /// <param name="checkpoints">
        /// The checkpoints for the training job.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrainingJobCheckpointsResponseV1(
            global::Baseten.TrainingJobV1 trainingJob,
            global::System.Collections.Generic.IList<global::Baseten.TrainingJobCheckpointV1> checkpoints)
        {
            this.TrainingJob = trainingJob ?? throw new global::System.ArgumentNullException(nameof(trainingJob));
            this.Checkpoints = checkpoints ?? throw new global::System.ArgumentNullException(nameof(checkpoints));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingJobCheckpointsResponseV1" /> class.
        /// </summary>
        public GetTrainingJobCheckpointsResponseV1()
        {
        }
    }
}