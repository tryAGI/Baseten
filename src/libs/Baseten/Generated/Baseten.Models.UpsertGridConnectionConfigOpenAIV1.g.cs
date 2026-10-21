
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpsertGridConnectionConfigOpenAIV1
    {
        /// <summary>
        /// Provider kind for OpenAI.
        /// </summary>
        /// <default>"OPENAI"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string Provider { get; set; } = "OPENAI";

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
        /// Initializes a new instance of the <see cref="UpsertGridConnectionConfigOpenAIV1" /> class.
        /// </summary>
        /// <param name="secretName">
        /// Name of an existing secret, owned by the same team, that holds the provider API key.
        /// </param>
        /// <param name="provider">
        /// Provider kind for OpenAI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertGridConnectionConfigOpenAIV1(
            string secretName,
            string provider = "OPENAI")
        {
            this.Provider = provider;
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertGridConnectionConfigOpenAIV1" /> class.
        /// </summary>
        public UpsertGridConnectionConfigOpenAIV1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="UpsertGridConnectionConfigOpenAIV1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static UpsertGridConnectionConfigOpenAIV1 FromSecretName(string secretName)
        {
            return new UpsertGridConnectionConfigOpenAIV1
            {
                SecretName = secretName,
            };
        }

    }
}