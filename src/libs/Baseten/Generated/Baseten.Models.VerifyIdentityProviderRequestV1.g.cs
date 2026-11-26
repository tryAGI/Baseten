
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to check an identity provider before adding it.
    /// </summary>
    public sealed partial class VerifyIdentityProviderRequestV1
    {
        /// <summary>
        /// The predefined provider to check, as you'd pass it when adding it. Pass this or `custom`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predefined")]
        public global::Baseten.VerifyPredefinedIdentityProviderConfigV1? Predefined { get; set; }

        /// <summary>
        /// The custom provider to check, as you'd pass it when adding it. Pass this or `predefined`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        public global::Baseten.VerifyCustomIdentityProviderConfigV1? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyIdentityProviderRequestV1" /> class.
        /// </summary>
        /// <param name="predefined">
        /// The predefined provider to check, as you'd pass it when adding it. Pass this or `custom`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="custom">
        /// The custom provider to check, as you'd pass it when adding it. Pass this or `predefined`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VerifyIdentityProviderRequestV1(
            global::Baseten.VerifyPredefinedIdentityProviderConfigV1? predefined,
            global::Baseten.VerifyCustomIdentityProviderConfigV1? custom)
        {
            this.Predefined = predefined;
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyIdentityProviderRequestV1" /> class.
        /// </summary>
        public VerifyIdentityProviderRequestV1()
        {
        }

    }
}