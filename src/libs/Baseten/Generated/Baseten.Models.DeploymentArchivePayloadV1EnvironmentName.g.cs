
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Stable environment to push to (e.g. `production`). If unset, the deployment is created without environment selection. Caller must have push permission for the named environment.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class DeploymentArchivePayloadV1EnvironmentName
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}