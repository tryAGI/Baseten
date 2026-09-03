
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Version that the reserved `head` tag points at, which a reference with no tag or digest resolves to. Null when the volume has no head, or when your API key cannot read it.
    /// </summary>
    public sealed partial class VolumeV1Head
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}