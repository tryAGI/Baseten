
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Ordered list of GPU types for sampler deployments, highest priority first. Send a list to set; send null to clear (inherit org allowlist); omit to leave unchanged. Empty list is rejected.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class PatchLoopsUserConfigRequestV1SamplerAcceleratorPriority
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}