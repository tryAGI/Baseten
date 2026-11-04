
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A Grid machine user was created.
    /// </summary>
    public sealed partial class AuditLogEventGridMachineUserCreatedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"GRID_MACHINE_USER_CREATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "GRID_MACHINE_USER_CREATED";

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
        /// Initializes a new instance of the <see cref="AuditLogEventGridMachineUserCreatedV1" /> class.
        /// </summary>
        /// <param name="machineUserId"></param>
        /// <param name="machineUserName"></param>
        /// <param name="teamId"></param>
        /// <param name="teamName"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventGridMachineUserCreatedV1(
            string machineUserId,
            string machineUserName,
            string teamId,
            string teamName,
            string eventType = "GRID_MACHINE_USER_CREATED")
        {
            this.EventType = eventType;
            this.MachineUserId = machineUserId ?? throw new global::System.ArgumentNullException(nameof(machineUserId));
            this.MachineUserName = machineUserName ?? throw new global::System.ArgumentNullException(nameof(machineUserName));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventGridMachineUserCreatedV1" /> class.
        /// </summary>
        public AuditLogEventGridMachineUserCreatedV1()
        {
        }

    }
}