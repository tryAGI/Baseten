
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteConnectionConfigXAIV1
    {
        /// <summary>
        /// Provider kind for xAI.
        /// </summary>
        /// <default>"XAI"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string Provider { get; set; } = "XAI";

        /// <summary>
        /// Identifier of an existing secret, owned by the same team, that holds the provider API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteConnectionConfigXAIV1" /> class.
        /// </summary>
        /// <param name="secretId">
        /// Identifier of an existing secret, owned by the same team, that holds the provider API key.
        /// </param>
        /// <param name="provider">
        /// Provider kind for xAI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteConnectionConfigXAIV1(
            string secretId,
            string provider = "XAI")
        {
            this.Provider = provider;
            this.SecretId = secretId ?? throw new global::System.ArgumentNullException(nameof(secretId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteConnectionConfigXAIV1" /> class.
        /// </summary>
        public RouteConnectionConfigXAIV1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="RouteConnectionConfigXAIV1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static RouteConnectionConfigXAIV1 FromSecretId(string secretId)
        {
            return new RouteConnectionConfigXAIV1
            {
                SecretId = secretId,
            };
        }

    }
}