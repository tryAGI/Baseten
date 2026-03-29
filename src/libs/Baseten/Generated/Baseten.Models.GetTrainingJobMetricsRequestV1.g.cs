
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to fetch metrics. Allows the user to request metrics over a period of time.
    /// </summary>
    public sealed partial class GetTrainingJobMetricsRequestV1
    {
        /// <summary>
        /// Epoch millis timestamp to end fetching metrics<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_epoch_millis")]
        public int? EndEpochMillis { get; set; }

        /// <summary>
        /// Epoch millis timestamp to start fetching metrics.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_epoch_millis")]
        public int? StartEpochMillis { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingJobMetricsRequestV1" /> class.
        /// </summary>
        /// <param name="endEpochMillis">
        /// Epoch millis timestamp to end fetching metrics<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="startEpochMillis">
        /// Epoch millis timestamp to start fetching metrics.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrainingJobMetricsRequestV1(
            int? endEpochMillis,
            int? startEpochMillis)
        {
            this.EndEpochMillis = endEpochMillis;
            this.StartEpochMillis = startEpochMillis;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingJobMetricsRequestV1" /> class.
        /// </summary>
        public GetTrainingJobMetricsRequestV1()
        {
        }
    }
}