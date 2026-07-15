
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A directory group's role was updated.
    /// </summary>
    public sealed partial class AuditLogEventDirectoryGroupRoleUpdatedV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"DIRECTORY_GROUP_ROLE_UPDATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "DIRECTORY_GROUP_ROLE_UPDATED";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directory_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DirectoryGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directory_group_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DirectoryGroupName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_role_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewRoleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        public string? TeamName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventDirectoryGroupRoleUpdatedV1" /> class.
        /// </summary>
        /// <param name="directoryGroupId"></param>
        /// <param name="directoryGroupName"></param>
        /// <param name="newRoleName"></param>
        /// <param name="teamId"></param>
        /// <param name="teamName"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventDirectoryGroupRoleUpdatedV1(
            string directoryGroupId,
            string directoryGroupName,
            string newRoleName,
            string? teamId,
            string? teamName,
            string eventType = "DIRECTORY_GROUP_ROLE_UPDATED")
        {
            this.EventType = eventType;
            this.DirectoryGroupId = directoryGroupId ?? throw new global::System.ArgumentNullException(nameof(directoryGroupId));
            this.DirectoryGroupName = directoryGroupName ?? throw new global::System.ArgumentNullException(nameof(directoryGroupName));
            this.NewRoleName = newRoleName ?? throw new global::System.ArgumentNullException(nameof(newRoleName));
            this.TeamId = teamId;
            this.TeamName = teamName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventDirectoryGroupRoleUpdatedV1" /> class.
        /// </summary>
        public AuditLogEventDirectoryGroupRoleUpdatedV1()
        {
        }

    }
}