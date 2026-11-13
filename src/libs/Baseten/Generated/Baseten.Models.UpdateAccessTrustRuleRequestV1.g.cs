
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to update a trust rule. Only the fields sent change.
    /// </summary>
    public sealed partial class UpdateAccessTrustRuleRequestV1
    {
        /// <summary>
        /// Name, unique in the organization<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description; null clears it<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A CEL expression over the token's `claims` that must evaluate to true. It must pin a specific `claims.sub` in a top-level `&amp;&amp;` clause, plus any provider-required checks. Up to 4,096 characters.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public string? Condition { get; set; }

        /// <summary>
        /// The token's `aud` must equal this, or contain it when `aud` is a list. Up to 1,024 characters.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        public string? Audience { get; set; }

        /// <summary>
        /// Longest lifetime of a token the rule issues, 60 to 3600 seconds. Tokens already issued keep their lifetime.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_access_token_lifetime_seconds")]
        public int? MaxAccessTokenLifetimeSeconds { get; set; }

        /// <summary>
        /// Moves the rule to another service account. Tokens already issued keep the old account until they expire.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        public string? ServiceAccountId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccessTrustRuleRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name, unique in the organization<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Description; null clears it<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="condition">
        /// A CEL expression over the token's `claims` that must evaluate to true. It must pin a specific `claims.sub` in a top-level `&amp;&amp;` clause, plus any provider-required checks. Up to 4,096 characters.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="audience">
        /// The token's `aud` must equal this, or contain it when `aud` is a list. Up to 1,024 characters.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="maxAccessTokenLifetimeSeconds">
        /// Longest lifetime of a token the rule issues, 60 to 3600 seconds. Tokens already issued keep their lifetime.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="serviceAccountId">
        /// Moves the rule to another service account. Tokens already issued keep the old account until they expire.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAccessTrustRuleRequestV1(
            string? name,
            string? description,
            string? condition,
            string? audience,
            int? maxAccessTokenLifetimeSeconds,
            string? serviceAccountId)
        {
            this.Name = name;
            this.Description = description;
            this.Condition = condition;
            this.Audience = audience;
            this.MaxAccessTokenLifetimeSeconds = maxAccessTokenLifetimeSeconds;
            this.ServiceAccountId = serviceAccountId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccessTrustRuleRequestV1" /> class.
        /// </summary>
        public UpdateAccessTrustRuleRequestV1()
        {
        }

    }
}