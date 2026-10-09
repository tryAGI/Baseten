
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteConnectionConfigAnthropicV1
    {
        /// <summary>
        /// Provider kind for Anthropic.
        /// </summary>
        /// <default>"ANTHROPIC"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string Provider { get; set; } = "ANTHROPIC";

        /// <summary>
        /// Identifier of the team secret holding the provider API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretId { get; set; }

        /// <summary>
        /// Name of the team secret holding the provider API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteConnectionConfigAnthropicV1" /> class.
        /// </summary>
        /// <param name="secretId">
        /// Identifier of the team secret holding the provider API key.
        /// </param>
        /// <param name="secretName">
        /// Name of the team secret holding the provider API key.
        /// </param>
        /// <param name="provider">
        /// Provider kind for Anthropic.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteConnectionConfigAnthropicV1(
            string secretId,
            string secretName,
            string provider = "ANTHROPIC")
        {
            this.Provider = provider;
            this.SecretId = secretId ?? throw new global::System.ArgumentNullException(nameof(secretId));
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteConnectionConfigAnthropicV1" /> class.
        /// </summary>
        public RouteConnectionConfigAnthropicV1()
        {
        }

    }
}