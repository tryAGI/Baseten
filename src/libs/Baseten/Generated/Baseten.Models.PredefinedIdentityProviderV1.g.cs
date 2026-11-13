
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PredefinedIdentityProviderV1
    {
        /// <summary>
        /// Pass as `kind` when adding the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.PredefinedIdentityProviderKindV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.PredefinedIdentityProviderKindV1 Kind { get; set; }

        /// <summary>
        /// Display name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The `iss` claim its tokens carry. Null when each account, tenant, or cluster has its own issuer, which you pass as `issuer_url` when adding the provider.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_url")]
        public string? IssuerUrl { get; set; }

        /// <summary>
        /// An example of the `issuer_url` to pass. Null when the issuer is fixed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer_url_example")]
        public string? IssuerUrlExample { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredefinedIdentityProviderV1" /> class.
        /// </summary>
        /// <param name="kind">
        /// Pass as `kind` when adding the provider
        /// </param>
        /// <param name="name">
        /// Display name
        /// </param>
        /// <param name="issuerUrl">
        /// The `iss` claim its tokens carry. Null when each account, tenant, or cluster has its own issuer, which you pass as `issuer_url` when adding the provider.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="issuerUrlExample">
        /// An example of the `issuer_url` to pass. Null when the issuer is fixed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredefinedIdentityProviderV1(
            global::Baseten.PredefinedIdentityProviderKindV1 kind,
            string name,
            string? issuerUrl,
            string? issuerUrlExample)
        {
            this.Kind = kind;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IssuerUrl = issuerUrl;
            this.IssuerUrlExample = issuerUrlExample;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredefinedIdentityProviderV1" /> class.
        /// </summary>
        public PredefinedIdentityProviderV1()
        {
        }

    }
}