
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Query parameters for fetching a Loops deployment's logs.
    /// </summary>
    public sealed partial class GetLoopsDeploymentLogsRequestV1
    {
        /// <summary>
        /// Epoch milliseconds at which to start fetching logs. Defaults to 30 minutes before the end. The window from start to end must not exceed 7 days.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_epoch_millis")]
        public long? StartEpochMillis { get; set; }

        /// <summary>
        /// Epoch milliseconds at which to stop fetching logs. Defaults to the current time.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_epoch_millis")]
        public long? EndEpochMillis { get; set; }

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
        /// Minimum log severity to include. Omit to return all log lines, including lines that have no level. Any explicit value returns lines at or above that severity and drops lines without a level.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_level")]
        public global::Baseten.LogLevelV1? MinLevel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsDeploymentLogsRequestV1" /> class.
        /// </summary>
        /// <param name="startEpochMillis">
        /// Epoch milliseconds at which to start fetching logs. Defaults to 30 minutes before the end. The window from start to end must not exceed 7 days.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endEpochMillis">
        /// Epoch milliseconds at which to stop fetching logs. Defaults to the current time.<br/>
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
        /// <param name="minLevel">
        /// Minimum log severity to include. Omit to return all log lines, including lines that have no level. Any explicit value returns lines at or above that severity and drops lines without a level.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLoopsDeploymentLogsRequestV1(
            long? startEpochMillis,
            long? endEpochMillis,
            global::Baseten.SortOrderV1? direction,
            int? limit,
            global::Baseten.LogLevelV1? minLevel)
        {
            this.StartEpochMillis = startEpochMillis;
            this.EndEpochMillis = endEpochMillis;
            this.Direction = direction;
            this.Limit = limit;
            this.MinLevel = minLevel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsDeploymentLogsRequestV1" /> class.
        /// </summary>
        public GetLoopsDeploymentLogsRequestV1()
        {
        }

    }
}