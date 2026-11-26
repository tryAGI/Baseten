
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Resources a role assignment is limited to together. Not itself an event payload.
    /// </summary>
    public sealed partial class AuditLogEventRoleAssignmentResourceSetV1
    {
        /// <summary>
        /// At most one resource and one environment, both of which a resource must match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AuditLogEventRoleAssignmentResourceV1> AllOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventRoleAssignmentResourceSetV1" /> class.
        /// </summary>
        /// <param name="allOf">
        /// At most one resource and one environment, both of which a resource must match.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventRoleAssignmentResourceSetV1(
            global::System.Collections.Generic.IList<global::Baseten.AuditLogEventRoleAssignmentResourceV1> allOf)
        {
            this.AllOf = allOf ?? throw new global::System.ArgumentNullException(nameof(allOf));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventRoleAssignmentResourceSetV1" /> class.
        /// </summary>
        public AuditLogEventRoleAssignmentResourceSetV1()
        {
        }

    }
}