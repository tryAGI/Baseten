
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A distribution of cold start durations.<br/>
    /// Statistics cover only samples longer than 0 ms and are null when there are none.
    /// </summary>
    public sealed partial class ColdStartPercentilesV1
    {
        /// <summary>
        /// Number of cold starts in the distribution, including those that took 0 ms. A phase that finishes within a second can record 0 ms.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleCount { get; set; }

        /// <summary>
        /// Mean duration, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mean_ms")]
        public int? MeanMs { get; set; }

        /// <summary>
        /// 50th percentile duration, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50_ms")]
        public int? P50Ms { get; set; }

        /// <summary>
        /// 90th percentile duration, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90_ms")]
        public int? P90Ms { get; set; }

        /// <summary>
        /// 95th percentile duration, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95_ms")]
        public int? P95Ms { get; set; }

        /// <summary>
        /// 99th percentile duration, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p99_ms")]
        public int? P99Ms { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColdStartPercentilesV1" /> class.
        /// </summary>
        /// <param name="sampleCount">
        /// Number of cold starts in the distribution, including those that took 0 ms. A phase that finishes within a second can record 0 ms.
        /// </param>
        /// <param name="meanMs">
        /// Mean duration, in milliseconds.
        /// </param>
        /// <param name="p50Ms">
        /// 50th percentile duration, in milliseconds.
        /// </param>
        /// <param name="p90Ms">
        /// 90th percentile duration, in milliseconds.
        /// </param>
        /// <param name="p95Ms">
        /// 95th percentile duration, in milliseconds.
        /// </param>
        /// <param name="p99Ms">
        /// 99th percentile duration, in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColdStartPercentilesV1(
            int sampleCount,
            int? meanMs,
            int? p50Ms,
            int? p90Ms,
            int? p95Ms,
            int? p99Ms)
        {
            this.SampleCount = sampleCount;
            this.MeanMs = meanMs;
            this.P50Ms = p50Ms;
            this.P90Ms = p90Ms;
            this.P95Ms = p95Ms;
            this.P99Ms = p99Ms;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColdStartPercentilesV1" /> class.
        /// </summary>
        public ColdStartPercentilesV1()
        {
        }

    }
}