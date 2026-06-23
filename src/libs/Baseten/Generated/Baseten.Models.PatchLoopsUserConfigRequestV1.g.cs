
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request body for ``PATCH /v1/loops/user_config``.<br/>
    /// Follows JSON Merge Patch (RFC 7396) semantics per field: omit the field<br/>
    /// to leave it unchanged, send ``null`` to clear and inherit the org-level<br/>
    /// allowlist, send a list to set the allowlist. Empty lists are rejected<br/>
    /// because the storage layer normalizes ``null`` and ``[]`` identically, so<br/>
    /// accepting both would create two ways to spell the same intent.
    /// </summary>
    public sealed partial class PatchLoopsUserConfigRequestV1
    {
        /// <summary>
        /// Ordered list of GPU types for trainer deployments, highest priority first. Send a list to set; send null to clear (inherit org allowlist); omit to leave unchanged. Empty list is rejected.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trainer_accelerator_priority")]
        public global::System.Collections.Generic.IList<string>? TrainerAcceleratorPriority { get; set; }

        /// <summary>
        /// Ordered list of GPU types for sampler deployments, highest priority first. Send a list to set; send null to clear (inherit org allowlist); omit to leave unchanged. Empty list is rejected.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampler_accelerator_priority")]
        public global::System.Collections.Generic.IList<string>? SamplerAcceleratorPriority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchLoopsUserConfigRequestV1" /> class.
        /// </summary>
        /// <param name="trainerAcceleratorPriority">
        /// Ordered list of GPU types for trainer deployments, highest priority first. Send a list to set; send null to clear (inherit org allowlist); omit to leave unchanged. Empty list is rejected.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="samplerAcceleratorPriority">
        /// Ordered list of GPU types for sampler deployments, highest priority first. Send a list to set; send null to clear (inherit org allowlist); omit to leave unchanged. Empty list is rejected.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchLoopsUserConfigRequestV1(
            global::System.Collections.Generic.IList<string>? trainerAcceleratorPriority,
            global::System.Collections.Generic.IList<string>? samplerAcceleratorPriority)
        {
            this.TrainerAcceleratorPriority = trainerAcceleratorPriority;
            this.SamplerAcceleratorPriority = samplerAcceleratorPriority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchLoopsUserConfigRequestV1" /> class.
        /// </summary>
        public PatchLoopsUserConfigRequestV1()
        {
        }

    }
}