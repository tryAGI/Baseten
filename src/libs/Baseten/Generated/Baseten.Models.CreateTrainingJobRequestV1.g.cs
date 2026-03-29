
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to create a training job.
    /// </summary>
    public sealed partial class CreateTrainingJobRequestV1
    {
        /// <summary>
        /// The training job to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.CreateTrainingJobV1 TrainingJob { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobRequestV1" /> class.
        /// </summary>
        /// <param name="trainingJob">
        /// The training job to create.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrainingJobRequestV1(
            global::Baseten.CreateTrainingJobV1 trainingJob)
        {
            this.TrainingJob = trainingJob ?? throw new global::System.ArgumentNullException(nameof(trainingJob));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainingJobRequestV1" /> class.
        /// </summary>
        public CreateTrainingJobRequestV1()
        {
        }
    }
}