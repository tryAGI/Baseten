
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpsertGridConnectionConfigXAIV1
    {
        /// <summary>
        /// Provider kind for xAI.
        /// </summary>
        /// <default>"XAI"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string Provider { get; set; } = "XAI";

        /// <summary>
        /// Name of an existing secret, owned by the same team, that holds the provider API key.
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
        /// Initializes a new instance of the <see cref="UpsertGridConnectionConfigXAIV1" /> class.
        /// </summary>
        /// <param name="secretName">
        /// Name of an existing secret, owned by the same team, that holds the provider API key.
        /// </param>
        /// <param name="provider">
        /// Provider kind for xAI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertGridConnectionConfigXAIV1(
            string secretName,
            string provider = "XAI")
        {
            this.Provider = provider;
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertGridConnectionConfigXAIV1" /> class.
        /// </summary>
        public UpsertGridConnectionConfigXAIV1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="UpsertGridConnectionConfigXAIV1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static UpsertGridConnectionConfigXAIV1 FromSecretName(string secretName)
        {
            return new UpsertGridConnectionConfigXAIV1
            {
                SecretName = secretName,
            };
        }

    }
}