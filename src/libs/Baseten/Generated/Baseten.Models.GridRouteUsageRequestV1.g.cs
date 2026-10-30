
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GridRouteUsageRequestV1
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
        /// Limit usage to a team you can access. Organization admins can view all usage in the team, team admins can view usage in teams they manage, and other members can view only their own usage. Without a team, organization admins see all organization usage, team admins see their managed teams, and other members see their own usage.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

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
        /// Dimensions to break usage down by, repeated once per dimension: USER, TEAM, MODEL, PROVIDER, ROUTER, or HARNESS. Each result represents one observed combination of the requested dimensions within that day, and results are sorted by those values. Combinations without usage are omitted, so result counts can differ between days. ROUTER returns only usage sent through an intelligent router, one row per router, or per router and model with MODEL. Router rows repeat usage already counted in other groupings, so don't add them to model totals. HARNESS includes usage with no recorded harness as a null group. Defaults to MODEL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<global::Baseten.GridRouteUsageDimensionV1>? GroupBy { get; set; }

        /// <summary>
        /// Return only usage from Routes keys created by these user IDs, repeated once per ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        public global::System.Collections.Generic.IList<string>? UserIds { get; set; }

        /// <summary>
        /// Return only usage for these exact model names, repeated once per model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Return only usage for these providers, repeated once per provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providers")]
        public global::System.Collections.Generic.IList<global::Baseten.GridProviderV1>? Providers { get; set; }

        /// <summary>
        /// Return only usage for these harnesses, repeated once per harness. Omit to include all usage, including usage with no recorded harness.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harnesses")]
        public global::System.Collections.Generic.IList<global::Baseten.GridRouteUsageHarnessV1>? Harnesses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GridRouteUsageRequestV1" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Opaque cursor returned by a previous page. Omit to fetch the first page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Number of daily buckets to return. Defaults to 7; maximum 31.<br/>
        /// Default Value: 7
        /// </param>
        /// <param name="teamId">
        /// Limit usage to a team you can access. Organization admins can view all usage in the team, team admins can view usage in teams they manage, and other members can view only their own usage. Without a team, organization admins see all organization usage, team admins see their managed teams, and other members see their own usage.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
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
        /// Dimensions to break usage down by, repeated once per dimension: USER, TEAM, MODEL, PROVIDER, ROUTER, or HARNESS. Each result represents one observed combination of the requested dimensions within that day, and results are sorted by those values. Combinations without usage are omitted, so result counts can differ between days. ROUTER returns only usage sent through an intelligent router, one row per router, or per router and model with MODEL. Router rows repeat usage already counted in other groupings, so don't add them to model totals. HARNESS includes usage with no recorded harness as a null group. Defaults to MODEL.
        /// </param>
        /// <param name="userIds">
        /// Return only usage from Routes keys created by these user IDs, repeated once per ID.
        /// </param>
        /// <param name="models">
        /// Return only usage for these exact model names, repeated once per model.
        /// </param>
        /// <param name="providers">
        /// Return only usage for these providers, repeated once per provider.
        /// </param>
        /// <param name="harnesses">
        /// Return only usage for these harnesses, repeated once per harness. Omit to include all usage, including usage with no recorded harness.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GridRouteUsageRequestV1(
            string? cursor,
            int? limit,
            string? teamId,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            global::System.Collections.Generic.IList<global::Baseten.GridRouteUsageDimensionV1>? groupBy,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<global::Baseten.GridProviderV1>? providers,
            global::System.Collections.Generic.IList<global::Baseten.GridRouteUsageHarnessV1>? harnesses)
        {
            this.Cursor = cursor;
            this.Limit = limit;
            this.TeamId = teamId;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.GroupBy = groupBy;
            this.UserIds = userIds;
            this.Models = models;
            this.Providers = providers;
            this.Harnesses = harnesses;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridRouteUsageRequestV1" /> class.
        /// </summary>
        public GridRouteUsageRequestV1()
        {
        }

    }
}