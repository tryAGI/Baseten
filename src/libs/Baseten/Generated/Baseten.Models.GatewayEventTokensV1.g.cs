
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GatewayEventTokensV1
    {
        /// <summary>
        /// Cached and uncached input tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// Output tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Cached input tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedInputTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayEventTokensV1" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// Cached and uncached input tokens.
        /// </param>
        /// <param name="outputTokens">
        /// Output tokens.
        /// </param>
        /// <param name="cachedInputTokens">
        /// Cached input tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GatewayEventTokensV1(
            int inputTokens,
            int outputTokens,
            int cachedInputTokens)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CachedInputTokens = cachedInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayEventTokensV1" /> class.
        /// </summary>
        public GatewayEventTokensV1()
        {
        }

    }
}