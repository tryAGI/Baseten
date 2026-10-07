
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRouteConnectionConfigXAIV1
    {
        /// <summary>
        /// Provider kind for xAI.
        /// </summary>
        /// <default>"XAI"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string Provider { get; set; } = "XAI";

        /// <summary>
        /// Identifier of the new secret, owned by the connection's team, that holds the provider API key. Omit to keep the current secret.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_id")]
        public string? SecretId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteConnectionConfigXAIV1" /> class.
        /// </summary>
        /// <param name="secretId">
        /// Identifier of the new secret, owned by the connection's team, that holds the provider API key. Omit to keep the current secret.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="provider">
        /// Provider kind for xAI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRouteConnectionConfigXAIV1(
            string? secretId,
            string provider = "XAI")
        {
            this.Provider = provider;
            this.SecretId = secretId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteConnectionConfigXAIV1" /> class.
        /// </summary>
        public UpdateRouteConnectionConfigXAIV1()
        {
        }

    }
}