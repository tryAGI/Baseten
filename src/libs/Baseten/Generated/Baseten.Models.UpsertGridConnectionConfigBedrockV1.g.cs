
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpsertGridConnectionConfigBedrockV1
    {
        /// <summary>
        /// Provider kind for Amazon Bedrock. Claude models (`anthropic.*`) use the Anthropic Messages API, and other models use the OpenAI-compatible APIs.
        /// </summary>
        /// <default>"BEDROCK"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string Provider { get; set; } = "BEDROCK";

        /// <summary>
        /// Name of an existing secret, owned by the same team, that holds the provider API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretName { get; set; }

        /// <summary>
        /// AWS Region of the Amazon Bedrock endpoint, for example `us-east-1`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// How the connection's secret authenticates with Amazon Bedrock.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.Auth2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.Auth2 Auth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertGridConnectionConfigBedrockV1" /> class.
        /// </summary>
        /// <param name="secretName">
        /// Name of an existing secret, owned by the same team, that holds the provider API key.
        /// </param>
        /// <param name="region">
        /// AWS Region of the Amazon Bedrock endpoint, for example `us-east-1`.
        /// </param>
        /// <param name="auth">
        /// How the connection's secret authenticates with Amazon Bedrock.
        /// </param>
        /// <param name="provider">
        /// Provider kind for Amazon Bedrock. Claude models (`anthropic.*`) use the Anthropic Messages API, and other models use the OpenAI-compatible APIs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertGridConnectionConfigBedrockV1(
            string secretName,
            string region,
            global::Baseten.Auth2 auth,
            string provider = "BEDROCK")
        {
            this.Provider = provider;
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Auth = auth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertGridConnectionConfigBedrockV1" /> class.
        /// </summary>
        public UpsertGridConnectionConfigBedrockV1()
        {
        }

    }
}