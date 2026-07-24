
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Optional ID of a prior Loops run whose trainer and/or sampler should be reused for this run instead of provisioning fresh. The prior run must use the same base model and belong to the same team.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class CreateLoopsRunRequestV1ReuseFromRunId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}