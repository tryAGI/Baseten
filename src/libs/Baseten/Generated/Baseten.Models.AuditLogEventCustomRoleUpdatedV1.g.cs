
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A custom role was updated.
    /// </summary>
    public sealed partial class AuditLogEventCustomRoleUpdatedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"CUSTOM_ROLE_UPDATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "CUSTOM_ROLE_UPDATED";

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
        /// The fields the update changed, keyed by field name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Baseten.AuditFieldChangeV1> Changes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventCustomRoleUpdatedV1" /> class.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="name"></param>
        /// <param name="changes">
        /// The fields the update changed, keyed by field name.
        /// </param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventCustomRoleUpdatedV1(
            string roleId,
            string name,
            global::System.Collections.Generic.Dictionary<string, global::Baseten.AuditFieldChangeV1> changes,
            string eventType = "CUSTOM_ROLE_UPDATED")
        {
            this.EventType = eventType;
            this.RoleId = roleId ?? throw new global::System.ArgumentNullException(nameof(roleId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Changes = changes ?? throw new global::System.ArgumentNullException(nameof(changes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventCustomRoleUpdatedV1" /> class.
        /// </summary>
        public AuditLogEventCustomRoleUpdatedV1()
        {
        }

    }
}