
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to fetch training logs.
    /// </summary>
    public sealed partial class GetTrainingJobLogsRequestV1
    {
        /// <summary>
        /// Epoch millis timestamp to start fetching logs<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_epoch_millis")]
        public int? StartEpochMillis { get; set; }

        /// <summary>
        /// Epoch millis timestamp to end fetching logs<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_epoch_millis")]
        public int? EndEpochMillis { get; set; }

        /// <summary>
        /// Sort order for logs<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        public global::Baseten.SortOrderV1? Direction { get; set; }

        /// <summary>
        /// Limit of logs to fetch in a single request<br/>
        /// Default Value: 500
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingJobLogsRequestV1" /> class.
        /// </summary>
        /// <param name="startEpochMillis">
        /// Epoch millis timestamp to start fetching logs<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endEpochMillis">
        /// Epoch millis timestamp to end fetching logs<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="direction">
        /// Sort order for logs<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Limit of logs to fetch in a single request<br/>
        /// Default Value: 500
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrainingJobLogsRequestV1(
            int? startEpochMillis,
            int? endEpochMillis,
            global::Baseten.SortOrderV1? direction,
            int? limit)
        {
            this.StartEpochMillis = startEpochMillis;
            this.EndEpochMillis = endEpochMillis;
            this.Direction = direction;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingJobLogsRequestV1" /> class.
        /// </summary>
        public GetTrainingJobLogsRequestV1()
        {
        }
    }
}