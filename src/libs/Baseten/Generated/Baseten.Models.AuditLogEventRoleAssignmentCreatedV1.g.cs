
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A role was assigned to a user or directory group.
    /// </summary>
    public sealed partial class AuditLogEventRoleAssignmentCreatedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"ROLE_ASSIGNMENT_CREATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "ROLE_ASSIGNMENT_CREATED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_assignment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleAssignmentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleName { get; set; }

        /// <summary>
        /// Who holds the role: `user` or `directory_group`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubjectType { get; set; }

        /// <summary>
        /// ID of the user or directory group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubjectId { get; set; }

        /// <summary>
        /// The team the role applies in. Null for organization roles.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// When set, the role applies only to what any of these sets matches. A set matches what every resource in its `all_of` matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_sets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AuditLogEventRoleAssignmentResourceSetV1> ResourceSets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventRoleAssignmentCreatedV1" /> class.
        /// </summary>
        /// <param name="roleAssignmentId"></param>
        /// <param name="roleId"></param>
        /// <param name="roleName"></param>
        /// <param name="subjectType">
        /// Who holds the role: `user` or `directory_group`.
        /// </param>
        /// <param name="subjectId">
        /// ID of the user or directory group.
        /// </param>
        /// <param name="resourceSets">
        /// When set, the role applies only to what any of these sets matches. A set matches what every resource in its `all_of` matches.
        /// </param>
        /// <param name="teamId">
        /// The team the role applies in. Null for organization roles.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventRoleAssignmentCreatedV1(
            string roleAssignmentId,
            string roleId,
            string roleName,
            string subjectType,
            string subjectId,
            global::System.Collections.Generic.IList<global::Baseten.AuditLogEventRoleAssignmentResourceSetV1> resourceSets,
            string? teamId,
            string eventType = "ROLE_ASSIGNMENT_CREATED")
        {
            this.EventType = eventType;
            this.RoleAssignmentId = roleAssignmentId ?? throw new global::System.ArgumentNullException(nameof(roleAssignmentId));
            this.RoleId = roleId ?? throw new global::System.ArgumentNullException(nameof(roleId));
            this.RoleName = roleName ?? throw new global::System.ArgumentNullException(nameof(roleName));
            this.SubjectType = subjectType ?? throw new global::System.ArgumentNullException(nameof(subjectType));
            this.SubjectId = subjectId ?? throw new global::System.ArgumentNullException(nameof(subjectId));
            this.TeamId = teamId;
            this.ResourceSets = resourceSets ?? throw new global::System.ArgumentNullException(nameof(resourceSets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventRoleAssignmentCreatedV1" /> class.
        /// </summary>
        public AuditLogEventRoleAssignmentCreatedV1()
        {
        }

    }
}