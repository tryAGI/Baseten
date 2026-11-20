
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A role held by a user, service account, or directory group, for the organization or in a<br/>
    /// team.
    /// </summary>
    public sealed partial class AccessAssignmentV1
    {
        /// <summary>
        /// Unique identifier of the role assignment. Null for a built-in role held through organization or team membership.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// `ASSIGNMENT` for a role assignment, or `MEMBERSHIP` for a built-in role held as an organization or team member
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("granted_via")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AccessGrantedViaV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AccessGrantedViaV1 GrantedVia { get; set; }

        /// <summary>
        /// ID of the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleId { get; set; }

        /// <summary>
        /// Name of the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleName { get; set; }

        /// <summary>
        /// Type of the subject that holds the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AccessSubjectTypeV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AccessSubjectTypeV1 SubjectType { get; set; }

        /// <summary>
        /// ID of the user, service account, or directory group that holds the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubjectId { get; set; }

        /// <summary>
        /// Name of the user, service account, or directory group that holds the role
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubjectName { get; set; }

        /// <summary>
        /// ID of the team the role applies in. Null for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Name of the team the role applies in. Null for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        public string? TeamName { get; set; }

        /// <summary>
        /// Resources the role applies to. Null for every resource where it applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::System.Collections.Generic.IList<global::Baseten.AccessResourceV1>? Resources { get; set; }

        /// <summary>
        /// Names of the environments the role applies in, such as `production`. Null for every environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        public global::System.Collections.Generic.IList<string>? Environments { get; set; }

        /// <summary>
        /// ID of the user who assigned the role. Null for a role held through membership, or one no user assigned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Time the role was assigned. Null for a role held through membership.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessAssignmentV1" /> class.
        /// </summary>
        /// <param name="grantedVia">
        /// `ASSIGNMENT` for a role assignment, or `MEMBERSHIP` for a built-in role held as an organization or team member
        /// </param>
        /// <param name="roleId">
        /// ID of the role
        /// </param>
        /// <param name="roleName">
        /// Name of the role
        /// </param>
        /// <param name="subjectType">
        /// Type of the subject that holds the role
        /// </param>
        /// <param name="subjectId">
        /// ID of the user, service account, or directory group that holds the role
        /// </param>
        /// <param name="subjectName">
        /// Name of the user, service account, or directory group that holds the role
        /// </param>
        /// <param name="id">
        /// Unique identifier of the role assignment. Null for a built-in role held through organization or team membership.
        /// </param>
        /// <param name="teamId">
        /// ID of the team the role applies in. Null for the organization.
        /// </param>
        /// <param name="teamName">
        /// Name of the team the role applies in. Null for the organization.
        /// </param>
        /// <param name="resources">
        /// Resources the role applies to. Null for every resource where it applies.
        /// </param>
        /// <param name="environments">
        /// Names of the environments the role applies in, such as `production`. Null for every environment.
        /// </param>
        /// <param name="createdBy">
        /// ID of the user who assigned the role. Null for a role held through membership, or one no user assigned.
        /// </param>
        /// <param name="createdAt">
        /// Time the role was assigned. Null for a role held through membership.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessAssignmentV1(
            global::Baseten.AccessGrantedViaV1 grantedVia,
            string roleId,
            string roleName,
            global::Baseten.AccessSubjectTypeV1 subjectType,
            string subjectId,
            string subjectName,
            string? id,
            string? teamId,
            string? teamName,
            global::System.Collections.Generic.IList<global::Baseten.AccessResourceV1>? resources,
            global::System.Collections.Generic.IList<string>? environments,
            string? createdBy,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.GrantedVia = grantedVia;
            this.RoleId = roleId ?? throw new global::System.ArgumentNullException(nameof(roleId));
            this.RoleName = roleName ?? throw new global::System.ArgumentNullException(nameof(roleName));
            this.SubjectType = subjectType;
            this.SubjectId = subjectId ?? throw new global::System.ArgumentNullException(nameof(subjectId));
            this.SubjectName = subjectName ?? throw new global::System.ArgumentNullException(nameof(subjectName));
            this.TeamId = teamId;
            this.TeamName = teamName;
            this.Resources = resources;
            this.Environments = environments;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessAssignmentV1" /> class.
        /// </summary>
        public AccessAssignmentV1()
        {
        }

    }
}