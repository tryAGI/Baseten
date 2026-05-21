
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLoopsRunRequestV1
    {
        /// <summary>
        /// ID of the Loops session this run belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Base model ID (e.g. 'Qwen/Qwen3-8B').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseModel { get; set; }

        /// <summary>
        /// Maximum prompt length (in tokens) the run must handle. Set this to the longest training example you plan to send. Defaults to the maximum supported by the model configuration.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_seq_len")]
        public int? MaxSeqLen { get; set; }

        /// <summary>
        /// LoRA rank.<br/>
        /// Default Value: 64
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_rank")]
        public int? LoraRank { get; set; }

        /// <summary>
        /// Random seed for reproducibility.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Seconds of inactivity before the run scales to zero. Must be positive. Defaults to 3600 (1 hour).<br/>
        /// Default Value: 3600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_down_delay_seconds")]
        public int? ScaleDownDelaySeconds { get; set; }

        /// <summary>
        /// Optional bt:// URI of an existing checkpoint to load weights from on startup. Form: bt://loops:&lt;run_id&gt;/weights/&lt;checkpoint_name&gt;.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoopsRunRequestV1" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// ID of the Loops session this run belongs to.
        /// </param>
        /// <param name="baseModel">
        /// Base model ID (e.g. 'Qwen/Qwen3-8B').
        /// </param>
        /// <param name="maxSeqLen">
        /// Maximum prompt length (in tokens) the run must handle. Set this to the longest training example you plan to send. Defaults to the maximum supported by the model configuration.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="loraRank">
        /// LoRA rank.<br/>
        /// Default Value: 64
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="scaleDownDelaySeconds">
        /// Seconds of inactivity before the run scales to zero. Must be positive. Defaults to 3600 (1 hour).<br/>
        /// Default Value: 3600
        /// </param>
        /// <param name="path">
        /// Optional bt:// URI of an existing checkpoint to load weights from on startup. Form: bt://loops:&lt;run_id&gt;/weights/&lt;checkpoint_name&gt;.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLoopsRunRequestV1(
            string sessionId,
            string baseModel,
            int? maxSeqLen,
            int? loraRank,
            int? seed,
            int? scaleDownDelaySeconds,
            string? path)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.MaxSeqLen = maxSeqLen;
            this.LoraRank = loraRank;
            this.Seed = seed;
            this.ScaleDownDelaySeconds = scaleDownDelaySeconds;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoopsRunRequestV1" /> class.
        /// </summary>
        public CreateLoopsRunRequestV1()
        {
        }

    }
}