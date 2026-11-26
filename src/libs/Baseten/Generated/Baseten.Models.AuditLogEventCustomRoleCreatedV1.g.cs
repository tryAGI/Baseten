
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A custom role was created.
    /// </summary>
    public sealed partial class AuditLogEventCustomRoleCreatedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"CUSTOM_ROLE_CREATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "CUSTOM_ROLE_CREATED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Where the role can be assigned: `organization` or `team`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// The only team a team role can be assigned in. Null when any team can use it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Null when the role was created without one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The role's own permissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>
        /// IDs of the built-in roles whose permissions the role also grants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Includes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventCustomRoleCreatedV1" /> class.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="name"></param>
        /// <param name="kind">
        /// Where the role can be assigned: `organization` or `team`.
        /// </param>
        /// <param name="permissions">
        /// The role's own permissions.
        /// </param>
        /// <param name="includes">
        /// IDs of the built-in roles whose permissions the role also grants.
        /// </param>
        /// <param name="teamId">
        /// The only team a team role can be assigned in. Null when any team can use it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Null when the role was created without one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventCustomRoleCreatedV1(
            string roleId,
            string name,
            string kind,
            global::System.Collections.Generic.IList<string> permissions,
            global::System.Collections.Generic.IList<string> includes,
            string? teamId,
            string? description,
            string eventType = "CUSTOM_ROLE_CREATED")
        {
            this.EventType = eventType;
            this.RoleId = roleId ?? throw new global::System.ArgumentNullException(nameof(roleId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.TeamId = teamId;
            this.Description = description;
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.Includes = includes ?? throw new global::System.ArgumentNullException(nameof(includes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventCustomRoleCreatedV1" /> class.
        /// </summary>
        public AuditLogEventCustomRoleCreatedV1()
        {
        }

    }
}