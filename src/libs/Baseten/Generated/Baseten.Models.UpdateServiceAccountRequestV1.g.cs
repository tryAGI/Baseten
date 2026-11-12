
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to update a service account. Only the fields sent change.
    /// </summary>
    public sealed partial class UpdateServiceAccountRequestV1
    {
        /// <summary>
        /// Name, unique in the organization<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description, up to 1,024 characters; null clears it<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Disable the account to stop it being used, or enable it again<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// Replaces the account's access as a whole. Temporary; may be removed once fine-grained access control is available.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset_permissions")]
        public global::Baseten.ServiceAccountPresetPermissionsRequestV1? PresetPermissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateServiceAccountRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name, unique in the organization<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Description, up to 1,024 characters; null clears it<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="disabled">
        /// Disable the account to stop it being used, or enable it again<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="presetPermissions">
        /// Replaces the account's access as a whole. Temporary; may be removed once fine-grained access control is available.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateServiceAccountRequestV1(
            string? name,
            string? description,
            bool? disabled,
            global::Baseten.ServiceAccountPresetPermissionsRequestV1? presetPermissions)
        {
            this.Name = name;
            this.Description = description;
            this.Disabled = disabled;
            this.PresetPermissions = presetPermissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateServiceAccountRequestV1" /> class.
        /// </summary>
        public UpdateServiceAccountRequestV1()
        {
        }

    }
}