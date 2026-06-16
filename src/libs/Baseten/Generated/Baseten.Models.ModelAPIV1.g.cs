
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A Model API catalog row, optionally enriched with workspace-specific state.
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
        /// Cost per million input tokens, in dollars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_million_input_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AnyOf<double?, string> CostPerMillionInputTokens { get; set; }

        /// <summary>
        /// Cost per million output tokens, in dollars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_million_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AnyOf<double?, string> CostPerMillionOutputTokens { get; set; }

        /// <summary>
        /// Rate limits in effect for the workspace. Workspace-specific overrides are returned when the workspace has added this Model API and configured them; otherwise the catalog default rate limits are returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.RateLimitV1> RateLimits { get; set; }

        /// <summary>
        /// Workspace-specific state. Null when the workspace has not added this Model API.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_details")]
        public global::Baseten.ModelAPIOrgDetailsV1? OrgDetails { get; set; }

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
        /// <param name="costPerMillionInputTokens">
        /// Cost per million input tokens, in dollars.
        /// </param>
        /// <param name="costPerMillionOutputTokens">
        /// Cost per million output tokens, in dollars.
        /// </param>
        /// <param name="rateLimits">
        /// Rate limits in effect for the workspace. Workspace-specific overrides are returned when the workspace has added this Model API and configured them; otherwise the catalog default rate limits are returned.
        /// </param>
        /// <param name="modelFamily">
        /// Family the underlying model belongs to.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="orgDetails">
        /// Workspace-specific state. Null when the workspace has not added this Model API.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
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
            global::Baseten.AnyOf<double?, string> costPerMillionInputTokens,
            global::Baseten.AnyOf<double?, string> costPerMillionOutputTokens,
            global::System.Collections.Generic.IList<global::Baseten.RateLimitV1> rateLimits,
            string? modelFamily,
            global::Baseten.ModelAPIOrgDetailsV1? orgDetails)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ModelFamily = modelFamily;
            this.ReleaseDate = releaseDate;
            this.InvokeUrl = invokeUrl ?? throw new global::System.ArgumentNullException(nameof(invokeUrl));
            this.ContextLength = contextLength;
            this.CostPerMillionInputTokens = costPerMillionInputTokens;
            this.CostPerMillionOutputTokens = costPerMillionOutputTokens;
            this.RateLimits = rateLimits ?? throw new global::System.ArgumentNullException(nameof(rateLimits));
            this.OrgDetails = orgDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAPIV1" /> class.
        /// </summary>
        public ModelAPIV1()
        {
        }

    }
}