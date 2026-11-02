
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GridConnectionBedrockApiKeyAuthV1
    {
        /// <summary>
        /// The secret holds a long-term Amazon Bedrock API key.
        /// </summary>
        /// <default>"api_key"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string Method { get; set; } = "api_key";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GridConnectionBedrockApiKeyAuthV1" /> class.
        /// </summary>
        /// <param name="method">
        /// The secret holds a long-term Amazon Bedrock API key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GridConnectionBedrockApiKeyAuthV1(
            string method = "api_key")
        {
            this.Method = method;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridConnectionBedrockApiKeyAuthV1" /> class.
        /// </summary>
        public GridConnectionBedrockApiKeyAuthV1()
        {
        }

    }
}