
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoopsCheckpointConfig
    {
        /// <summary>
        /// ID of the Loops run to load the checkpoint from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunId { get; set; }

        /// <summary>
        /// Name of the checkpoint to load
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckpointName { get; set; }

        /// <summary>
        /// Which checkpoint target to load: 'trainer' (full training state) or 'sampler' (inference weights)<br/>
        /// Default Value: trainer
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.LoopsCheckpointConfigTargetJsonConverter))]
        public global::Baseten.LoopsCheckpointConfigTarget? Target { get; set; }

        /// <summary>
        /// Default Value: loops_checkpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("typ")]
        public string? Typ { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsCheckpointConfig" /> class.
        /// </summary>
        /// <param name="runId">
        /// ID of the Loops run to load the checkpoint from
        /// </param>
        /// <param name="checkpointName">
        /// Name of the checkpoint to load
        /// </param>
        /// <param name="target">
        /// Which checkpoint target to load: 'trainer' (full training state) or 'sampler' (inference weights)<br/>
        /// Default Value: trainer
        /// </param>
        /// <param name="typ">
        /// Default Value: loops_checkpoint
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsCheckpointConfig(
            string runId,
            string checkpointName,
            global::Baseten.LoopsCheckpointConfigTarget? target,
            string? typ)
        {
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.CheckpointName = checkpointName ?? throw new global::System.ArgumentNullException(nameof(checkpointName));
            this.Target = target;
            this.Typ = typ;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsCheckpointConfig" /> class.
        /// </summary>
        public LoopsCheckpointConfig()
        {
        }

    }
}