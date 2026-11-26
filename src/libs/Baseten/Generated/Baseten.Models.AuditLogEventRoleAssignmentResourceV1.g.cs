
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A resource a role assignment is limited to. Not itself an event payload.
    /// </summary>
    public sealed partial class AuditLogEventRoleAssignmentResourceV1
    {
        /// <summary>
        /// Type of the resource, for example `model`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceType { get; set; }

        /// <summary>
        /// ID of the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventRoleAssignmentResourceV1" /> class.
        /// </summary>
        /// <param name="resourceType">
        /// Type of the resource, for example `model`.
        /// </param>
        /// <param name="resourceId">
        /// ID of the resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventRoleAssignmentResourceV1(
            string resourceType,
            string resourceId)
        {
            this.ResourceType = resourceType ?? throw new global::System.ArgumentNullException(nameof(resourceType));
            this.ResourceId = resourceId ?? throw new global::System.ArgumentNullException(nameof(resourceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventRoleAssignmentResourceV1" /> class.
        /// </summary>
        public AuditLogEventRoleAssignmentResourceV1()
        {
        }

    }
}