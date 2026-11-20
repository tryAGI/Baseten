
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Changes to a custom role. Omitted fields are unchanged.
    /// </summary>
    public sealed partial class UpdateAccessRoleRequestV1
    {
        /// <summary>
        /// New name of the role<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New description of the role<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Names of permissions to add to the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<string>? Permissions { get; set; }

        /// <summary>
        /// Names of permissions to remove from the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions_to_delete")]
        public global::System.Collections.Generic.IList<string>? PermissionsToDelete { get; set; }

        /// <summary>
        /// IDs of built-in roles for the role to include
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_role_ids")]
        public global::System.Collections.Generic.IList<string>? IncludeRoleIds { get; set; }

        /// <summary>
        /// IDs of built-in roles for the role to stop including
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_role_ids_to_delete")]
        public global::System.Collections.Generic.IList<string>? IncludeRoleIdsToDelete { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccessRoleRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// New name of the role<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// New description of the role<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="permissions">
        /// Names of permissions to add to the role
        /// </param>
        /// <param name="permissionsToDelete">
        /// Names of permissions to remove from the role
        /// </param>
        /// <param name="includeRoleIds">
        /// IDs of built-in roles for the role to include
        /// </param>
        /// <param name="includeRoleIdsToDelete">
        /// IDs of built-in roles for the role to stop including
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAccessRoleRequestV1(
            string? name,
            string? description,
            global::System.Collections.Generic.IList<string>? permissions,
            global::System.Collections.Generic.IList<string>? permissionsToDelete,
            global::System.Collections.Generic.IList<string>? includeRoleIds,
            global::System.Collections.Generic.IList<string>? includeRoleIdsToDelete)
        {
            this.Name = name;
            this.Description = description;
            this.Permissions = permissions;
            this.PermissionsToDelete = permissionsToDelete;
            this.IncludeRoleIds = includeRoleIds;
            this.IncludeRoleIdsToDelete = includeRoleIdsToDelete;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAccessRoleRequestV1" /> class.
        /// </summary>
        public UpdateAccessRoleRequestV1()
        {
        }

    }
}