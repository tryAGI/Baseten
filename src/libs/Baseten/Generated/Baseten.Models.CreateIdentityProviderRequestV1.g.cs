
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to add an identity provider.
    /// </summary>
    public sealed partial class CreateIdentityProviderRequestV1
    {
        /// <summary>
        /// Name, unique in the organization. Required for a custom provider. A predefined provider defaults to its display name, so pass one when adding a second issuer of the same provider.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The predefined provider to add. Pass this or `custom`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predefined")]
        public global::Baseten.CreatePredefinedIdentityProviderConfigV1? Predefined { get; set; }

        /// <summary>
        /// The custom provider to add. Pass this or `predefined`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        public global::Baseten.CreateCustomIdentityProviderConfigV1? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIdentityProviderRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name, unique in the organization. Required for a custom provider. A predefined provider defaults to its display name, so pass one when adding a second issuer of the same provider.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Optional description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="predefined">
        /// The predefined provider to add. Pass this or `custom`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="custom">
        /// The custom provider to add. Pass this or `predefined`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIdentityProviderRequestV1(
            string? name,
            string? description,
            global::Baseten.CreatePredefinedIdentityProviderConfigV1? predefined,
            global::Baseten.CreateCustomIdentityProviderConfigV1? custom)
        {
            this.Name = name;
            this.Description = description;
            this.Predefined = predefined;
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIdentityProviderRequestV1" /> class.
        /// </summary>
        public CreateIdentityProviderRequestV1()
        {
        }

    }
}