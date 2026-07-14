
#nullable enable

namespace Baseten
{
    /// <summary>
    /// One configured upstream target of an endpoint.
    /// </summary>
    public sealed partial class EndpointTargetV1
    {
        /// <summary>
        /// Upstream provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.GatewayProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GatewayProvider Provider { get; set; }

        /// <summary>
        /// Referenced secret, if any.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_id")]
        public string? SecretId { get; set; }

        /// <summary>
        /// Upstream model name, if any.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_model")]
        public string? TargetModel { get; set; }

        /// <summary>
        /// Custom OpenAI-compatible base URL, if any.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        public string? BaseUrl { get; set; }

        /// <summary>
        /// Baseten model, if any.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Baseten model environment, if non-production.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_name")]
        public string? EnvironmentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointTargetV1" /> class.
        /// </summary>
        /// <param name="provider">
        /// Upstream provider.
        /// </param>
        /// <param name="secretId">
        /// Referenced secret, if any.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="targetModel">
        /// Upstream model name, if any.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="baseUrl">
        /// Custom OpenAI-compatible base URL, if any.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="modelId">
        /// Baseten model, if any.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="environmentName">
        /// Baseten model environment, if non-production.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointTargetV1(
            global::Baseten.GatewayProvider provider,
            string? secretId,
            string? targetModel,
            string? baseUrl,
            string? modelId,
            string? environmentName)
        {
            this.Provider = provider;
            this.SecretId = secretId;
            this.TargetModel = targetModel;
            this.BaseUrl = baseUrl;
            this.ModelId = modelId;
            this.EnvironmentName = environmentName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointTargetV1" /> class.
        /// </summary>
        public EndpointTargetV1()
        {
        }

    }
}