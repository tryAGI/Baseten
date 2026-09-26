
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExploreMetadataV1
    {
        /// <summary>
        /// Metadata slug, e.g. 'anthropic/claude-opus-4'; null for rows without one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Model display name, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Model release date. Month-only source dates use the first day of that month.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_date")]
        public global::System.DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Provider key derived from the slug prefix, e.g. 'anthropic'; null for unprefixed slugs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        public string? Provider { get; set; }

        /// <summary>
        /// Total context window in tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_window")]
        public int? ContextWindow { get; set; }

        /// <summary>
        /// Maximum output tokens per response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_output_tokens")]
        public int? MaxOutputTokens { get; set; }

        /// <summary>
        /// Accepted input modalities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_modalities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> InputModalities { get; set; }

        /// <summary>
        /// Whether the model supports tool calling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public bool? Tools { get; set; }

        /// <summary>
        /// Reasoning effort levels the model supports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort_levels")]
        public global::System.Collections.Generic.IList<string>? ReasoningEffortLevels { get; set; }

        /// <summary>
        /// Whether the model supports parallel tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parallel_tool_calls")]
        public bool? ParallelToolCalls { get; set; }

        /// <summary>
        /// API formats the model supports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_api_formats")]
        public global::Baseten.ExploreMetadataAPIFormatsV1? SupportedApiFormats { get; set; }

        /// <summary>
        /// Provider list prices in USD per 1M tokens, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public global::Baseten.ExploreCostV1? Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExploreMetadataV1" /> class.
        /// </summary>
        /// <param name="inputModalities">
        /// Accepted input modalities.
        /// </param>
        /// <param name="slug">
        /// Metadata slug, e.g. 'anthropic/claude-opus-4'; null for rows without one.
        /// </param>
        /// <param name="displayName">
        /// Model display name, when available.
        /// </param>
        /// <param name="releaseDate">
        /// Model release date. Month-only source dates use the first day of that month.
        /// </param>
        /// <param name="provider">
        /// Provider key derived from the slug prefix, e.g. 'anthropic'; null for unprefixed slugs.
        /// </param>
        /// <param name="contextWindow">
        /// Total context window in tokens.
        /// </param>
        /// <param name="maxOutputTokens">
        /// Maximum output tokens per response.
        /// </param>
        /// <param name="tools">
        /// Whether the model supports tool calling.
        /// </param>
        /// <param name="reasoningEffortLevels">
        /// Reasoning effort levels the model supports.
        /// </param>
        /// <param name="parallelToolCalls">
        /// Whether the model supports parallel tool calls.
        /// </param>
        /// <param name="supportedApiFormats">
        /// API formats the model supports.
        /// </param>
        /// <param name="cost">
        /// Provider list prices in USD per 1M tokens, when available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExploreMetadataV1(
            global::System.Collections.Generic.IList<string> inputModalities,
            string? slug,
            string? displayName,
            global::System.DateTime? releaseDate,
            string? provider,
            int? contextWindow,
            int? maxOutputTokens,
            bool? tools,
            global::System.Collections.Generic.IList<string>? reasoningEffortLevels,
            bool? parallelToolCalls,
            global::Baseten.ExploreMetadataAPIFormatsV1? supportedApiFormats,
            global::Baseten.ExploreCostV1? cost)
        {
            this.Slug = slug;
            this.DisplayName = displayName;
            this.ReleaseDate = releaseDate;
            this.Provider = provider;
            this.ContextWindow = contextWindow;
            this.MaxOutputTokens = maxOutputTokens;
            this.InputModalities = inputModalities ?? throw new global::System.ArgumentNullException(nameof(inputModalities));
            this.Tools = tools;
            this.ReasoningEffortLevels = reasoningEffortLevels;
            this.ParallelToolCalls = parallelToolCalls;
            this.SupportedApiFormats = supportedApiFormats;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExploreMetadataV1" /> class.
        /// </summary>
        public ExploreMetadataV1()
        {
        }

    }
}