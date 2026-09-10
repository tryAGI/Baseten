
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelApisCostsRequestV1
    {
        /// <summary>
        /// Opaque cursor returned by a previous page. Omit to fetch the first page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Number of daily cost buckets to return. Defaults to 7; maximum 31.<br/>
        /// Default Value: 7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Inclusive UTC calendar day at the start of the query range. Defaults to the previous UTC date, cannot be before 2026-08-05, and is ignored when you pass a cursor.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Exclusive UTC calendar day at the end of the query range. Defaults to the day after the current UTC date so current-day usage is included. The date range cannot exceed 90 days.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Dimensions to break costs down by, repeated once per dimension: api_key_prefix, user, model, or service_tier. Each result represents one observed combination of the requested dimensions within that day. For example, grouping by api_key_prefix and user returns each API-key and user pair that had usage. Combinations without usage are omitted, so result counts can differ between days. Omit for daily organization totals.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<global::Baseten.ModelApiCostDimensionV1>? GroupBy { get; set; }

        /// <summary>
        /// Return only costs for these exact API key prefixes, repeated once per prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_prefixes")]
        public global::System.Collections.Generic.IList<string>? ApiKeyPrefixes { get; set; }

        /// <summary>
        /// Return only costs attributed to these exact user IDs, repeated once per ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        public global::System.Collections.Generic.IList<string>? UserIds { get; set; }

        /// <summary>
        /// Return only costs for these exact model identifiers, repeated once per model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Return only costs for these exact service tiers, repeated once per tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tiers")]
        public global::System.Collections.Generic.IList<string>? ServiceTiers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelApisCostsRequestV1" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Opaque cursor returned by a previous page. Omit to fetch the first page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Number of daily cost buckets to return. Defaults to 7; maximum 31.<br/>
        /// Default Value: 7
        /// </param>
        /// <param name="startDate">
        /// Inclusive UTC calendar day at the start of the query range. Defaults to the previous UTC date, cannot be before 2026-08-05, and is ignored when you pass a cursor.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endDate">
        /// Exclusive UTC calendar day at the end of the query range. Defaults to the day after the current UTC date so current-day usage is included. The date range cannot exceed 90 days.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to break costs down by, repeated once per dimension: api_key_prefix, user, model, or service_tier. Each result represents one observed combination of the requested dimensions within that day. For example, grouping by api_key_prefix and user returns each API-key and user pair that had usage. Combinations without usage are omitted, so result counts can differ between days. Omit for daily organization totals.
        /// </param>
        /// <param name="apiKeyPrefixes">
        /// Return only costs for these exact API key prefixes, repeated once per prefix.
        /// </param>
        /// <param name="userIds">
        /// Return only costs attributed to these exact user IDs, repeated once per ID.
        /// </param>
        /// <param name="models">
        /// Return only costs for these exact model identifiers, repeated once per model.
        /// </param>
        /// <param name="serviceTiers">
        /// Return only costs for these exact service tiers, repeated once per tier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelApisCostsRequestV1(
            string? cursor,
            int? limit,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            global::System.Collections.Generic.IList<global::Baseten.ModelApiCostDimensionV1>? groupBy,
            global::System.Collections.Generic.IList<string>? apiKeyPrefixes,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<string>? serviceTiers)
        {
            this.Cursor = cursor;
            this.Limit = limit;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.GroupBy = groupBy;
            this.ApiKeyPrefixes = apiKeyPrefixes;
            this.UserIds = userIds;
            this.Models = models;
            this.ServiceTiers = serviceTiers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelApisCostsRequestV1" /> class.
        /// </summary>
        public ModelApisCostsRequestV1()
        {
        }

    }
}