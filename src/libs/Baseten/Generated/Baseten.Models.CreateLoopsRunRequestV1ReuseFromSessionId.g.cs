
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Optional ID of a prior Loops session whose trainer and/or sampler should be reused for this run. Deprecated in favor of reuse_from_run_id.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class CreateLoopsRunRequestV1ReuseFromSessionId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}