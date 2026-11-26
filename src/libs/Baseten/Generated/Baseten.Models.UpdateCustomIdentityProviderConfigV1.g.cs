
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Settings of a custom identity provider to change.
    /// </summary>
    public sealed partial class UpdateCustomIdentityProviderConfigV1
    {
        /// <summary>
        /// Where the provider's signing keys are; checked like when adding it
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
        /// Initializes a new instance of the <see cref="UpdateCustomIdentityProviderConfigV1" /> class.
        /// </summary>
        /// <param name="jwks">
        /// Where the provider's signing keys are; checked like when adding it
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateCustomIdentityProviderConfigV1(
            global::Baseten.RequestIdentityProviderJwksV1 jwks)
        {
            this.Jwks = jwks ?? throw new global::System.ArgumentNullException(nameof(jwks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomIdentityProviderConfigV1" /> class.
        /// </summary>
        public UpdateCustomIdentityProviderConfigV1()
        {
        }

    }
}