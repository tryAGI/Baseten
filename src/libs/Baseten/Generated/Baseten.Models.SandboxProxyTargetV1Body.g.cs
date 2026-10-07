
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Body fields to inject into matching requests. Values may contain {{SECRET:name}} references resolved from this rule's secrets.<br/>
    /// Example: {"user":"baseten-api-review-0916"}
    /// </summary>
    public sealed partial class SandboxProxyTargetV1Body
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}