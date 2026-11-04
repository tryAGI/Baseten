
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A Grid machine user was renamed.
    /// </summary>
    public sealed partial class AuditLogEventGridMachineUserUpdatedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"GRID_MACHINE_USER_UPDATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "GRID_MACHINE_USER_UPDATED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machine_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MachineUserId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machine_user_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MachineUserName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_machine_user_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousMachineUserName { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventGridMachineUserUpdatedV1" /> class.
        /// </summary>
        /// <param name="machineUserId"></param>
        /// <param name="machineUserName"></param>
        /// <param name="previousMachineUserName"></param>
        /// <param name="teamId"></param>
        /// <param name="teamName"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventGridMachineUserUpdatedV1(
            string machineUserId,
            string machineUserName,
            string previousMachineUserName,
            string teamId,
            string teamName,
            string eventType = "GRID_MACHINE_USER_UPDATED")
        {
            this.EventType = eventType;
            this.MachineUserId = machineUserId ?? throw new global::System.ArgumentNullException(nameof(machineUserId));
            this.MachineUserName = machineUserName ?? throw new global::System.ArgumentNullException(nameof(machineUserName));
            this.PreviousMachineUserName = previousMachineUserName ?? throw new global::System.ArgumentNullException(nameof(previousMachineUserName));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventGridMachineUserUpdatedV1" /> class.
        /// </summary>
        public AuditLogEventGridMachineUserUpdatedV1()
        {
        }

    }
}