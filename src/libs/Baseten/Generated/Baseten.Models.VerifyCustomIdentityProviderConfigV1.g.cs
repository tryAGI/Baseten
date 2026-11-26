
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Settings of the custom identity provider to check.
    /// </summary>
    public sealed partial class VerifyCustomIdentityProviderConfigV1
    {
        /// <summary>
        /// The `iss` claim of the provider's tokens, matched exactly
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuerUrl { get; set; }

        /// <summary>
        /// Where the provider's signing keys are
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.RequestIdentityProviderJwksV1 Jwks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyCustomIdentityProviderConfigV1" /> class.
        /// </summary>
        /// <param name="issuerUrl">
        /// The `iss` claim of the provider's tokens, matched exactly
        /// </param>
        /// <param name="jwks">
        /// Where the provider's signing keys are
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyCustomIdentityProviderConfigV1(
            string issuerUrl,
            global::Baseten.RequestIdentityProviderJwksV1 jwks)
        {
            this.IssuerUrl = issuerUrl ?? throw new global::System.ArgumentNullException(nameof(issuerUrl));
            this.Jwks = jwks ?? throw new global::System.ArgumentNullException(nameof(jwks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyCustomIdentityProviderConfigV1" /> class.
        /// </summary>
        public VerifyCustomIdentityProviderConfigV1()
        {
        }

    }
}