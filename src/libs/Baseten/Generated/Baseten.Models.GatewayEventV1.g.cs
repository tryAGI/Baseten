
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GatewayEventV1
    {
        /// <summary>
        /// Event type.<br/>
        /// Default Value: API_BILLING_USAGE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Deduplication key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idempotencyKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdempotencyKey { get; set; }

        /// <summary>
        /// Billing event time (ISO 8601, UTC).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Inference request ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// Served model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelSlug { get; set; }

        /// <summary>
        /// Calling group's external ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("externalEntityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalEntityId { get; set; }

        /// <summary>
        /// API key prefix.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyPrefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyPrefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GatewayEventTokensV1 Tokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayEventV1" /> class.
        /// </summary>
        /// <param name="idempotencyKey">
        /// Deduplication key.
        /// </param>
        /// <param name="timestamp">
        /// Billing event time (ISO 8601, UTC).
        /// </param>
        /// <param name="requestId">
        /// Inference request ID.
        /// </param>
        /// <param name="modelSlug">
        /// Served model.
        /// </param>
        /// <param name="externalEntityId">
        /// Calling group's external ID.
        /// </param>
        /// <param name="apiKeyPrefix">
        /// API key prefix.
        /// </param>
        /// <param name="tokens"></param>
        /// <param name="type">
        /// Event type.<br/>
        /// Default Value: API_BILLING_USAGE
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GatewayEventV1(
            string idempotencyKey,
            string timestamp,
            string requestId,
            string modelSlug,
            string externalEntityId,
            string apiKeyPrefix,
            global::Baseten.GatewayEventTokensV1 tokens,
            string? type)
        {
            this.Type = type;
            this.IdempotencyKey = idempotencyKey ?? throw new global::System.ArgumentNullException(nameof(idempotencyKey));
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.ModelSlug = modelSlug ?? throw new global::System.ArgumentNullException(nameof(modelSlug));
            this.ExternalEntityId = externalEntityId ?? throw new global::System.ArgumentNullException(nameof(externalEntityId));
            this.ApiKeyPrefix = apiKeyPrefix ?? throw new global::System.ArgumentNullException(nameof(apiKeyPrefix));
            this.Tokens = tokens ?? throw new global::System.ArgumentNullException(nameof(tokens));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayEventV1" /> class.
        /// </summary>
        public GatewayEventV1()
        {
        }

    }
}