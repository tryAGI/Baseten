
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Baseten
{
    /// <summary>
    /// Model metadata and authorized team details, with retained legacy fields.
    /// </summary>
    public sealed partial class ModelAPIV1
    {
        /// <summary>
        /// Identifier of the Model API. Stable, URL-safe slug used as the public identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Human-readable name of the Model API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Description of the Model API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Family the underlying model belongs to.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_family")]
        public string? ModelFamily { get; set; }

        /// <summary>
        /// Date the Model API was made available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ReleaseDate { get; set; }

        /// <summary>
        /// Base URL for invoking the Model API. OpenAI-shaped routes (e.g. /v1/chat/completions) live underneath this host.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invoke_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvokeUrl { get; set; }

        /// <summary>
        /// The model's context window length, in tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContextLength { get; set; }

        /// <summary>
        /// Deprecated and will be removed in a future version. Legacy effective input-token price. Use team_details pricing instead. Retained during migration; null when pricing is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_million_input_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        public global::Baseten.AnyOf<double?, string>? CostPerMillionInputTokens { get; set; }

        /// <summary>
        /// Effective cost per million cached input tokens, in dollars. Null when pricing is unavailable or the Model API has no cached input price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_million_cached_input_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        public global::Baseten.AnyOf<double?, string>? CostPerMillionCachedInputTokens { get; set; }

        /// <summary>
        /// Deprecated and will be removed in a future version. Legacy effective output-token price. Use team_details pricing instead. Retained during migration; null when pricing is unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_million_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        public global::Baseten.AnyOf<double?, string>? CostPerMillionOutputTokens { get; set; }

        /// <summary>
        /// Deprecated and will be removed in a future version. Legacy Default Team effective limits, independent of team_ids, or catalog defaults when not added or unauthorized. Use team_details for team limits; this field is not the org-pool limit view.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ModelAPIRateLimitV1> RateLimits { get; set; }

        /// <summary>
        /// Deprecated and will be removed in a future version. Legacy Default Team state, independent of team_ids. Use team_details instead. Null when not added or unauthorized.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_details")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Baseten.ModelAPIOrgDetailsV1? OrgDetails { get; set; }

        /// <summary>
        /// Added Model API details for authorized teams, ordered by team ID. Empty when no team in the selected scope has added this Model API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_details")]
        public global::System.Collections.Generic.IList<global::Baseten.ModelAPITeamDetailsV1>? TeamDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAPIV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Identifier of the Model API. Stable, URL-safe slug used as the public identifier.
        /// </param>
        /// <param name="displayName">
        /// Human-readable name of the Model API.
        /// </param>
        /// <param name="description">
        /// Description of the Model API.
        /// </param>
        /// <param name="releaseDate">
        /// Date the Model API was made available.
        /// </param>
        /// <param name="invokeUrl">
        /// Base URL for invoking the Model API. OpenAI-shaped routes (e.g. /v1/chat/completions) live underneath this host.
        /// </param>
        /// <param name="contextLength">
        /// The model's context window length, in tokens.
        /// </param>
        /// <param name="rateLimits">
        /// Deprecated and will be removed in a future version. Legacy Default Team effective limits, independent of team_ids, or catalog defaults when not added or unauthorized. Use team_details for team limits; this field is not the org-pool limit view.
        /// </param>
        /// <param name="modelFamily">
        /// Family the underlying model belongs to.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="costPerMillionCachedInputTokens">
        /// Effective cost per million cached input tokens, in dollars. Null when pricing is unavailable or the Model API has no cached input price.
        /// </param>
        /// <param name="teamDetails">
        /// Added Model API details for authorized teams, ordered by team ID. Empty when no team in the selected scope has added this Model API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelAPIV1(
            string name,
            string displayName,
            string description,
            global::System.DateTime releaseDate,
            string invokeUrl,
            int contextLength,
            global::System.Collections.Generic.IList<global::Baseten.ModelAPIRateLimitV1> rateLimits,
            string? modelFamily,
            global::Baseten.AnyOf<double?, string>? costPerMillionCachedInputTokens,
            global::System.Collections.Generic.IList<global::Baseten.ModelAPITeamDetailsV1>? teamDetails)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ModelFamily = modelFamily;
            this.ReleaseDate = releaseDate;
            this.InvokeUrl = invokeUrl ?? throw new global::System.ArgumentNullException(nameof(invokeUrl));
            this.ContextLength = contextLength;
            this.CostPerMillionCachedInputTokens = costPerMillionCachedInputTokens;
            this.RateLimits = rateLimits ?? throw new global::System.ArgumentNullException(nameof(rateLimits));
            this.TeamDetails = teamDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAPIV1" /> class.
        /// </summary>
        public ModelAPIV1()
        {
        }

    }
}