
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LLMBenchmarkMetricsV1
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttft_ms_p50")]
        public double? TtftMsP50 { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_per_sec_per_user_p50")]
        public double? OutputTokensPerSecPerUserP50 { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_users_at_50ms_tpot")]
        public int? MaxConcurrentUsersAt50msTpot { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests_per_sec_p50")]
        public double? RequestsPerSecP50 { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_1m_tokens_usd")]
        public double? CostPer1mTokensUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMBenchmarkMetricsV1" /> class.
        /// </summary>
        /// <param name="ttftMsP50">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="outputTokensPerSecPerUserP50">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="maxConcurrentUsersAt50msTpot">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestsPerSecP50">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="costPer1mTokensUsd">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMBenchmarkMetricsV1(
            double? ttftMsP50,
            double? outputTokensPerSecPerUserP50,
            int? maxConcurrentUsersAt50msTpot,
            double? requestsPerSecP50,
            double? costPer1mTokensUsd)
        {
            this.TtftMsP50 = ttftMsP50;
            this.OutputTokensPerSecPerUserP50 = outputTokensPerSecPerUserP50;
            this.MaxConcurrentUsersAt50msTpot = maxConcurrentUsersAt50msTpot;
            this.RequestsPerSecP50 = requestsPerSecP50;
            this.CostPer1mTokensUsd = costPer1mTokensUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMBenchmarkMetricsV1" /> class.
        /// </summary>
        public LLMBenchmarkMetricsV1()
        {
        }

    }
}