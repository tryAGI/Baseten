
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EmbeddingBenchmarkMetricsV1
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("e2e_latency_ms_p50")]
        public double? E2eLatencyMsP50 { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("e2e_latency_ms_p99")]
        public double? E2eLatencyMsP99 { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_per_sec")]
        public double? InputTokensPerSec { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests_per_sec")]
        public double? RequestsPerSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingBenchmarkMetricsV1" /> class.
        /// </summary>
        /// <param name="e2eLatencyMsP50">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="e2eLatencyMsP99">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="inputTokensPerSec">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestsPerSec">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingBenchmarkMetricsV1(
            double? e2eLatencyMsP50,
            double? e2eLatencyMsP99,
            double? inputTokensPerSec,
            double? requestsPerSec)
        {
            this.E2eLatencyMsP50 = e2eLatencyMsP50;
            this.E2eLatencyMsP99 = e2eLatencyMsP99;
            this.InputTokensPerSec = inputTokensPerSec;
            this.RequestsPerSec = requestsPerSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingBenchmarkMetricsV1" /> class.
        /// </summary>
        public EmbeddingBenchmarkMetricsV1()
        {
        }

    }
}