
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A user joined the organization.
    /// </summary>
    public sealed partial class AuditLogEventUserJoinedOrganizationV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"USER_JOINED_ORGANIZATION"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "USER_JOINED_ORGANIZATION";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_user_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewUserEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventUserJoinedOrganizationV1" /> class.
        /// </summary>
        /// <param name="newUserEmail"></param>
        /// <param name="userId"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventUserJoinedOrganizationV1(
            string newUserEmail,
            string userId,
            string eventType = "USER_JOINED_ORGANIZATION")
        {
            this.EventType = eventType;
            this.NewUserEmail = newUserEmail ?? throw new global::System.ArgumentNullException(nameof(newUserEmail));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventUserJoinedOrganizationV1" /> class.
        /// </summary>
        public AuditLogEventUserJoinedOrganizationV1()
        {
        }

    }
}