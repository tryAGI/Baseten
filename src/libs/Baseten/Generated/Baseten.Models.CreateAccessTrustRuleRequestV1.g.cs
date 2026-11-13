
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to create a trust rule.
    /// </summary>
    public sealed partial class CreateAccessTrustRuleRequestV1
    {
        /// <summary>
        /// Name, unique in the organization. Can be changed later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whose tokens the rule accepts. Can't be changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdentityProviderId { get; set; }

        /// <summary>
        /// The service account its tokens act as. Can be changed later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        /// A CEL expression over the token's `claims` that must evaluate to true. It must pin a specific `claims.sub` in a top-level `&amp;&amp;` clause, plus any provider-required checks. Up to 4,096 characters. Can be changed later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Condition { get; set; }

        /// <summary>
        /// The token's `aud` must equal this, or contain it when `aud` is a list. Up to 1,024 characters. Can be changed later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audience { get; set; }

        /// <summary>
        /// Longest lifetime of a token the rule issues, 60 to 3600 seconds. Can be changed later.<br/>
        /// Default Value: 3600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_access_token_lifetime_seconds")]
        public int? MaxAccessTokenLifetimeSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessTrustRuleRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name, unique in the organization. Can be changed later.
        /// </param>
        /// <param name="identityProviderId">
        /// Whose tokens the rule accepts. Can't be changed.
        /// </param>
        /// <param name="serviceAccountId">
        /// The service account its tokens act as. Can be changed later.
        /// </param>
        /// <param name="condition">
        /// A CEL expression over the token's `claims` that must evaluate to true. It must pin a specific `claims.sub` in a top-level `&amp;&amp;` clause, plus any provider-required checks. Up to 4,096 characters. Can be changed later.
        /// </param>
        /// <param name="audience">
        /// The token's `aud` must equal this, or contain it when `aud` is a list. Up to 1,024 characters. Can be changed later.
        /// </param>
        /// <param name="description">
        /// Optional description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="maxAccessTokenLifetimeSeconds">
        /// Longest lifetime of a token the rule issues, 60 to 3600 seconds. Can be changed later.<br/>
        /// Default Value: 3600
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAccessTrustRuleRequestV1(
            string name,
            string identityProviderId,
            string serviceAccountId,
            string condition,
            string audience,
            string? description,
            int? maxAccessTokenLifetimeSeconds)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.IdentityProviderId = identityProviderId ?? throw new global::System.ArgumentNullException(nameof(identityProviderId));
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.Audience = audience ?? throw new global::System.ArgumentNullException(nameof(audience));
            this.MaxAccessTokenLifetimeSeconds = maxAccessTokenLifetimeSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessTrustRuleRequestV1" /> class.
        /// </summary>
        public CreateAccessTrustRuleRequestV1()
        {
        }

    }
}