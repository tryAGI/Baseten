
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Map of every non-ignored source path, relative and forward-slash, to its content hash: files map to the hex blake3 digest of their bytes, directories map to null. This is the full signature of the source tree and what the content hash is derived from.
    /// </summary>
    public sealed partial class DeploymentPatchPointV1ContentHashes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}