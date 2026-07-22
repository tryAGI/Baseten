
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
        /// The maximum context length (in tokens) supported by this model.
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
        /// <param name="maxContextLength">
        /// The maximum context length (in tokens) supported by this model.
        /// </param>
        /// <param name="supportsVisionLanguage">
        /// Whether the model accepts image inputs alongside text.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SupportedModelV1(
            string modelName,
            int maxContextLength,
            bool supportsVisionLanguage)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.MaxContextLength = maxContextLength;
            this.SupportsVisionLanguage = supportsVisionLanguage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SupportedModelV1" /> class.
        /// </summary>
        public SupportedModelV1()
        {
        }

    }
}