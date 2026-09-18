
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteTargetOpenAICompatibleV1
    {
        /// <summary>
        /// Target kind for an OpenAI-compatible provider.
        /// </summary>
        /// <default>"OPENAI_COMPATIBLE"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "OPENAI_COMPATIBLE";

        /// <summary>
        /// Model name sent to the provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Name of a credential secret owned by the route's team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretName { get; set; }

        /// <summary>
        /// HTTPS base URL of the OpenAI-compatible provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTargetOpenAICompatibleV1" /> class.
        /// </summary>
        /// <param name="model">
        /// Model name sent to the provider.
        /// </param>
        /// <param name="secretName">
        /// Name of a credential secret owned by the route's team.
        /// </param>
        /// <param name="baseUrl">
        /// HTTPS base URL of the OpenAI-compatible provider.
        /// </param>
        /// <param name="type">
        /// Target kind for an OpenAI-compatible provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteTargetOpenAICompatibleV1(
            string model,
            string secretName,
            string baseUrl,
            string type = "OPENAI_COMPATIBLE")
        {
            this.Type = type;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTargetOpenAICompatibleV1" /> class.
        /// </summary>
        public RouteTargetOpenAICompatibleV1()
        {
        }

    }
}