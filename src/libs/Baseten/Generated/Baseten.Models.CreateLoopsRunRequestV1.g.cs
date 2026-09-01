
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
        /// Optional display name for the run. Defaults to the base model name when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// Seconds of inactivity before the run scales to zero. Must be between 1 and 3600 (1 hour). Defaults to 900 (15 minutes).<br/>
        /// Default Value: 900
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_down_delay_seconds")]
        public int? ScaleDownDelaySeconds { get; set; }

        /// <summary>
        /// Capacity the trainer runs on. 'dedicated' is not preempted. 'spot' runs below inference and reaches idle reserved capacity, but the run is stopped if its GPUs are reclaimed and cannot be resumed.<br/>
        /// Default Value: dedicated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("availability_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.V1AvailabilityModelJsonConverter))]
        public global::Baseten.V1AvailabilityModel? AvailabilityModel { get; set; }

        /// <summary>
        /// Number of data-parallel trainer replicas. Each replica is one full copy of the model's preset node group, so the trainer deployment runs (preset node_count * replicas) nodes (e.g. replicas=4 on a 4-node preset → 16 nodes, 4 DP workers). Must be a positive integer. Defaults to 1.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        public int? Replicas { get; set; }

        /// <summary>
        /// Optional bt:// URI of an existing checkpoint to load weights from on startup. Form: bt://loops:&lt;run_id&gt;/weights/&lt;checkpoint_name&gt;.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Optional ID of a prior Loops run whose trainer and/or sampler should be reused for this run instead of provisioning fresh. The prior run must use the same base model and belong to the same team.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reuse_from_run_id")]
        public string? ReuseFromRunId { get; set; }

        /// <summary>
        /// Optional ID of a prior Loops session whose trainer and/or sampler should be reused for this run. Deprecated in favor of reuse_from_run_id.<br/>
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
        /// Initializes a new instance of the <see cref="CreateLoopsRunRequestV1" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// ID of the Loops session this run belongs to.
        /// </param>
        /// <param name="baseModel">
        /// Base model ID (e.g. 'Qwen/Qwen3-8B').
        /// </param>
        /// <param name="name">
        /// Optional display name for the run. Defaults to the base model name when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
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
        /// Seconds of inactivity before the run scales to zero. Must be between 1 and 3600 (1 hour). Defaults to 900 (15 minutes).<br/>
        /// Default Value: 900
        /// </param>
        /// <param name="availabilityModel">
        /// Capacity the trainer runs on. 'dedicated' is not preempted. 'spot' runs below inference and reaches idle reserved capacity, but the run is stopped if its GPUs are reclaimed and cannot be resumed.<br/>
        /// Default Value: dedicated
        /// </param>
        /// <param name="replicas">
        /// Number of data-parallel trainer replicas. Each replica is one full copy of the model's preset node group, so the trainer deployment runs (preset node_count * replicas) nodes (e.g. replicas=4 on a 4-node preset → 16 nodes, 4 DP workers). Must be a positive integer. Defaults to 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="path">
        /// Optional bt:// URI of an existing checkpoint to load weights from on startup. Form: bt://loops:&lt;run_id&gt;/weights/&lt;checkpoint_name&gt;.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="reuseFromRunId">
        /// Optional ID of a prior Loops run whose trainer and/or sampler should be reused for this run instead of provisioning fresh. The prior run must use the same base model and belong to the same team.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="reuseFromSessionId">
        /// Optional ID of a prior Loops session whose trainer and/or sampler should be reused for this run. Deprecated in favor of reuse_from_run_id.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLoopsRunRequestV1(
            string sessionId,
            string baseModel,
            string? name,
            int? maxSeqLen,
            int? loraRank,
            int? seed,
            int? scaleDownDelaySeconds,
            global::Baseten.V1AvailabilityModel? availabilityModel,
            int? replicas,
            string? path,
            string? reuseFromRunId,
            string? reuseFromSessionId)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.BaseModel = baseModel ?? throw new global::System.ArgumentNullException(nameof(baseModel));
            this.Name = name;
            this.MaxSeqLen = maxSeqLen;
            this.LoraRank = loraRank;
            this.Seed = seed;
            this.ScaleDownDelaySeconds = scaleDownDelaySeconds;
            this.AvailabilityModel = availabilityModel;
            this.Replicas = replicas;
            this.Path = path;
            this.ReuseFromRunId = reuseFromRunId;
            this.ReuseFromSessionId = reuseFromSessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoopsRunRequestV1" /> class.
        /// </summary>
        public CreateLoopsRunRequestV1()
        {
        }

    }
}