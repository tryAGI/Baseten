
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The ID of the run currently active on this deployment, if any. Null when the deployment's runs have been marked inactive (e.g. scale-to-zero) without a successor.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class LoopsDeploymentV1ActiveRunId
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}