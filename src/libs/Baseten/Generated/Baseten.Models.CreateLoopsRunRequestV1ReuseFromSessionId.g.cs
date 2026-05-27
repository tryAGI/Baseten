
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Optional Loops session ID whose trainer deployment should be reused for this run, sharing the infrastructure across sessions instead of provisioning fresh. The named session must belong to the same team. Reuse is best-effort: if the prior deployment is stopped, failed, or its sampler is unhealthy, a new deployment is provisioned instead.<br/>
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