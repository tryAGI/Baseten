
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A custom role to create.
    /// </summary>
    public sealed partial class CreateAccessRoleRequestV1
    {
        /// <summary>
        /// Name of the role, unique in your organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// `ORGANIZATION` to assign the role for the whole organization, or `TEAM` to assign it in teams
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AccessRoleKindV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AccessRoleKindV1 Kind { get; set; }

        /// <summary>
        /// For a team role, ID of the only team it can be assigned in. Omit to let any team use it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Description of the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Names of the permissions the role grants
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<string>? Permissions { get; set; }

        /// <summary>
        /// IDs of built-in roles whose permissions the role also grants, such as `baseten:reader`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_role_ids")]
        public global::System.Collections.Generic.IList<string>? IncludeRoleIds { get; set; }

        /// <summary>
        /// ID of a built-in role whose current permissions to copy into `permissions` once, leaving out those the role's kind can't hold and those not available to your organization. Unlike `include_role_ids`, later changes to that role don't apply.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_role_id")]
        public string? TemplateRoleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessRoleRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the role, unique in your organization
        /// </param>
        /// <param name="kind">
        /// `ORGANIZATION` to assign the role for the whole organization, or `TEAM` to assign it in teams
        /// </param>
        /// <param name="teamId">
        /// For a team role, ID of the only team it can be assigned in. Omit to let any team use it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Description of the role
        /// </param>
        /// <param name="permissions">
        /// Names of the permissions the role grants
        /// </param>
        /// <param name="includeRoleIds">
        /// IDs of built-in roles whose permissions the role also grants, such as `baseten:reader`
        /// </param>
        /// <param name="templateRoleId">
        /// ID of a built-in role whose current permissions to copy into `permissions` once, leaving out those the role's kind can't hold and those not available to your organization. Unlike `include_role_ids`, later changes to that role don't apply.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAccessRoleRequestV1(
            string name,
            global::Baseten.AccessRoleKindV1 kind,
            string? teamId,
            string? description,
            global::System.Collections.Generic.IList<string>? permissions,
            global::System.Collections.Generic.IList<string>? includeRoleIds,
            string? templateRoleId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Kind = kind;
            this.TeamId = teamId;
            this.Description = description;
            this.Permissions = permissions;
            this.IncludeRoleIds = includeRoleIds;
            this.TemplateRoleId = templateRoleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessRoleRequestV1" /> class.
        /// </summary>
        public CreateAccessRoleRequestV1()
        {
        }

    }
}