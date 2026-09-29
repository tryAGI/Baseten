
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RoutesUsageResultV1
    {
        /// <summary>
        /// ID of the user who created the Routes key. Null when not grouping by USER.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Model name. For external providers, the model name sent to the provider. Null when not grouping by MODEL.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Provider that served the requests. Null when not grouping by PROVIDER.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::Baseten.RouteProviderV1? Provider { get; set; }

        /// <summary>
        /// Estimated cost in USD, returned as an exact decimal string. Costs for OpenAI, Anthropic, and xAI estimate what you pay those providers; they are not Baseten charges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CostUsd { get; set; }

        /// <summary>
        /// Input tokens, including cached input tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// Input tokens read from the prompt cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedInputTokens { get; set; }

        /// <summary>
        /// Input tokens not read from the prompt cache, including tokens written to the cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uncached_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UncachedInputTokens { get; set; }

        /// <summary>
        /// Output tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesUsageResultV1" /> class.
        /// </summary>
        /// <param name="costUsd">
        /// Estimated cost in USD, returned as an exact decimal string. Costs for OpenAI, Anthropic, and xAI estimate what you pay those providers; they are not Baseten charges.
        /// </param>
        /// <param name="inputTokens">
        /// Input tokens, including cached input tokens.
        /// </param>
        /// <param name="cachedInputTokens">
        /// Input tokens read from the prompt cache.
        /// </param>
        /// <param name="uncachedInputTokens">
        /// Input tokens not read from the prompt cache, including tokens written to the cache.
        /// </param>
        /// <param name="outputTokens">
        /// Output tokens.
        /// </param>
        /// <param name="userId">
        /// ID of the user who created the Routes key. Null when not grouping by USER.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="model">
        /// Model name. For external providers, the model name sent to the provider. Null when not grouping by MODEL.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="provider">
        /// Provider that served the requests. Null when not grouping by PROVIDER.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoutesUsageResultV1(
            string costUsd,
            int inputTokens,
            int cachedInputTokens,
            int uncachedInputTokens,
            int outputTokens,
            string? userId,
            string? model,
            global::Baseten.RouteProviderV1? provider)
        {
            this.UserId = userId;
            this.Model = model;
            this.Provider = provider;
            this.CostUsd = costUsd ?? throw new global::System.ArgumentNullException(nameof(costUsd));
            this.InputTokens = inputTokens;
            this.CachedInputTokens = cachedInputTokens;
            this.UncachedInputTokens = uncachedInputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesUsageResultV1" /> class.
        /// </summary>
        public RoutesUsageResultV1()
        {
        }

    }
}