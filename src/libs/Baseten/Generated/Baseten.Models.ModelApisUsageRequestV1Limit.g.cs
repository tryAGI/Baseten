
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Number of time buckets to return. Defaults and maximums depend on bucket_width: 1d defaults to 7 and allows 31, 1h defaults to 24 and allows 168, 1m defaults to 60 and allows 1440.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class ModelApisUsageRequestV1Limit
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}