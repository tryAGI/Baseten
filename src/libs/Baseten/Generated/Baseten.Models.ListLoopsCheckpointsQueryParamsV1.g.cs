
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Query-string filters for ``GET /v1/loops/checkpoints``.<br/>
    /// Provide exactly one of ``run_id`` (all checkpoints for the run),<br/>
    /// ``base_model`` (all checkpoints across the caller's runs of that<br/>
    /// base model), or ``checkpoint_path`` (the single matching checkpoint).
    /// </summary>
    public sealed partial class ListLoopsCheckpointsQueryParamsV1
    {
        /// <summary>
        /// Filter by run ID. Returns all checkpoints saved by the run.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// Filter by base model. Returns checkpoints across the caller's runs of this base model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// bt:// URI of a Loops checkpoint. Form: bt://loops:&lt;run_id&gt;/(weights|sampler_weights)/&lt;checkpoint_name&gt;.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint_path")]
        public string? CheckpointPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopsCheckpointsQueryParamsV1" /> class.
        /// </summary>
        /// <param name="runId">
        /// Filter by run ID. Returns all checkpoints saved by the run.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="baseModel">
        /// Filter by base model. Returns checkpoints across the caller's runs of this base model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="checkpointPath">
        /// bt:// URI of a Loops checkpoint. Form: bt://loops:&lt;run_id&gt;/(weights|sampler_weights)/&lt;checkpoint_name&gt;.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListLoopsCheckpointsQueryParamsV1(
            string? runId,
            string? baseModel,
            string? checkpointPath)
        {
            this.RunId = runId;
            this.BaseModel = baseModel;
            this.CheckpointPath = checkpointPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopsCheckpointsQueryParamsV1" /> class.
        /// </summary>
        public ListLoopsCheckpointsQueryParamsV1()
        {
        }

    }
}