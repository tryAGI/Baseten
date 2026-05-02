
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A response to list checkpoints for a trainer.
    /// </summary>
    public sealed partial class GetTrainerServerCheckpointsResponseV1
    {
        /// <summary>
        /// The ID of the trainer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainer_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainerId { get; set; }

        /// <summary>
        /// The checkpoints for the trainer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainerServerCheckpointV1> Checkpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainerServerCheckpointsResponseV1" /> class.
        /// </summary>
        /// <param name="trainerId">
        /// The ID of the trainer.
        /// </param>
        /// <param name="checkpoints">
        /// The checkpoints for the trainer.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrainerServerCheckpointsResponseV1(
            string trainerId,
            global::System.Collections.Generic.IList<global::Baseten.TrainerServerCheckpointV1> checkpoints)
        {
            this.TrainerId = trainerId ?? throw new global::System.ArgumentNullException(nameof(trainerId));
            this.Checkpoints = checkpoints ?? throw new global::System.ArgumentNullException(nameof(checkpoints));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainerServerCheckpointsResponseV1" /> class.
        /// </summary>
        public GetTrainerServerCheckpointsResponseV1()
        {
        }
    }
}