
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BenchmarkSnapshotV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measured_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime MeasuredAt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::Baseten.LLMBenchmarkMetricsV1? Llm { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tts")]
        public global::Baseten.TTSBenchmarkMetricsV1? Tts { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        public global::Baseten.EmbeddingBenchmarkMetricsV1? Embedding { get; set; }

        /// <summary>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        public int? Replicas { get; set; }

        /// <summary>
        /// Default Value: 512x256
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile")]
        public string? Profile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchmarkSnapshotV1" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="measuredAt"></param>
        /// <param name="llm">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tts">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="embedding">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="replicas">
        /// Default Value: 2
        /// </param>
        /// <param name="profile">
        /// Default Value: 512x256
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BenchmarkSnapshotV1(
            string runId,
            global::System.DateTime measuredAt,
            global::Baseten.LLMBenchmarkMetricsV1? llm,
            global::Baseten.TTSBenchmarkMetricsV1? tts,
            global::Baseten.EmbeddingBenchmarkMetricsV1? embedding,
            int? replicas,
            string? profile)
        {
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.MeasuredAt = measuredAt;
            this.Llm = llm;
            this.Tts = tts;
            this.Embedding = embedding;
            this.Replicas = replicas;
            this.Profile = profile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchmarkSnapshotV1" /> class.
        /// </summary>
        public BenchmarkSnapshotV1()
        {
        }

    }
}