
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A role assignment was removed.
    /// </summary>
    public sealed partial class AuditLogEventRoleAssignmentDeletedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"ROLE_ASSIGNMENT_DELETED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "ROLE_ASSIGNMENT_DELETED";

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
        /// Who held the role: `user` or `directory_group`.
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
        /// The team the role applied in. Null for organization roles.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventRoleAssignmentDeletedV1" /> class.
        /// </summary>
        /// <param name="roleAssignmentId"></param>
        /// <param name="roleId"></param>
        /// <param name="subjectType">
        /// Who held the role: `user` or `directory_group`.
        /// </param>
        /// <param name="subjectId">
        /// ID of the user or directory group.
        /// </param>
        /// <param name="teamId">
        /// The team the role applied in. Null for organization roles.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventRoleAssignmentDeletedV1(
            string roleAssignmentId,
            string roleId,
            string subjectType,
            string subjectId,
            string? teamId,
            string eventType = "ROLE_ASSIGNMENT_DELETED")
        {
            this.EventType = eventType;
            this.RoleAssignmentId = roleAssignmentId ?? throw new global::System.ArgumentNullException(nameof(roleAssignmentId));
            this.RoleId = roleId ?? throw new global::System.ArgumentNullException(nameof(roleId));
            this.SubjectType = subjectType ?? throw new global::System.ArgumentNullException(nameof(subjectType));
            this.SubjectId = subjectId ?? throw new global::System.ArgumentNullException(nameof(subjectId));
            this.TeamId = teamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventRoleAssignmentDeletedV1" /> class.
        /// </summary>
        public AuditLogEventRoleAssignmentDeletedV1()
        {
        }

    }
}