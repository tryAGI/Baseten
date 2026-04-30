
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The original config.yaml text submitted by the client, preserving comments, ordering, and formatting. Null if not available.
    /// </summary>
    public sealed partial class DeploymentConfigResponseV1RawConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}