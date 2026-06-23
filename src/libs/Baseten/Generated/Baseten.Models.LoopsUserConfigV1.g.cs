
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The caller's Loops user-level config (accelerator priorities).
    /// </summary>
    public sealed partial class LoopsUserConfigV1
    {
        /// <summary>
        /// Ordered allowlist of GPU types for your Loops trainer deployments, highest priority first. Intersected with the org-level allowlist (org acts as a ceiling). Null means 'inherit the org-level allowlist'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainer_accelerator_priority")]
        public global::System.Collections.Generic.IList<string>? TrainerAcceleratorPriority { get; set; }

        /// <summary>
        /// Ordered allowlist of GPU types for your Loops sampler deployments, highest priority first. Intersected with the org-level allowlist (org acts as a ceiling). Null means 'inherit the org-level allowlist'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampler_accelerator_priority")]
        public global::System.Collections.Generic.IList<string>? SamplerAcceleratorPriority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsUserConfigV1" /> class.
        /// </summary>
        /// <param name="trainerAcceleratorPriority">
        /// Ordered allowlist of GPU types for your Loops trainer deployments, highest priority first. Intersected with the org-level allowlist (org acts as a ceiling). Null means 'inherit the org-level allowlist'.
        /// </param>
        /// <param name="samplerAcceleratorPriority">
        /// Ordered allowlist of GPU types for your Loops sampler deployments, highest priority first. Intersected with the org-level allowlist (org acts as a ceiling). Null means 'inherit the org-level allowlist'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsUserConfigV1(
            global::System.Collections.Generic.IList<string>? trainerAcceleratorPriority,
            global::System.Collections.Generic.IList<string>? samplerAcceleratorPriority)
        {
            this.TrainerAcceleratorPriority = trainerAcceleratorPriority;
            this.SamplerAcceleratorPriority = samplerAcceleratorPriority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsUserConfigV1" /> class.
        /// </summary>
        public LoopsUserConfigV1()
        {
        }

    }
}