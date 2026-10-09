
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Query params for a cold start attempts request (a deployment or an environment).
    /// </summary>
    public sealed partial class GetColdStartAttemptsRequestV1
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
        /// Opaque cursor returned by a previous page. Omit to fetch the first page. Pass the same filters and sort as the request that returned it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Maximum number of attempts to return.<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Only include attempts with one of these outcomes. Repeat to pass several.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcomes")]
        public global::System.Collections.Generic.IList<global::Baseten.ColdStartOutcomeV1>? Outcomes { get; set; }

        /// <summary>
        /// Only include attempts that spent longer than 0 ms in this phase.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        public global::Baseten.ColdStartPhaseV1? Phase { get; set; }

        /// <summary>
        /// Only include attempts whose replica ID matches exactly, or whose deployment name contains this text (case-insensitive).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public string? Search { get; set; }

        /// <summary>
        /// Field to sort attempts by. Defaults to `STARTED_AT`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_by")]
        public global::Baseten.ColdStartSortFieldV1? SortBy { get; set; }

        /// <summary>
        /// Sort direction. Defaults to `desc`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        public global::Baseten.SortOrderV1? Direction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetColdStartAttemptsRequestV1" /> class.
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
        /// <param name="cursor">
        /// Opaque cursor returned by a previous page. Omit to fetch the first page. Pass the same filters and sort as the request that returned it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Maximum number of attempts to return.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="outcomes">
        /// Only include attempts with one of these outcomes. Repeat to pass several.
        /// </param>
        /// <param name="phase">
        /// Only include attempts that spent longer than 0 ms in this phase.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="search">
        /// Only include attempts whose replica ID matches exactly, or whose deployment name contains this text (case-insensitive).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="sortBy">
        /// Field to sort attempts by. Defaults to `STARTED_AT`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="direction">
        /// Sort direction. Defaults to `desc`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetColdStartAttemptsRequestV1(
            long startEpochMillis,
            long endEpochMillis,
            int? minDurationMs,
            string? cursor,
            int? limit,
            global::System.Collections.Generic.IList<global::Baseten.ColdStartOutcomeV1>? outcomes,
            global::Baseten.ColdStartPhaseV1? phase,
            string? search,
            global::Baseten.ColdStartSortFieldV1? sortBy,
            global::Baseten.SortOrderV1? direction)
        {
            this.StartEpochMillis = startEpochMillis;
            this.EndEpochMillis = endEpochMillis;
            this.MinDurationMs = minDurationMs;
            this.Cursor = cursor;
            this.Limit = limit;
            this.Outcomes = outcomes;
            this.Phase = phase;
            this.Search = search;
            this.SortBy = sortBy;
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetColdStartAttemptsRequestV1" /> class.
        /// </summary>
        public GetColdStartAttemptsRequestV1()
        {
        }

    }
}