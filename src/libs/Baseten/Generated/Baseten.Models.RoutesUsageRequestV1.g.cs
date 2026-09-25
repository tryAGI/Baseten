
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RoutesUsageRequestV1
    {
        /// <summary>
        /// Opaque cursor returned by a previous page. Omit to fetch the first page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Number of daily buckets to return. Defaults to 7; maximum 31.<br/>
        /// Default Value: 7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Inclusive UTC calendar day at the start of the query range. Defaults to the previous UTC date, and is ignored when you pass a cursor.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Exclusive UTC calendar day at the end of the query range. Defaults to the day after the current UTC date so current-day usage is included.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Dimensions to break usage down by, repeated once per dimension: API_KEY_PREFIX, USER, ROUTE, MODEL, or PROVIDER. Each result represents one observed combination of the requested dimensions within that day, and results are sorted by those values. Combinations without usage are omitted, so result counts can differ between days. Defaults to MODEL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<global::Baseten.RouteUsageDimensionV1>? GroupBy { get; set; }

        /// <summary>
        /// Return only usage for these exact Routes key prefixes, repeated once per prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_prefixes")]
        public global::System.Collections.Generic.IList<string>? ApiKeyPrefixes { get; set; }

        /// <summary>
        /// Return only usage from Routes keys created by these user IDs, repeated once per ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        public global::System.Collections.Generic.IList<string>? UserIds { get; set; }

        /// <summary>
        /// Return only usage for these route IDs, repeated once per ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route_ids")]
        public global::System.Collections.Generic.IList<string>? RouteIds { get; set; }

        /// <summary>
        /// Return only usage for these exact model names, repeated once per model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Return only usage for these providers, repeated once per provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        public global::System.Collections.Generic.IList<global::Baseten.RouteProviderV1>? Providers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesUsageRequestV1" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Opaque cursor returned by a previous page. Omit to fetch the first page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Number of daily buckets to return. Defaults to 7; maximum 31.<br/>
        /// Default Value: 7
        /// </param>
        /// <param name="startDate">
        /// Inclusive UTC calendar day at the start of the query range. Defaults to the previous UTC date, and is ignored when you pass a cursor.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endDate">
        /// Exclusive UTC calendar day at the end of the query range. Defaults to the day after the current UTC date so current-day usage is included.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to break usage down by, repeated once per dimension: API_KEY_PREFIX, USER, ROUTE, MODEL, or PROVIDER. Each result represents one observed combination of the requested dimensions within that day, and results are sorted by those values. Combinations without usage are omitted, so result counts can differ between days. Defaults to MODEL.
        /// </param>
        /// <param name="apiKeyPrefixes">
        /// Return only usage for these exact Routes key prefixes, repeated once per prefix.
        /// </param>
        /// <param name="userIds">
        /// Return only usage from Routes keys created by these user IDs, repeated once per ID.
        /// </param>
        /// <param name="routeIds">
        /// Return only usage for these route IDs, repeated once per ID.
        /// </param>
        /// <param name="models">
        /// Return only usage for these exact model names, repeated once per model.
        /// </param>
        /// <param name="providers">
        /// Return only usage for these providers, repeated once per provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoutesUsageRequestV1(
            string? cursor,
            int? limit,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            global::System.Collections.Generic.IList<global::Baseten.RouteUsageDimensionV1>? groupBy,
            global::System.Collections.Generic.IList<string>? apiKeyPrefixes,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? routeIds,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<global::Baseten.RouteProviderV1>? providers)
        {
            this.Cursor = cursor;
            this.Limit = limit;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.GroupBy = groupBy;
            this.ApiKeyPrefixes = apiKeyPrefixes;
            this.UserIds = userIds;
            this.RouteIds = routeIds;
            this.Models = models;
            this.Providers = providers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesUsageRequestV1" /> class.
        /// </summary>
        public RoutesUsageRequestV1()
        {
        }

    }
}