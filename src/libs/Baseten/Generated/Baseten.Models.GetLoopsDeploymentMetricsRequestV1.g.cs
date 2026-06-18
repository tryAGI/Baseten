
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Time-range request for trainer deployment metrics.
    /// </summary>
    public sealed partial class GetLoopsDeploymentMetricsRequestV1
    {
        /// <summary>
        /// Epoch millis to end fetching metrics.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_epoch_millis")]
        public int? EndEpochMillis { get; set; }

        /// <summary>
        /// Epoch millis to start fetching metrics.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_epoch_millis")]
        public int? StartEpochMillis { get; set; }

        /// <summary>
        /// Resolution of the returned series, in seconds. When omitted, a step is derived from the time range so large windows return fewer points.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_seconds")]
        public int? StepSeconds { get; set; }

        /// <summary>
        /// Unit of time for request-volume metrics, in seconds (e.g. 60 for requests/minute). Defaults to per-second.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_divisor_seconds")]
        public int? TimeDivisorSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsDeploymentMetricsRequestV1" /> class.
        /// </summary>
        /// <param name="endEpochMillis">
        /// Epoch millis to end fetching metrics.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="startEpochMillis">
        /// Epoch millis to start fetching metrics.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="stepSeconds">
        /// Resolution of the returned series, in seconds. When omitted, a step is derived from the time range so large windows return fewer points.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="timeDivisorSeconds">
        /// Unit of time for request-volume metrics, in seconds (e.g. 60 for requests/minute). Defaults to per-second.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLoopsDeploymentMetricsRequestV1(
            int? endEpochMillis,
            int? startEpochMillis,
            int? stepSeconds,
            int? timeDivisorSeconds)
        {
            this.EndEpochMillis = endEpochMillis;
            this.StartEpochMillis = startEpochMillis;
            this.StepSeconds = stepSeconds;
            this.TimeDivisorSeconds = timeDivisorSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsDeploymentMetricsRequestV1" /> class.
        /// </summary>
        public GetLoopsDeploymentMetricsRequestV1()
        {
        }

    }
}