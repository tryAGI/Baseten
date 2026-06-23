
#nullable enable

namespace Baseten
{
    /// <summary>
    /// One desired upstream target. The customer picks a provider; Baseten owns the<br/>
    /// upstream host and protocol adapter.
    /// </summary>
    public sealed partial class EndpointTargetRequestV1
    {
        /// <summary>
        /// Upstream provider for this target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.GatewayProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GatewayProvider Provider { get; set; }

        /// <summary>
        /// Secret holding the provider credential. Required for external providers.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_id")]
        public string? SecretId { get; set; }

        /// <summary>
        /// Model name to send upstream. Required for external providers and optional for BASETEN targets.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_model")]
        public string? TargetModel { get; set; }

        /// <summary>
        /// Baseten model to route to. Required for and only valid with BASETEN.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Baseten model environment to route to. Only valid with BASETEN. Omit or pass `production` to target production.<br/>
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
        /// Initializes a new instance of the <see cref="EndpointTargetRequestV1" /> class.
        /// </summary>
        /// <param name="provider">
        /// Upstream provider for this target.
        /// </param>
        /// <param name="secretId">
        /// Secret holding the provider credential. Required for external providers.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="targetModel">
        /// Model name to send upstream. Required for external providers and optional for BASETEN targets.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="modelId">
        /// Baseten model to route to. Required for and only valid with BASETEN.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="environmentName">
        /// Baseten model environment to route to. Only valid with BASETEN. Omit or pass `production` to target production.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EndpointTargetRequestV1(
            global::Baseten.GatewayProvider provider,
            string? secretId,
            string? targetModel,
            string? modelId,
            string? environmentName)
        {
            this.Provider = provider;
            this.SecretId = secretId;
            this.TargetModel = targetModel;
            this.ModelId = modelId;
            this.EnvironmentName = environmentName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndpointTargetRequestV1" /> class.
        /// </summary>
        public EndpointTargetRequestV1()
        {
        }

    }
}