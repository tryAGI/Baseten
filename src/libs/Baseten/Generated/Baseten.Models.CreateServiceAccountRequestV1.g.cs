
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to create a service account.
    /// </summary>
    public sealed partial class CreateServiceAccountRequestV1
    {
        /// <summary>
        /// Name, unique in the organization. Can be changed later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional description, up to 1,024 characters<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The team that owns the account. Omit for an organization account. Can't be changed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// What the service account may do. Can be changed later. Temporary; may be removed once fine-grained access control is available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset_permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.ServiceAccountPresetPermissionsRequestV1 PresetPermissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServiceAccountRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name, unique in the organization. Can be changed later.
        /// </param>
        /// <param name="presetPermissions">
        /// What the service account may do. Can be changed later. Temporary; may be removed once fine-grained access control is available.
        /// </param>
        /// <param name="description">
        /// Optional description, up to 1,024 characters<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="teamId">
        /// The team that owns the account. Omit for an organization account. Can't be changed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateServiceAccountRequestV1(
            string name,
            global::Baseten.ServiceAccountPresetPermissionsRequestV1 presetPermissions,
            string? description,
            string? teamId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.TeamId = teamId;
            this.PresetPermissions = presetPermissions ?? throw new global::System.ArgumentNullException(nameof(presetPermissions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServiceAccountRequestV1" /> class.
        /// </summary>
        public CreateServiceAccountRequestV1()
        {
        }

    }
}