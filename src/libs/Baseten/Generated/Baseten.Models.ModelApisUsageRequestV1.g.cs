
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelApisUsageRequestV1
    {
        /// <summary>
        /// Start of the query range (ISO 8601, UTC), inclusive. Snapped down to the start of its bucket. Required on the first page, and ignored when you pass a cursor.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// End of the query range (ISO 8601, UTC), exclusive. Defaults to the current time.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Width of each time bucket: 1m, 1h, or 1d. Defaults to 1d.<br/>
        /// Default Value: 1d
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_width")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.BucketWidthJsonConverter))]
        public global::Baseten.BucketWidth? BucketWidth { get; set; }

        /// <summary>
        /// Dimensions to break usage down by, repeated once per dimension: api_key, model, service_tier. Defaults to model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<global::Baseten.UsageDimension>? GroupBy { get; set; }

        /// <summary>
        /// Return only usage for these API key prefixes, repeated once per prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_keys")]
        public global::System.Collections.Generic.IList<string>? ApiKeys { get; set; }

        /// <summary>
        /// Return only usage for these models, repeated once per model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Return only usage for these service tiers, repeated once per tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tiers")]
        public global::System.Collections.Generic.IList<string>? ServiceTiers { get; set; }

        /// <summary>
        /// Number of time buckets to return. Defaults and maximums depend on bucket_width: 1d defaults to 7 and allows 31, 1h defaults to 24 and allows 168, 1m defaults to 60 and allows 1440.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Opaque cursor from the pagination.cursor field of a previous response<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelApisUsageRequestV1" /> class.
        /// </summary>
        /// <param name="startTime">
        /// Start of the query range (ISO 8601, UTC), inclusive. Snapped down to the start of its bucket. Required on the first page, and ignored when you pass a cursor.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endTime">
        /// End of the query range (ISO 8601, UTC), exclusive. Defaults to the current time.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="bucketWidth">
        /// Width of each time bucket: 1m, 1h, or 1d. Defaults to 1d.<br/>
        /// Default Value: 1d
        /// </param>
        /// <param name="groupBy">
        /// Dimensions to break usage down by, repeated once per dimension: api_key, model, service_tier. Defaults to model.
        /// </param>
        /// <param name="apiKeys">
        /// Return only usage for these API key prefixes, repeated once per prefix.
        /// </param>
        /// <param name="models">
        /// Return only usage for these models, repeated once per model.
        /// </param>
        /// <param name="serviceTiers">
        /// Return only usage for these service tiers, repeated once per tier.
        /// </param>
        /// <param name="limit">
        /// Number of time buckets to return. Defaults and maximums depend on bucket_width: 1d defaults to 7 and allows 31, 1h defaults to 24 and allows 168, 1m defaults to 60 and allows 1440.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cursor">
        /// Opaque cursor from the pagination.cursor field of a previous response<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelApisUsageRequestV1(
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            global::Baseten.BucketWidth? bucketWidth,
            global::System.Collections.Generic.IList<global::Baseten.UsageDimension>? groupBy,
            global::System.Collections.Generic.IList<string>? apiKeys,
            global::System.Collections.Generic.IList<string>? models,
            global::System.Collections.Generic.IList<string>? serviceTiers,
            int? limit,
            string? cursor)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.BucketWidth = bucketWidth;
            this.GroupBy = groupBy;
            this.ApiKeys = apiKeys;
            this.Models = models;
            this.ServiceTiers = serviceTiers;
            this.Limit = limit;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelApisUsageRequestV1" /> class.
        /// </summary>
        public ModelApisUsageRequestV1()
        {
        }

    }
}