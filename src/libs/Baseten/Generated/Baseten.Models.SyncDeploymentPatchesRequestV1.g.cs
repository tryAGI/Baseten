
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Triggers a sync of any staged patches to the running deployment. Takes no<br/>
    /// fields: the deployment and its staged patches fully determine the sync.
    /// </summary>
    public sealed partial class SyncDeploymentPatchesRequestV1
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}