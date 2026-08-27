
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Usage totals for one combination of the requested dimensions, within one bucket.
    /// </summary>
    public sealed partial class ModelApisUsageResultV1
    {
        /// <summary>
        /// Prefix of the API key the usage is attributed to. Null when not grouping by api_key or when the request was not authenticated with an API key.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_prefix")]
        public string? ApiKeyPrefix { get; set; }

        /// <summary>
        /// User the usage is attributed to. Null when not grouping by user or when the credential is not user-scoped.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Model that served the usage. Null when not grouping by model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Total input tokens, cached and uncached combined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// Input tokens served from the prompt cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedInputTokens { get; set; }

        /// <summary>
        /// Input tokens not served from the prompt cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uncached_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UncachedInputTokens { get; set; }

        /// <summary>
        /// Total output tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Total number of requests.
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
        /// Initializes a new instance of the <see cref="ModelApisUsageResultV1" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// Total input tokens, cached and uncached combined.
        /// </param>
        /// <param name="cachedInputTokens">
        /// Input tokens served from the prompt cache.
        /// </param>
        /// <param name="uncachedInputTokens">
        /// Input tokens not served from the prompt cache.
        /// </param>
        /// <param name="outputTokens">
        /// Total output tokens.
        /// </param>
        /// <param name="requestCount">
        /// Total number of requests.
        /// </param>
        /// <param name="apiKeyPrefix">
        /// Prefix of the API key the usage is attributed to. Null when not grouping by api_key or when the request was not authenticated with an API key.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="userId">
        /// User the usage is attributed to. Null when not grouping by user or when the credential is not user-scoped.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="model">
        /// Model that served the usage. Null when not grouping by model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelApisUsageResultV1(
            int inputTokens,
            int cachedInputTokens,
            int uncachedInputTokens,
            int outputTokens,
            int requestCount,
            string? apiKeyPrefix,
            string? userId,
            string? model)
        {
            this.ApiKeyPrefix = apiKeyPrefix;
            this.UserId = userId;
            this.Model = model;
            this.InputTokens = inputTokens;
            this.CachedInputTokens = cachedInputTokens;
            this.UncachedInputTokens = uncachedInputTokens;
            this.OutputTokens = outputTokens;
            this.RequestCount = requestCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelApisUsageResultV1" /> class.
        /// </summary>
        public ModelApisUsageResultV1()
        {
        }

    }
}