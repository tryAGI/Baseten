
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelAPITeamDetailsV1
    {
        /// <summary>
        /// Organization Shared Endpoint ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Team that has added this Model API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Name of the team that has added this Model API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamName { get; set; }

        /// <summary>
        /// When the team first added this Model API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AddedAt { get; set; }

        /// <summary>
        /// When the team last invoked this Model API. Null if never invoked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// Effective rate limits for this team's Model API, at most one per type, unit, and service tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ModelAPIRateLimitV1> RateLimits { get; set; }

        /// <summary>
        /// Effective cost per million input tokens, in dollars. Null if unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_million_input_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        public global::Baseten.AnyOf<double?, string>? CostPerMillionInputTokens { get; set; }

        /// <summary>
        /// Effective cost per million output tokens, in dollars. Null if unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_million_output_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        public global::Baseten.AnyOf<double?, string>? CostPerMillionOutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAPITeamDetailsV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Organization Shared Endpoint ID.
        /// </param>
        /// <param name="teamId">
        /// Team that has added this Model API.
        /// </param>
        /// <param name="teamName">
        /// Name of the team that has added this Model API.
        /// </param>
        /// <param name="addedAt">
        /// When the team first added this Model API.
        /// </param>
        /// <param name="rateLimits">
        /// Effective rate limits for this team's Model API, at most one per type, unit, and service tier.
        /// </param>
        /// <param name="lastUsedAt">
        /// When the team last invoked this Model API. Null if never invoked.
        /// </param>
        /// <param name="costPerMillionInputTokens">
        /// Effective cost per million input tokens, in dollars. Null if unavailable.
        /// </param>
        /// <param name="costPerMillionOutputTokens">
        /// Effective cost per million output tokens, in dollars. Null if unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelAPITeamDetailsV1(
            string id,
            string teamId,
            string teamName,
            global::System.DateTime addedAt,
            global::System.Collections.Generic.IList<global::Baseten.ModelAPIRateLimitV1> rateLimits,
            global::System.DateTime? lastUsedAt,
            global::Baseten.AnyOf<double?, string>? costPerMillionInputTokens,
            global::Baseten.AnyOf<double?, string>? costPerMillionOutputTokens)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
            this.AddedAt = addedAt;
            this.LastUsedAt = lastUsedAt;
            this.RateLimits = rateLimits ?? throw new global::System.ArgumentNullException(nameof(rateLimits));
            this.CostPerMillionInputTokens = costPerMillionInputTokens;
            this.CostPerMillionOutputTokens = costPerMillionOutputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAPITeamDetailsV1" /> class.
        /// </summary>
        public ModelAPITeamDetailsV1()
        {
        }

    }
}