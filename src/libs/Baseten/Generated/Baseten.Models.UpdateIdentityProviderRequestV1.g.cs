
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to update an identity provider. Only the fields sent change.
    /// </summary>
    public sealed partial class UpdateIdentityProviderRequestV1
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
        /// A custom provider's settings to change. A predefined provider's can't be changed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom")]
        public global::Baseten.UpdateCustomIdentityProviderConfigV1? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIdentityProviderRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name, unique in the organization<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Description; null clears it<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="custom">
        /// A custom provider's settings to change. A predefined provider's can't be changed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateIdentityProviderRequestV1(
            string? name,
            string? description,
            global::Baseten.UpdateCustomIdentityProviderConfigV1? custom)
        {
            this.Name = name;
            this.Description = description;
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIdentityProviderRequestV1" /> class.
        /// </summary>
        public UpdateIdentityProviderRequestV1()
        {
        }

    }
}