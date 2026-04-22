
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A response to list checkpoints for a trainer server.
    /// </summary>
    public sealed partial class GetTrainerServerCheckpointsResponseV1
    {
        /// <summary>
        /// The ID of the trainer server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainer_server_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainerServerId { get; set; }

        /// <summary>
        /// The checkpoints for the trainer server.
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
        /// <param name="trainerServerId">
        /// The ID of the trainer server.
        /// </param>
        /// <param name="checkpoints">
        /// The checkpoints for the trainer server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrainerServerCheckpointsResponseV1(
            string trainerServerId,
            global::System.Collections.Generic.IList<global::Baseten.TrainerServerCheckpointV1> checkpoints)
        {
            this.TrainerServerId = trainerServerId ?? throw new global::System.ArgumentNullException(nameof(trainerServerId));
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