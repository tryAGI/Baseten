
#nullable enable

namespace Baseten
{
    /// <summary>
    /// An OIDC issuer whose tokens the organization accepts for workload identity federation.
    /// </summary>
    public sealed partial class IdentityProviderV1
    {
        /// <summary>
        /// Identity provider ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name, unique in the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Settings of the predefined provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predefined")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.PredefinedIdentityProviderConfigV1 Predefined { get; set; }

        /// <summary>
        /// ID of the user who added the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedBy { get; set; }

        /// <summary>
        /// Time the provider was added
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time the provider was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Identity provider ID
        /// </param>
        /// <param name="name">
        /// Name, unique in the organization
        /// </param>
        /// <param name="predefined">
        /// Settings of the predefined provider
        /// </param>
        /// <param name="createdBy">
        /// ID of the user who added the provider
        /// </param>
        /// <param name="createdAt">
        /// Time the provider was added
        /// </param>
        /// <param name="updatedAt">
        /// Time the provider was last updated
        /// </param>
        /// <param name="description">
        /// Description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IdentityProviderV1(
            string id,
            string name,
            global::Baseten.PredefinedIdentityProviderConfigV1 predefined,
            string createdBy,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Predefined = predefined ?? throw new global::System.ArgumentNullException(nameof(predefined));
            this.CreatedBy = createdBy ?? throw new global::System.ArgumentNullException(nameof(createdBy));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProviderV1" /> class.
        /// </summary>
        public IdentityProviderV1()
        {
        }

    }
}