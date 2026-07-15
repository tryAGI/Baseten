
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A user was invited to the organization.
    /// </summary>
    public sealed partial class AuditLogEventUserInvitedV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"USER_INVITED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "USER_INVITED";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invited_user_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InvitedUserEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventUserInvitedV1" /> class.
        /// </summary>
        /// <param name="invitedUserEmail"></param>
        /// <param name="roleName"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventUserInvitedV1(
            string invitedUserEmail,
            string roleName,
            string eventType = "USER_INVITED")
        {
            this.EventType = eventType;
            this.InvitedUserEmail = invitedUserEmail ?? throw new global::System.ArgumentNullException(nameof(invitedUserEmail));
            this.RoleName = roleName ?? throw new global::System.ArgumentNullException(nameof(roleName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventUserInvitedV1" /> class.
        /// </summary>
        public AuditLogEventUserInvitedV1()
        {
        }

    }
}