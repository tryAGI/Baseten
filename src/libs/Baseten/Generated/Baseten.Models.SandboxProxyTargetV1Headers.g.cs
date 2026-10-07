
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Headers to inject into matching requests. Values may contain {{SECRET:name}} references resolved from this rule's secrets.<br/>
    /// Example: {"Authorization":"Bearer {{SECRET:openai-key}}"}
    /// </summary>
    public sealed partial class SandboxProxyTargetV1Headers
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}