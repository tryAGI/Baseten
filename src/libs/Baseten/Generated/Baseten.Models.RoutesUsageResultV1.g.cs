
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RoutesUsageResultV1
    {
        /// <summary>
        /// Prefix of the Routes key. Null when not grouping by API_KEY_PREFIX.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_prefix")]
        public string? ApiKeyPrefix { get; set; }

        /// <summary>
        /// ID of the user who created the Routes key. Null when not grouping by USER or when the creator is unknown.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Route ID. Null when not grouping by ROUTE.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route_id")]
        public string? RouteId { get; set; }

        /// <summary>
        /// Route name. Null when not grouping by ROUTE.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route_name")]
        public string? RouteName { get; set; }

        /// <summary>
        /// Model name. For external providers, the model name sent to the provider. Null when not grouping by MODEL.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Provider that served the requests. Null when not grouping by PROVIDER or when the provider cannot be determined.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public global::Baseten.RouteProviderV1? Provider { get; set; }

        /// <summary>
        /// Estimated cost in USD, returned as an exact decimal string. Null when some usage in this result could not be priced, including all Vertex and OpenAI-compatible usage. Costs for OpenAI, Anthropic, and xAI estimate what you pay those providers; they are not Baseten charges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_usd")]
        public string? CostUsd { get; set; }

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
        /// Number of requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RequestCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesUsageResultV1" /> class.
        /// </summary>
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
        /// <param name="requestCount">
        /// Number of requests.
        /// </param>
        /// <param name="apiKeyPrefix">
        /// Prefix of the Routes key. Null when not grouping by API_KEY_PREFIX.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="userId">
        /// ID of the user who created the Routes key. Null when not grouping by USER or when the creator is unknown.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="routeId">
        /// Route ID. Null when not grouping by ROUTE.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="routeName">
        /// Route name. Null when not grouping by ROUTE.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="model">
        /// Model name. For external providers, the model name sent to the provider. Null when not grouping by MODEL.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="provider">
        /// Provider that served the requests. Null when not grouping by PROVIDER or when the provider cannot be determined.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="costUsd">
        /// Estimated cost in USD, returned as an exact decimal string. Null when some usage in this result could not be priced, including all Vertex and OpenAI-compatible usage. Costs for OpenAI, Anthropic, and xAI estimate what you pay those providers; they are not Baseten charges.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoutesUsageResultV1(
            int inputTokens,
            int cachedInputTokens,
            int uncachedInputTokens,
            int outputTokens,
            int requestCount,
            string? apiKeyPrefix,
            string? userId,
            string? routeId,
            string? routeName,
            string? model,
            global::Baseten.RouteProviderV1? provider,
            string? costUsd)
        {
            this.ApiKeyPrefix = apiKeyPrefix;
            this.UserId = userId;
            this.RouteId = routeId;
            this.RouteName = routeName;
            this.Model = model;
            this.Provider = provider;
            this.CostUsd = costUsd;
            this.InputTokens = inputTokens;
            this.CachedInputTokens = cachedInputTokens;
            this.UncachedInputTokens = uncachedInputTokens;
            this.OutputTokens = outputTokens;
            this.RequestCount = requestCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesUsageResultV1" /> class.
        /// </summary>
        public RoutesUsageResultV1()
        {
        }

    }
}