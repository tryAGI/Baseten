
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpsertGridConnectionConfigAzureV1
    {
        /// <summary>
        /// Provider kind for Microsoft Azure. Route targets name a deployment, which must be named after its Azure model. Claude models (`claude-*`) use the Anthropic Messages API, and other models use the OpenAI-compatible APIs.
        /// </summary>
        /// <default>"AZURE"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string Provider { get; set; } = "AZURE";

        /// <summary>
        /// Name of an existing secret, owned by the same team, that holds the provider API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretName { get; set; }

        /// <summary>
        /// Name of the Azure AI Foundry or Azure OpenAI resource, the subdomain of `&lt;resource_name&gt;.openai.azure.com`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertGridConnectionConfigAzureV1" /> class.
        /// </summary>
        /// <param name="secretName">
        /// Name of an existing secret, owned by the same team, that holds the provider API key.
        /// </param>
        /// <param name="resourceName">
        /// Name of the Azure AI Foundry or Azure OpenAI resource, the subdomain of `&lt;resource_name&gt;.openai.azure.com`.
        /// </param>
        /// <param name="provider">
        /// Provider kind for Microsoft Azure. Route targets name a deployment, which must be named after its Azure model. Claude models (`claude-*`) use the Anthropic Messages API, and other models use the OpenAI-compatible APIs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpsertGridConnectionConfigAzureV1(
            string secretName,
            string resourceName,
            string provider = "AZURE")
        {
            this.Provider = provider;
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
            this.ResourceName = resourceName ?? throw new global::System.ArgumentNullException(nameof(resourceName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertGridConnectionConfigAzureV1" /> class.
        /// </summary>
        public UpsertGridConnectionConfigAzureV1()
        {
        }

    }
}