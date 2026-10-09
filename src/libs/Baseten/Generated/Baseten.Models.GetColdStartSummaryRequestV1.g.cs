
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Query params for a cold start summary request (a deployment or an environment).
    /// </summary>
    public sealed partial class GetColdStartSummaryRequestV1
    {
        /// <summary>
        /// Start of the query window, in epoch milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_epoch_millis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long StartEpochMillis { get; set; }

        /// <summary>
        /// End of the query window, in epoch milliseconds. Must be after the start.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_epoch_millis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long EndEpochMillis { get; set; }

        /// <summary>
        /// Only include cold starts that lasted at least this many milliseconds.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_duration_ms")]
        public int? MinDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetColdStartSummaryRequestV1" /> class.
        /// </summary>
        /// <param name="startEpochMillis">
        /// Start of the query window, in epoch milliseconds.
        /// </param>
        /// <param name="endEpochMillis">
        /// End of the query window, in epoch milliseconds. Must be after the start.
        /// </param>
        /// <param name="minDurationMs">
        /// Only include cold starts that lasted at least this many milliseconds.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetColdStartSummaryRequestV1(
            long startEpochMillis,
            long endEpochMillis,
            int? minDurationMs)
        {
            this.StartEpochMillis = startEpochMillis;
            this.EndEpochMillis = endEpochMillis;
            this.MinDurationMs = minDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetColdStartSummaryRequestV1" /> class.
        /// </summary>
        public GetColdStartSummaryRequestV1()
        {
        }

    }
}