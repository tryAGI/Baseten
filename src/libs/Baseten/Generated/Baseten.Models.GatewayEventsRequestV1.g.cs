
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GatewayEventsRequestV1
    {
        /// <summary>
        /// Inclusive start (ISO 8601, UTC). Required without a cursor.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Exclusive end (ISO 8601, UTC). Defaults to now.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Max events. Default 100, max 1000.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Return only events for these API key prefixes, repeated once per prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_keys")]
        public global::System.Collections.Generic.IList<string>? ApiKeys { get; set; }

        /// <summary>
        /// Return only events for these external entity IDs, repeated once per ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_entity_ids")]
        public global::System.Collections.Generic.IList<string>? ExternalEntityIds { get; set; }

        /// <summary>
        /// Next-page cursor. Other parameters are ignored.<br/>
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
        /// Initializes a new instance of the <see cref="GatewayEventsRequestV1" /> class.
        /// </summary>
        /// <param name="startTime">
        /// Inclusive start (ISO 8601, UTC). Required without a cursor.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endTime">
        /// Exclusive end (ISO 8601, UTC). Defaults to now.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Max events. Default 100, max 1000.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="apiKeys">
        /// Return only events for these API key prefixes, repeated once per prefix.
        /// </param>
        /// <param name="externalEntityIds">
        /// Return only events for these external entity IDs, repeated once per ID.
        /// </param>
        /// <param name="cursor">
        /// Next-page cursor. Other parameters are ignored.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GatewayEventsRequestV1(
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            int? limit,
            global::System.Collections.Generic.IList<string>? apiKeys,
            global::System.Collections.Generic.IList<string>? externalEntityIds,
            string? cursor)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Limit = limit;
            this.ApiKeys = apiKeys;
            this.ExternalEntityIds = externalEntityIds;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayEventsRequestV1" /> class.
        /// </summary>
        public GatewayEventsRequestV1()
        {
        }

    }
}