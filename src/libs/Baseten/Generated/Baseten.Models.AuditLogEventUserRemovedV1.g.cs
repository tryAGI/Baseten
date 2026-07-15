
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A user was removed from the organization.
    /// </summary>
    public sealed partial class AuditLogEventUserRemovedV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"USER_REMOVED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "USER_REMOVED";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removed_user_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RemovedUserEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventUserRemovedV1" /> class.
        /// </summary>
        /// <param name="removedUserEmail"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventUserRemovedV1(
            string removedUserEmail,
            string eventType = "USER_REMOVED")
        {
            this.EventType = eventType;
            this.RemovedUserEmail = removedUserEmail ?? throw new global::System.ArgumentNullException(nameof(removedUserEmail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventUserRemovedV1" /> class.
        /// </summary>
        public AuditLogEventUserRemovedV1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AuditLogEventUserRemovedV1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AuditLogEventUserRemovedV1 FromRemovedUserEmail(string removedUserEmail)
        {
            return new AuditLogEventUserRemovedV1
            {
                RemovedUserEmail = removedUserEmail,
            };
        }

    }
}