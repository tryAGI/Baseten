
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The roles a user or service account holds, and the permissions they grant it.
    /// </summary>
    public sealed partial class EffectiveAccessV1
    {
        /// <summary>
        /// `USER` or `SERVICE_ACCOUNT`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AccessSubjectTypeV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AccessSubjectTypeV1 SubjectType { get; set; }

        /// <summary>
        /// ID of the user or service account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubjectId { get; set; }

        /// <summary>
        /// Name of the user or service account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubjectName { get; set; }

        /// <summary>
        /// Every role held: assigned to the user or service account, or to a directory group it is in, or held through organization or team membership
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AccessAssignmentV1> Assignments { get; set; }

        /// <summary>
        /// Every permission held, and where. Null until fine-grained authorization decides your organization's requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::Baseten.EffectiveAccessPermissionV1>? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectiveAccessV1" /> class.
        /// </summary>
        /// <param name="subjectType">
        /// `USER` or `SERVICE_ACCOUNT`
        /// </param>
        /// <param name="subjectId">
        /// ID of the user or service account
        /// </param>
        /// <param name="subjectName">
        /// Name of the user or service account
        /// </param>
        /// <param name="assignments">
        /// Every role held: assigned to the user or service account, or to a directory group it is in, or held through organization or team membership
        /// </param>
        /// <param name="permissions">
        /// Every permission held, and where. Null until fine-grained authorization decides your organization's requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EffectiveAccessV1(
            global::Baseten.AccessSubjectTypeV1 subjectType,
            string subjectId,
            string subjectName,
            global::System.Collections.Generic.IList<global::Baseten.AccessAssignmentV1> assignments,
            global::System.Collections.Generic.IList<global::Baseten.EffectiveAccessPermissionV1>? permissions)
        {
            this.SubjectType = subjectType;
            this.SubjectId = subjectId ?? throw new global::System.ArgumentNullException(nameof(subjectId));
            this.SubjectName = subjectName ?? throw new global::System.ArgumentNullException(nameof(subjectName));
            this.Assignments = assignments ?? throw new global::System.ArgumentNullException(nameof(assignments));
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectiveAccessV1" /> class.
        /// </summary>
        public EffectiveAccessV1()
        {
        }

    }
}