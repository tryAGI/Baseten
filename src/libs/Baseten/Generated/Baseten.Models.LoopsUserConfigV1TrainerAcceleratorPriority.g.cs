
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Ordered allowlist of GPU types for your Loops trainer deployments, highest priority first. Intersected with the org-level allowlist (org acts as a ceiling). Null means 'inherit the org-level allowlist'.
    /// </summary>
    public sealed partial class LoopsUserConfigV1TrainerAcceleratorPriority
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}