
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRouteConnectionConfigAnthropicV1
    {
        /// <summary>
        /// Provider kind for Anthropic.
        /// </summary>
        /// <default>"ANTHROPIC"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string Provider { get; set; } = "ANTHROPIC";

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
        /// Initializes a new instance of the <see cref="UpdateRouteConnectionConfigAnthropicV1" /> class.
        /// </summary>
        /// <param name="secretId">
        /// Identifier of the new secret, owned by the connection's team, that holds the provider API key. Omit to keep the current secret.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="provider">
        /// Provider kind for Anthropic.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRouteConnectionConfigAnthropicV1(
            string? secretId,
            string provider = "ANTHROPIC")
        {
            this.Provider = provider;
            this.SecretId = secretId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteConnectionConfigAnthropicV1" /> class.
        /// </summary>
        public UpdateRouteConnectionConfigAnthropicV1()
        {
        }

    }
}