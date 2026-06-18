
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to fetch deployment logs.
    /// </summary>
    public sealed partial class GetDeploymentLogsRequestV1
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
        /// Only return logs emitted by this replica (5-char short ID).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica")]
        public string? Replica { get; set; }

        /// <summary>
        /// Only return logs tagged with this inference request ID.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Only return logs from this component.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("component")]
        public string? Component { get; set; }

        /// <summary>
        /// RE2 regular expression matched against the log message. Prefer `includes` and `excludes` for plain substring matches.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_pattern")]
        public string? SearchPattern { get; set; }

        /// <summary>
        /// Case-sensitive substrings that must all appear in the log message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includes")]
        public global::System.Collections.Generic.IList<string>? Includes { get; set; }

        /// <summary>
        /// Case-sensitive substrings; lines containing any of these are dropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludes")]
        public global::System.Collections.Generic.IList<string>? Excludes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentLogsRequestV1" /> class.
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
        /// <param name="replica">
        /// Only return logs emitted by this replica (5-char short ID).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestId">
        /// Only return logs tagged with this inference request ID.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="component">
        /// Only return logs from this component.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="searchPattern">
        /// RE2 regular expression matched against the log message. Prefer `includes` and `excludes` for plain substring matches.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="includes">
        /// Case-sensitive substrings that must all appear in the log message.
        /// </param>
        /// <param name="excludes">
        /// Case-sensitive substrings; lines containing any of these are dropped.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentLogsRequestV1(
            long? startEpochMillis,
            long? endEpochMillis,
            global::Baseten.SortOrderV1? direction,
            int? limit,
            global::Baseten.LogLevelV1? minLevel,
            string? replica,
            string? requestId,
            string? component,
            string? searchPattern,
            global::System.Collections.Generic.IList<string>? includes,
            global::System.Collections.Generic.IList<string>? excludes)
        {
            this.StartEpochMillis = startEpochMillis;
            this.EndEpochMillis = endEpochMillis;
            this.Direction = direction;
            this.Limit = limit;
            this.MinLevel = minLevel;
            this.Replica = replica;
            this.RequestId = requestId;
            this.Component = component;
            this.SearchPattern = searchPattern;
            this.Includes = includes;
            this.Excludes = excludes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentLogsRequestV1" /> class.
        /// </summary>
        public GetDeploymentLogsRequestV1()
        {
        }

    }
}