
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A role to give a user, service account, or directory group.
    /// </summary>
    public sealed partial class CreateAccessAssignmentRequestV1
    {
        /// <summary>
        /// ID of the role to assign
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleId { get; set; }

        /// <summary>
        /// Type of the subject to give the role to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AccessSubjectTypeV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AccessSubjectTypeV1 SubjectType { get; set; }

        /// <summary>
        /// ID of the user, service account, or directory group to give the role to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubjectId { get; set; }

        /// <summary>
        /// ID of the team to assign a team role in. Omit for an organization role.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Sets of resources the role applies to. It applies to what any set matches, and a set matches what every resource in its `all_of` matches. For example, one set for a model in staging and another for a different model in production. An environment name no deployment uses yet applies once one does. Omit for every resource where the role applies.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_sets")]
        public global::System.Collections.Generic.IList<global::Baseten.AccessResourceSetRequestV1>? ResourceSets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessAssignmentRequestV1" /> class.
        /// </summary>
        /// <param name="roleId">
        /// ID of the role to assign
        /// </param>
        /// <param name="subjectType">
        /// Type of the subject to give the role to
        /// </param>
        /// <param name="subjectId">
        /// ID of the user, service account, or directory group to give the role to
        /// </param>
        /// <param name="teamId">
        /// ID of the team to assign a team role in. Omit for an organization role.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="resourceSets">
        /// Sets of resources the role applies to. It applies to what any set matches, and a set matches what every resource in its `all_of` matches. For example, one set for a model in staging and another for a different model in production. An environment name no deployment uses yet applies once one does. Omit for every resource where the role applies.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAccessAssignmentRequestV1(
            string roleId,
            global::Baseten.AccessSubjectTypeV1 subjectType,
            string subjectId,
            string? teamId,
            global::System.Collections.Generic.IList<global::Baseten.AccessResourceSetRequestV1>? resourceSets)
        {
            this.RoleId = roleId ?? throw new global::System.ArgumentNullException(nameof(roleId));
            this.SubjectType = subjectType;
            this.SubjectId = subjectId ?? throw new global::System.ArgumentNullException(nameof(subjectId));
            this.TeamId = teamId;
            this.ResourceSets = resourceSets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccessAssignmentRequestV1" /> class.
        /// </summary>
        public CreateAccessAssignmentRequestV1()
        {
        }

    }
}