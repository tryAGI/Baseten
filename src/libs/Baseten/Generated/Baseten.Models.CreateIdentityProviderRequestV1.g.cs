
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to add an identity provider.
    /// </summary>
    public sealed partial class CreateIdentityProviderRequestV1
    {
        /// <summary>
        /// Name, unique in the organization. Defaults to the provider's display name, so pass one when adding a second issuer of the same provider.<br/>
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
        /// The predefined provider to add
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predefined")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.CreatePredefinedIdentityProviderConfigV1 Predefined { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIdentityProviderRequestV1" /> class.
        /// </summary>
        /// <param name="predefined">
        /// The predefined provider to add
        /// </param>
        /// <param name="name">
        /// Name, unique in the organization. Defaults to the provider's display name, so pass one when adding a second issuer of the same provider.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Optional description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIdentityProviderRequestV1(
            global::Baseten.CreatePredefinedIdentityProviderConfigV1 predefined,
            string? name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
            this.Predefined = predefined ?? throw new global::System.ArgumentNullException(nameof(predefined));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIdentityProviderRequestV1" /> class.
        /// </summary>
        public CreateIdentityProviderRequestV1()
        {
        }

    }
}