
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Settings of a predefined identity provider, as recorded on an identity provider event. Not<br/>
    /// itself an event payload.
    /// </summary>
    public sealed partial class AuditLogEventPredefinedIdentityProviderConfigV1
    {
        /// <summary>
        /// Which predefined provider, for example `AWS_EKS`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// The `iss` claim of the provider's tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuerUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventPredefinedIdentityProviderConfigV1" /> class.
        /// </summary>
        /// <param name="kind">
        /// Which predefined provider, for example `AWS_EKS`.
        /// </param>
        /// <param name="issuerUrl">
        /// The `iss` claim of the provider's tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventPredefinedIdentityProviderConfigV1(
            string kind,
            string issuerUrl)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.IssuerUrl = issuerUrl ?? throw new global::System.ArgumentNullException(nameof(issuerUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventPredefinedIdentityProviderConfigV1" /> class.
        /// </summary>
        public AuditLogEventPredefinedIdentityProviderConfigV1()
        {
        }

    }
}