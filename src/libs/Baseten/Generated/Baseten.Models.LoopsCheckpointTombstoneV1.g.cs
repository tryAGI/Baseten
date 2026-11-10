
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A Loops checkpoint whose delete was accepted.
    /// </summary>
    public sealed partial class LoopsCheckpointTombstoneV1
    {
        /// <summary>
        /// The deleted checkpoint ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the run that produced the checkpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunId { get; set; }

        /// <summary>
        /// The name the checkpoint was saved under.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckpointId { get; set; }

        /// <summary>
        /// Whether the checkpoint was loadable by the sampler or by the run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.TrainerCheckpointTargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.TrainerCheckpointTarget Target { get; set; }

        /// <summary>
        /// The checkpoint's bt:// path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsCheckpointTombstoneV1" /> class.
        /// </summary>
        /// <param name="id">
        /// The deleted checkpoint ID.
        /// </param>
        /// <param name="runId">
        /// The ID of the run that produced the checkpoint.
        /// </param>
        /// <param name="checkpointId">
        /// The name the checkpoint was saved under.
        /// </param>
        /// <param name="target">
        /// Whether the checkpoint was loadable by the sampler or by the run.
        /// </param>
        /// <param name="path">
        /// The checkpoint's bt:// path.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsCheckpointTombstoneV1(
            string id,
            string runId,
            string checkpointId,
            global::Baseten.TrainerCheckpointTarget target,
            string path)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.CheckpointId = checkpointId ?? throw new global::System.ArgumentNullException(nameof(checkpointId));
            this.Target = target;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsCheckpointTombstoneV1" /> class.
        /// </summary>
        public LoopsCheckpointTombstoneV1()
        {
        }

    }
}