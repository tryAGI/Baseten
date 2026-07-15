
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A user's team role was updated.
    /// </summary>
    public sealed partial class AuditLogEventUserTeamRoleUpdatedV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"USER_TEAM_ROLE_UPDATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "USER_TEAM_ROLE_UPDATED";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_role_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewRoleName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventUserTeamRoleUpdatedV1" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="teamId"></param>
        /// <param name="teamName"></param>
        /// <param name="newRoleName"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventUserTeamRoleUpdatedV1(
            string userId,
            string userEmail,
            string teamId,
            string teamName,
            string newRoleName,
            string eventType = "USER_TEAM_ROLE_UPDATED")
        {
            this.EventType = eventType;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserEmail = userEmail ?? throw new global::System.ArgumentNullException(nameof(userEmail));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
            this.NewRoleName = newRoleName ?? throw new global::System.ArgumentNullException(nameof(newRoleName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventUserTeamRoleUpdatedV1" /> class.
        /// </summary>
        public AuditLogEventUserTeamRoleUpdatedV1()
        {
        }

    }
}