
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request body for ``POST /v1/loops/checkpoints/validate``.
    /// </summary>
    public sealed partial class ValidateLoopsCheckpointRequestV1
    {
        /// <summary>
        /// bt:// URI of a sampler checkpoint. Form: bt://loops:&lt;run_id&gt;/sampler_weights/&lt;checkpoint_name&gt;.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CheckpointPath { get; set; }

        /// <summary>
        /// Loops run whose sampler will load the checkpoint. The checkpoint must use the run's LoRA config.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateLoopsCheckpointRequestV1" /> class.
        /// </summary>
        /// <param name="checkpointPath">
        /// bt:// URI of a sampler checkpoint. Form: bt://loops:&lt;run_id&gt;/sampler_weights/&lt;checkpoint_name&gt;.
        /// </param>
        /// <param name="runId">
        /// Loops run whose sampler will load the checkpoint. The checkpoint must use the run's LoRA config.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidateLoopsCheckpointRequestV1(
            string checkpointPath,
            string? runId)
        {
            this.CheckpointPath = checkpointPath ?? throw new global::System.ArgumentNullException(nameof(checkpointPath));
            this.RunId = runId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateLoopsCheckpointRequestV1" /> class.
        /// </summary>
        public ValidateLoopsCheckpointRequestV1()
        {
        }

    }
}