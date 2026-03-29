
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelApiItemV1
    {
        /// <summary>
        /// Model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Model family (e.g., llama, mistral)<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_family")]
        public string? ModelFamily { get; set; }

        /// <summary>
        /// Subtotal cost in dollars for this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtotal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AnyOf<double?, string> Subtotal { get; set; }

        /// <summary>
        /// Total input tokens for this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// Total output tokens for this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Total cached input tokens for this model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedInputTokens { get; set; }

        /// <summary>
        /// Daily usage breakdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily")]
        public global::System.Collections.Generic.IList<global::Baseten.DailyModelApiUsageV1>? Daily { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelApiItemV1" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Model name
        /// </param>
        /// <param name="subtotal">
        /// Subtotal cost in dollars for this model
        /// </param>
        /// <param name="inputTokens">
        /// Total input tokens for this model
        /// </param>
        /// <param name="outputTokens">
        /// Total output tokens for this model
        /// </param>
        /// <param name="cachedInputTokens">
        /// Total cached input tokens for this model
        /// </param>
        /// <param name="modelFamily">
        /// Model family (e.g., llama, mistral)<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="daily">
        /// Daily usage breakdown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelApiItemV1(
            string modelName,
            global::Baseten.AnyOf<double?, string> subtotal,
            int inputTokens,
            int outputTokens,
            int cachedInputTokens,
            string? modelFamily,
            global::System.Collections.Generic.IList<global::Baseten.DailyModelApiUsageV1>? daily)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.ModelFamily = modelFamily;
            this.Subtotal = subtotal;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CachedInputTokens = cachedInputTokens;
            this.Daily = daily;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelApiItemV1" /> class.
        /// </summary>
        public ModelApiItemV1()
        {
        }
    }
}