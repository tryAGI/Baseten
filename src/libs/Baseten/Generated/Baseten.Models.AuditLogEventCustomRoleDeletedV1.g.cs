
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A custom role was deleted.
    /// </summary>
    public sealed partial class AuditLogEventCustomRoleDeletedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"CUSTOM_ROLE_DELETED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "CUSTOM_ROLE_DELETED";

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventCustomRoleDeletedV1" /> class.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="name"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventCustomRoleDeletedV1(
            string roleId,
            string name,
            string eventType = "CUSTOM_ROLE_DELETED")
        {
            this.EventType = eventType;
            this.RoleId = roleId ?? throw new global::System.ArgumentNullException(nameof(roleId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventCustomRoleDeletedV1" /> class.
        /// </summary>
        public AuditLogEventCustomRoleDeletedV1()
        {
        }

    }
}