
#nullable enable

namespace Baseten
{
    /// <summary>
    /// If set, the change cannot be patched and a full push is required; the value explains why. If null, the deployment is now in sync.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class SyncDeploymentPatchesResponseV1NeedsFullDeployReason
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}