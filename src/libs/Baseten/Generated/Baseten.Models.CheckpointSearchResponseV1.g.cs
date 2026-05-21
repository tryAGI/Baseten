
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``POST /v1/trainers/checkpoints/search``.
    /// </summary>
    public sealed partial class CheckpointSearchResponseV1
    {
        /// <summary>
        /// The checkpoint metadata (id, target, type, sizes, etc.).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.TrainerServerCheckpointV1 Checkpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckpointSearchResponseV1" /> class.
        /// </summary>
        /// <param name="checkpoint">
        /// The checkpoint metadata (id, target, type, sizes, etc.).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CheckpointSearchResponseV1(
            global::Baseten.TrainerServerCheckpointV1 checkpoint)
        {
            this.Checkpoint = checkpoint ?? throw new global::System.ArgumentNullException(nameof(checkpoint));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckpointSearchResponseV1" /> class.
        /// </summary>
        public CheckpointSearchResponseV1()
        {
        }

    }
}