
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Latency quantile datapoint.<br/>
    /// Values are reported in **milliseconds** to match the oracle/inference<br/>
    /// ``response_time_stats`` convention. Source histogram is the queue-proxy's<br/>
    /// ``revision_request_latencies_bucket`` whose bucket boundaries are in ms.
    /// </summary>
    public sealed partial class ResponseTimeDatapointV1
    {
        /// <summary>
        /// ISO 8601 timestamp.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 50th percentile request latency (milliseconds).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50")]
        public double? P50 { get; set; }

        /// <summary>
        /// 95th percentile request latency (milliseconds).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95")]
        public double? P95 { get; set; }

        /// <summary>
        /// 99th percentile request latency (milliseconds).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p99")]
        public double? P99 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTimeDatapointV1" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// ISO 8601 timestamp.
        /// </param>
        /// <param name="p50">
        /// 50th percentile request latency (milliseconds).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="p95">
        /// 95th percentile request latency (milliseconds).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="p99">
        /// 99th percentile request latency (milliseconds).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseTimeDatapointV1(
            global::System.DateTime timestamp,
            double? p50,
            double? p95,
            double? p99)
        {
            this.Timestamp = timestamp;
            this.P50 = p50;
            this.P95 = p95;
            this.P99 = p99;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTimeDatapointV1" /> class.
        /// </summary>
        public ResponseTimeDatapointV1()
        {
        }

    }
}