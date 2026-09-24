
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExploreMetadataAPIFormatsV1
    {
        /// <summary>
        /// Anthropic Messages API support.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public bool? Messages { get; set; }

        /// <summary>
        /// OpenAI Responses API support.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responses")]
        public bool? Responses { get; set; }

        /// <summary>
        /// OpenAI Chat Completions API support.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_completions")]
        public bool? ChatCompletions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExploreMetadataAPIFormatsV1" /> class.
        /// </summary>
        /// <param name="messages">
        /// Anthropic Messages API support.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="responses">
        /// OpenAI Responses API support.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="chatCompletions">
        /// OpenAI Chat Completions API support.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExploreMetadataAPIFormatsV1(
            bool? messages,
            bool? responses,
            bool? chatCompletions)
        {
            this.Messages = messages;
            this.Responses = responses;
            this.ChatCompletions = chatCompletions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExploreMetadataAPIFormatsV1" /> class.
        /// </summary>
        public ExploreMetadataAPIFormatsV1()
        {
        }

    }
}