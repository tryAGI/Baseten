
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to check a trust rule's condition and audience before saving them.
    /// </summary>
    public sealed partial class VerifyAccessTrustRuleRequestV1
    {
        /// <summary>
        /// The identity provider the rule is for, which decides the claims it must pin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdentityProviderId { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyAccessTrustRuleRequestV1" /> class.
        /// </summary>
        /// <param name="identityProviderId">
        /// The identity provider the rule is for, which decides the claims it must pin
        /// </param>
        /// <param name="condition">
        /// A CEL expression over the token's `claims` that must evaluate to true. It must pin a specific `claims.sub` in a top-level `&amp;&amp;` clause, plus any provider-required checks. Up to 4,096 characters.
        /// </param>
        /// <param name="audience">
        /// The token's `aud` must equal this, or contain it when `aud` is a list. Up to 1,024 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyAccessTrustRuleRequestV1(
            string identityProviderId,
            string condition,
            string audience)
        {
            this.IdentityProviderId = identityProviderId ?? throw new global::System.ArgumentNullException(nameof(identityProviderId));
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.Audience = audience ?? throw new global::System.ArgumentNullException(nameof(audience));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyAccessTrustRuleRequestV1" /> class.
        /// </summary>
        public VerifyAccessTrustRuleRequestV1()
        {
        }

    }
}