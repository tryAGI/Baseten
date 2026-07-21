
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLoopsSamplerRequestV1
    {
        /// <summary>
        /// ID of the Loops session this sampler belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Base model ID for a standalone sampler (for example, a baseline). Required unless run_id is set, in which case the base model is inherited from the run.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        public string? BaseModel { get; set; }

        /// <summary>
        /// ID of an existing run to attach this sampler to. When set, the sampler is paired to the run and weight-syncs from its trainer, and base_model is inherited from the run. Omit to create a standalone sampler.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// Maximum prompt length (in tokens) the sampler must handle. Set this to the longest prompt you plan to send. Omit to use the default for the base model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_seq_length")]
        public int? MaxSeqLength { get; set; }

        /// <summary>
        /// Optional bt:// URI of an existing sampler-target checkpoint to load weights from on startup. Form: bt://loops:&lt;run_id&gt;/sampler_weights/&lt;checkpoint_name&gt;.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_path")]
        public string? ModelPath { get; set; }

        /// <summary>
        /// Optional Loops session ID to reuse infrastructure from. Best-effort.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reuse_from_session_id")]
        public string? ReuseFromSessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoopsSamplerRequestV1" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// ID of the Loops session this sampler belongs to.
        /// </param>
        /// <param name="baseModel">
        /// Base model ID for a standalone sampler (for example, a baseline). Required unless run_id is set, in which case the base model is inherited from the run.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="runId">
        /// ID of an existing run to attach this sampler to. When set, the sampler is paired to the run and weight-syncs from its trainer, and base_model is inherited from the run. Omit to create a standalone sampler.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="maxSeqLength">
        /// Maximum prompt length (in tokens) the sampler must handle. Set this to the longest prompt you plan to send. Omit to use the default for the base model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="modelPath">
        /// Optional bt:// URI of an existing sampler-target checkpoint to load weights from on startup. Form: bt://loops:&lt;run_id&gt;/sampler_weights/&lt;checkpoint_name&gt;.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="reuseFromSessionId">
        /// Optional Loops session ID to reuse infrastructure from. Best-effort.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLoopsSamplerRequestV1(
            string sessionId,
            string? baseModel,
            string? runId,
            int? maxSeqLength,
            string? modelPath,
            string? reuseFromSessionId)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.BaseModel = baseModel;
            this.RunId = runId;
            this.MaxSeqLength = maxSeqLength;
            this.ModelPath = modelPath;
            this.ReuseFromSessionId = reuseFromSessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoopsSamplerRequestV1" /> class.
        /// </summary>
        public CreateLoopsSamplerRequestV1()
        {
        }

    }
}