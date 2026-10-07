
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Named secret values for this routing rule, referenced in headers/body via {{SECRET:name}}. Stored encrypted at rest. Write-only: never returned in API responses.<br/>
    /// Included only in requests<br/>
    /// Example: {"openai-key":"sk-proj-demo-not-a-valid-api-key"}
    /// </summary>
    public sealed partial class SandboxProxyTargetV1Secrets
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}