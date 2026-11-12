
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A named service account that workload identity federation tokens act as.
    /// </summary>
    public sealed partial class ServiceAccountV1
    {
        /// <summary>
        /// Service account ID
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
        /// The team that owns the account. Null for an organization account.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// What the service account may do. Temporary; may be removed once fine-grained access control is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset_permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.ServiceAccountPresetPermissionsV1 PresetPermissions { get; set; }

        /// <summary>
        /// Whether the account is disabled. A disabled account can't be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Disabled { get; set; }

        /// <summary>
        /// Last time a token was exchanged for this account. Null until the first.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// Time the account was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time the account was last updated
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
        /// Initializes a new instance of the <see cref="ServiceAccountV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Service account ID
        /// </param>
        /// <param name="name">
        /// Name, unique in the organization
        /// </param>
        /// <param name="presetPermissions">
        /// What the service account may do. Temporary; may be removed once fine-grained access control is available.
        /// </param>
        /// <param name="disabled">
        /// Whether the account is disabled. A disabled account can't be used.
        /// </param>
        /// <param name="createdAt">
        /// Time the account was created
        /// </param>
        /// <param name="updatedAt">
        /// Time the account was last updated
        /// </param>
        /// <param name="description">
        /// Description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="teamId">
        /// The team that owns the account. Null for an organization account.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="lastUsedAt">
        /// Last time a token was exchanged for this account. Null until the first.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceAccountV1(
            string id,
            string name,
            global::Baseten.ServiceAccountPresetPermissionsV1 presetPermissions,
            bool disabled,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            string? teamId,
            global::System.DateTime? lastUsedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.TeamId = teamId;
            this.PresetPermissions = presetPermissions ?? throw new global::System.ArgumentNullException(nameof(presetPermissions));
            this.Disabled = disabled;
            this.LastUsedAt = lastUsedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAccountV1" /> class.
        /// </summary>
        public ServiceAccountV1()
        {
        }

    }
}