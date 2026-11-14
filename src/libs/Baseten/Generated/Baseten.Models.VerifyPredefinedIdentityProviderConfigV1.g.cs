
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Settings of the predefined identity provider to check.
    /// </summary>
    public sealed partial class VerifyPredefinedIdentityProviderConfigV1
    {
        /// <summary>
        /// Which predefined provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.PredefinedIdentityProviderKindV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.PredefinedIdentityProviderKindV1 Kind { get; set; }

        /// <summary>
        /// The issuer to check, for AWS IAM, Amazon EKS, Azure managed identity, and Azure Kubernetes Service, in the format the predefined identity providers endpoint shows<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_url")]
        public string? IssuerUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyPredefinedIdentityProviderConfigV1" /> class.
        /// </summary>
        /// <param name="kind">
        /// Which predefined provider
        /// </param>
        /// <param name="issuerUrl">
        /// The issuer to check, for AWS IAM, Amazon EKS, Azure managed identity, and Azure Kubernetes Service, in the format the predefined identity providers endpoint shows<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyPredefinedIdentityProviderConfigV1(
            global::Baseten.PredefinedIdentityProviderKindV1 kind,
            string? issuerUrl)
        {
            this.Kind = kind;
            this.IssuerUrl = issuerUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyPredefinedIdentityProviderConfigV1" /> class.
        /// </summary>
        public VerifyPredefinedIdentityProviderConfigV1()
        {
        }

    }
}