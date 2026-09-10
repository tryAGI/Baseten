
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelApisCostResultV1
    {
        /// <summary>
        /// The single attributed API key prefix for this result. Null when not grouping by api_key_prefix or when attribution is unavailable.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_prefixes")]
        public global::System.Collections.Generic.IList<string>? ApiKeyPrefixes { get; set; }

        /// <summary>
        /// Attributed user ID. Null when not grouping by user or when attribution is unavailable.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Model identifier. Null when not grouping by model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Service tier. Null when not grouping by service_tier or when attribution is unavailable.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public string? ServiceTier { get; set; }

        /// <summary>
        /// Model API cost in USD for this day and grouping combination, returned as an exact decimal string preserving fractional-cent amounts. This amount may differ from finalized invoice amounts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtotal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Subtotal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelApisCostResultV1" /> class.
        /// </summary>
        /// <param name="subtotal">
        /// Model API cost in USD for this day and grouping combination, returned as an exact decimal string preserving fractional-cent amounts. This amount may differ from finalized invoice amounts.
        /// </param>
        /// <param name="apiKeyPrefixes">
        /// The single attributed API key prefix for this result. Null when not grouping by api_key_prefix or when attribution is unavailable.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="userId">
        /// Attributed user ID. Null when not grouping by user or when attribution is unavailable.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="model">
        /// Model identifier. Null when not grouping by model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="serviceTier">
        /// Service tier. Null when not grouping by service_tier or when attribution is unavailable.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelApisCostResultV1(
            string subtotal,
            global::System.Collections.Generic.IList<string>? apiKeyPrefixes,
            string? userId,
            string? model,
            string? serviceTier)
        {
            this.ApiKeyPrefixes = apiKeyPrefixes;
            this.UserId = userId;
            this.Model = model;
            this.ServiceTier = serviceTier;
            this.Subtotal = subtotal ?? throw new global::System.ArgumentNullException(nameof(subtotal));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelApisCostResultV1" /> class.
        /// </summary>
        public ModelApisCostResultV1()
        {
        }

    }
}