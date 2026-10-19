
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A published LoRA config: which modules the adapter targets and how experts are laid out.
    /// </summary>
    public sealed partial class LoopsLoRAConfigV1
    {
        /// <summary>
        /// The config version, like v1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfigVersion { get; set; }

        /// <summary>
        /// The module names the LoRA adapter targets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Targets { get; set; }

        /// <summary>
        /// How routed-expert LoRA weights are laid out. Null when no experts are targeted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expert_layout")]
        public global::Baseten.LoopsLoRAConfigV1ExpertLayout? ExpertLayout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsLoRAConfigV1" /> class.
        /// </summary>
        /// <param name="configVersion">
        /// The config version, like v1.
        /// </param>
        /// <param name="targets">
        /// The module names the LoRA adapter targets.
        /// </param>
        /// <param name="expertLayout">
        /// How routed-expert LoRA weights are laid out. Null when no experts are targeted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsLoRAConfigV1(
            string configVersion,
            global::System.Collections.Generic.IList<string> targets,
            global::Baseten.LoopsLoRAConfigV1ExpertLayout? expertLayout)
        {
            this.ConfigVersion = configVersion ?? throw new global::System.ArgumentNullException(nameof(configVersion));
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
            this.ExpertLayout = expertLayout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsLoRAConfigV1" /> class.
        /// </summary>
        public LoopsLoRAConfigV1()
        {
        }

    }
}