
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteTargetXAIV1
    {
        /// <summary>
        /// Target kind for xAI.
        /// </summary>
        /// <default>"XAI"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "XAI";

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTargetXAIV1" /> class.
        /// </summary>
        /// <param name="model">
        /// Model name sent to the provider.
        /// </param>
        /// <param name="secretName">
        /// Name of a credential secret owned by the route's team.
        /// </param>
        /// <param name="type">
        /// Target kind for xAI.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteTargetXAIV1(
            string model,
            string secretName,
            string type = "XAI")
        {
            this.Type = type;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTargetXAIV1" /> class.
        /// </summary>
        public RouteTargetXAIV1()
        {
        }

    }
}