
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Which tokens from an identity provider may act as a service account.
    /// </summary>
    public sealed partial class AccessTrustRuleV1
    {
        /// <summary>
        /// Trust rule ID. Workloads pass it when they exchange a token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name, unique in the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The identity provider whose tokens it accepts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdentityProviderId { get; set; }

        /// <summary>
        /// Name of the identity provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_provider_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdentityProviderName { get; set; }

        /// <summary>
        /// The service account its tokens act as
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        /// Name of the service account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountName { get; set; }

        /// <summary>
        /// The service account's team. Null for an organization service account.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Name of the service account's team. Null for an organization service account.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        public string? TeamName { get; set; }

        /// <summary>
        /// A CEL expression over the token's `claims` that must evaluate to true. It must pin a specific `claims.sub` in a top-level `&amp;&amp;` clause, plus any provider-required checks. Up to 4,096 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Condition { get; set; }

        /// <summary>
        /// The token's `aud` must equal this, or contain it when `aud` is a list. Up to 1,024 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audience { get; set; }

        /// <summary>
        /// Longest lifetime of a token the rule issues, in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_access_token_lifetime_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxAccessTokenLifetimeSeconds { get; set; }

        /// <summary>
        /// Last token exchange through the rule. Null until the first.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// ID of the user who created the rule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// Time the rule was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time the rule was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTrustRuleV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Trust rule ID. Workloads pass it when they exchange a token.
        /// </param>
        /// <param name="name">
        /// Name, unique in the organization
        /// </param>
        /// <param name="identityProviderId">
        /// The identity provider whose tokens it accepts
        /// </param>
        /// <param name="identityProviderName">
        /// Name of the identity provider
        /// </param>
        /// <param name="serviceAccountId">
        /// The service account its tokens act as
        /// </param>
        /// <param name="serviceAccountName">
        /// Name of the service account
        /// </param>
        /// <param name="condition">
        /// A CEL expression over the token's `claims` that must evaluate to true. It must pin a specific `claims.sub` in a top-level `&amp;&amp;` clause, plus any provider-required checks. Up to 4,096 characters.
        /// </param>
        /// <param name="audience">
        /// The token's `aud` must equal this, or contain it when `aud` is a list. Up to 1,024 characters.
        /// </param>
        /// <param name="maxAccessTokenLifetimeSeconds">
        /// Longest lifetime of a token the rule issues, in seconds
        /// </param>
        /// <param name="createdBy">
        /// ID of the user who created the rule
        /// </param>
        /// <param name="createdAt">
        /// Time the rule was created
        /// </param>
        /// <param name="updatedAt">
        /// Time the rule was last updated
        /// </param>
        /// <param name="description">
        /// Description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="teamId">
        /// The service account's team. Null for an organization service account.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="teamName">
        /// Name of the service account's team. Null for an organization service account.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="lastUsedAt">
        /// Last token exchange through the rule. Null until the first.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessTrustRuleV1(
            string id,
            string name,
            string identityProviderId,
            string identityProviderName,
            string serviceAccountId,
            string serviceAccountName,
            string condition,
            string audience,
            int maxAccessTokenLifetimeSeconds,
            string createdBy,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            string? teamId,
            string? teamName,
            global::System.DateTime? lastUsedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.IdentityProviderId = identityProviderId ?? throw new global::System.ArgumentNullException(nameof(identityProviderId));
            this.IdentityProviderName = identityProviderName ?? throw new global::System.ArgumentNullException(nameof(identityProviderName));
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
            this.ServiceAccountName = serviceAccountName ?? throw new global::System.ArgumentNullException(nameof(serviceAccountName));
            this.TeamId = teamId;
            this.TeamName = teamName;
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.Audience = audience ?? throw new global::System.ArgumentNullException(nameof(audience));
            this.MaxAccessTokenLifetimeSeconds = maxAccessTokenLifetimeSeconds;
            this.LastUsedAt = lastUsedAt;
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTrustRuleV1" /> class.
        /// </summary>
        public AccessTrustRuleV1()
        {
        }

    }
}