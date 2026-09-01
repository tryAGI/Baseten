
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TTSBenchmarkMetricsV1
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttft_ms_p50")]
        public double? TtftMsP50 { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_streams_at_rtf1")]
        public int? MaxConcurrentStreamsAtRtf1 { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttft_ms_p50_at_max_concurrency")]
        public double? TtftMsP50AtMaxConcurrency { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_audio_minute_usd")]
        public double? CostPerAudioMinuteUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSBenchmarkMetricsV1" /> class.
        /// </summary>
        /// <param name="ttftMsP50">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="maxConcurrentStreamsAtRtf1">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="ttftMsP50AtMaxConcurrency">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="costPerAudioMinuteUsd">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TTSBenchmarkMetricsV1(
            double? ttftMsP50,
            int? maxConcurrentStreamsAtRtf1,
            double? ttftMsP50AtMaxConcurrency,
            double? costPerAudioMinuteUsd)
        {
            this.TtftMsP50 = ttftMsP50;
            this.MaxConcurrentStreamsAtRtf1 = maxConcurrentStreamsAtRtf1;
            this.TtftMsP50AtMaxConcurrency = ttftMsP50AtMaxConcurrency;
            this.CostPerAudioMinuteUsd = costPerAudioMinuteUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TTSBenchmarkMetricsV1" /> class.
        /// </summary>
        public TTSBenchmarkMetricsV1()
        {
        }

    }
}