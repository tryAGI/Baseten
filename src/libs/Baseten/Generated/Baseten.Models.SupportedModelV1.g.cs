
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// A model supported by the Loops server.
    /// </summary>
    public sealed partial class SupportedModelV1
    {
        /// <summary>
        /// The name of the supported model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// The longest sequence length Baseten supports for this model. Independent of the caller: see 'max_enabled_seq_len' for what this workspace can actually train at. Named to match the 'max_seq_len' query parameter and the field of the same name on run creation, so one name follows the value through the API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_seq_len")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxSeqLen { get; set; }

        /// <summary>
        /// The longest sequence length this workspace can train at. Lower than 'max_seq_len' when the longer configurations need hardware the workspace is not approved for — a model's longer sequence lengths often need a bigger SKU of the same GPU. Zero when the workspace cannot run the model at all, so a client can compare against a required length without a null case.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_enabled_seq_len")]
        public int? MaxEnabledSeqLen { get; set; }

        /// <summary>
        /// Deprecated. Use 'max_seq_len', which carries the same value. Kept so existing clients keep working.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_context_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxContextLength { get; set; }

        /// <summary>
        /// Whether the model accepts image inputs alongside text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_vision_language")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsVisionLanguage { get; set; }

        /// <summary>
        /// Whether this workspace can start a run with this model now. False means Baseten supports it but the workspace cannot use it yet; 'not_enabled' says why. Capacity is resolved when the run is created, so true is not a guarantee that GPUs are free.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Why the model is not enabled, and what would change it. Present only when 'enabled' is false — an enabled model has nothing to explain. Read 'enabled' for the state; this is the detail behind it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enablement_details")]
        public global::Baseten.EnablementDetailsV1? EnablementDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedModelV1" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The name of the supported model.
        /// </param>
        /// <param name="maxSeqLen">
        /// The longest sequence length Baseten supports for this model. Independent of the caller: see 'max_enabled_seq_len' for what this workspace can actually train at. Named to match the 'max_seq_len' query parameter and the field of the same name on run creation, so one name follows the value through the API.
        /// </param>
        /// <param name="maxContextLength">
        /// Deprecated. Use 'max_seq_len', which carries the same value. Kept so existing clients keep working.
        /// </param>
        /// <param name="supportsVisionLanguage">
        /// Whether the model accepts image inputs alongside text.
        /// </param>
        /// <param name="maxEnabledSeqLen">
        /// The longest sequence length this workspace can train at. Lower than 'max_seq_len' when the longer configurations need hardware the workspace is not approved for — a model's longer sequence lengths often need a bigger SKU of the same GPU. Zero when the workspace cannot run the model at all, so a client can compare against a required length without a null case.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="enabled">
        /// Whether this workspace can start a run with this model now. False means Baseten supports it but the workspace cannot use it yet; 'not_enabled' says why. Capacity is resolved when the run is created, so true is not a guarantee that GPUs are free.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enablementDetails">
        /// Why the model is not enabled, and what would change it. Present only when 'enabled' is false — an enabled model has nothing to explain. Read 'enabled' for the state; this is the detail behind it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SupportedModelV1(
            string modelName,
            int maxSeqLen,
            int maxContextLength,
            bool supportsVisionLanguage,
            int? maxEnabledSeqLen,
            bool? enabled,
            global::Baseten.EnablementDetailsV1? enablementDetails)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.MaxSeqLen = maxSeqLen;
            this.MaxEnabledSeqLen = maxEnabledSeqLen;
            this.MaxContextLength = maxContextLength;
            this.SupportsVisionLanguage = supportsVisionLanguage;
            this.Enabled = enabled;
            this.EnablementDetails = enablementDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedModelV1" /> class.
        /// </summary>
        public SupportedModelV1()
        {
        }

    }
}