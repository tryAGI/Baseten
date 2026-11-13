
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A trust rule was created.
    /// </summary>
    public sealed partial class AuditLogEventTrustRuleCreatedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"TRUST_RULE_CREATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "TRUST_RULE_CREATED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trust_rule_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrustRuleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Null when the rule was created without one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdentityProviderId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        /// The CEL expression a token's claims must satisfy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Condition { get; set; }

        /// <summary>
        /// The `aud` claim a token must carry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audience { get; set; }

        /// <summary>
        /// The longest lifetime, in seconds, of an access token the rule issues.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_access_token_lifetime_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxAccessTokenLifetimeSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventTrustRuleCreatedV1" /> class.
        /// </summary>
        /// <param name="trustRuleId"></param>
        /// <param name="name"></param>
        /// <param name="identityProviderId"></param>
        /// <param name="serviceAccountId"></param>
        /// <param name="condition">
        /// The CEL expression a token's claims must satisfy.
        /// </param>
        /// <param name="audience">
        /// The `aud` claim a token must carry.
        /// </param>
        /// <param name="maxAccessTokenLifetimeSeconds">
        /// The longest lifetime, in seconds, of an access token the rule issues.
        /// </param>
        /// <param name="description">
        /// Null when the rule was created without one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventTrustRuleCreatedV1(
            string trustRuleId,
            string name,
            string identityProviderId,
            string serviceAccountId,
            string condition,
            string audience,
            int maxAccessTokenLifetimeSeconds,
            string? description,
            string eventType = "TRUST_RULE_CREATED")
        {
            this.EventType = eventType;
            this.TrustRuleId = trustRuleId ?? throw new global::System.ArgumentNullException(nameof(trustRuleId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.IdentityProviderId = identityProviderId ?? throw new global::System.ArgumentNullException(nameof(identityProviderId));
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.Audience = audience ?? throw new global::System.ArgumentNullException(nameof(audience));
            this.MaxAccessTokenLifetimeSeconds = maxAccessTokenLifetimeSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventTrustRuleCreatedV1" /> class.
        /// </summary>
        public AuditLogEventTrustRuleCreatedV1()
        {
        }

    }
}