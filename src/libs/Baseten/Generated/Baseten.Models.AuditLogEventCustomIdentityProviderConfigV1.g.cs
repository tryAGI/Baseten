
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Settings of a custom identity provider, as recorded on an identity provider event. Not<br/>
    /// itself an event payload.
    /// </summary>
    public sealed partial class AuditLogEventCustomIdentityProviderConfigV1
    {
        /// <summary>
        /// The `iss` claim of the provider's tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuerUrl { get; set; }

        /// <summary>
        /// Where the provider's signing keys are found.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Jwks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventCustomIdentityProviderConfigV1" /> class.
        /// </summary>
        /// <param name="issuerUrl">
        /// The `iss` claim of the provider's tokens.
        /// </param>
        /// <param name="jwks">
        /// Where the provider's signing keys are found.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventCustomIdentityProviderConfigV1(
            string issuerUrl,
            object jwks)
        {
            this.IssuerUrl = issuerUrl ?? throw new global::System.ArgumentNullException(nameof(issuerUrl));
            this.Jwks = jwks ?? throw new global::System.ArgumentNullException(nameof(jwks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventCustomIdentityProviderConfigV1" /> class.
        /// </summary>
        public AuditLogEventCustomIdentityProviderConfigV1()
        {
        }

    }
}