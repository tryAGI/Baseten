
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Query params for ``GET /v1/models/.../environments/.../metrics``.
    /// </summary>
    public sealed partial class GetEnvironmentMetricsRequestV1
    {
        /// <summary>
        /// 'CURRENT': a single instantaneous snapshot at now; start/end must be omitted. 'SUMMARY': a single value set aggregating the whole window. 'SERIES': evenly-spaced value sets across the window, with the step derived from the window duration.<br/>
        /// Default Value: CURRENT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.ModelMetricModeV1JsonConverter))]
        public global::Baseten.ModelMetricModeV1? Mode { get; set; }

        /// <summary>
        /// Epoch millis timestamp to start fetching metrics. Defaults to one hour before the end.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_epoch_millis")]
        public int? StartEpochMillis { get; set; }

        /// <summary>
        /// Epoch millis timestamp to end fetching metrics. Defaults to the current time. The window between start and end must not exceed 7 days.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_epoch_millis")]
        public int? EndEpochMillis { get; set; }

        /// <summary>
        /// Names of the metrics to return; see https://docs.baseten.co/observability/export-metrics/supported-metrics for the available names. When omitted, a default set is returned: baseten_replicas_active, baseten_inference_requests_total, and baseten_end_to_end_response_time_seconds. Unknown names are rejected; valid names that do not apply are omitted from the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        public global::System.Collections.Generic.IList<string>? Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEnvironmentMetricsRequestV1" /> class.
        /// </summary>
        /// <param name="mode">
        /// 'CURRENT': a single instantaneous snapshot at now; start/end must be omitted. 'SUMMARY': a single value set aggregating the whole window. 'SERIES': evenly-spaced value sets across the window, with the step derived from the window duration.<br/>
        /// Default Value: CURRENT
        /// </param>
        /// <param name="startEpochMillis">
        /// Epoch millis timestamp to start fetching metrics. Defaults to one hour before the end.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endEpochMillis">
        /// Epoch millis timestamp to end fetching metrics. Defaults to the current time. The window between start and end must not exceed 7 days.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metrics">
        /// Names of the metrics to return; see https://docs.baseten.co/observability/export-metrics/supported-metrics for the available names. When omitted, a default set is returned: baseten_replicas_active, baseten_inference_requests_total, and baseten_end_to_end_response_time_seconds. Unknown names are rejected; valid names that do not apply are omitted from the response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetEnvironmentMetricsRequestV1(
            global::Baseten.ModelMetricModeV1? mode,
            int? startEpochMillis,
            int? endEpochMillis,
            global::System.Collections.Generic.IList<string>? metrics)
        {
            this.Mode = mode;
            this.StartEpochMillis = startEpochMillis;
            this.EndEpochMillis = endEpochMillis;
            this.Metrics = metrics;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEnvironmentMetricsRequestV1" /> class.
        /// </summary>
        public GetEnvironmentMetricsRequestV1()
        {
        }

    }
}