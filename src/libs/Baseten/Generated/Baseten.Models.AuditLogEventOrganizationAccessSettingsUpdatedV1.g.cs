
#nullable enable

namespace Baseten
{
    /// <summary>
    /// An administrator changed whether team admins manage their team's custom roles.
    /// </summary>
    public sealed partial class AuditLogEventOrganizationAccessSettingsUpdatedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"ORGANIZATION_ACCESS_SETTINGS_UPDATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "ORGANIZATION_ACCESS_SETTINGS_UPDATED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_allow_team_admins_to_manage_roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PreviousAllowTeamAdminsToManageRoles { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_allow_team_admins_to_manage_roles")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool NewAllowTeamAdminsToManageRoles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventOrganizationAccessSettingsUpdatedV1" /> class.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="previousAllowTeamAdminsToManageRoles"></param>
        /// <param name="newAllowTeamAdminsToManageRoles"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventOrganizationAccessSettingsUpdatedV1(
            string organizationId,
            bool previousAllowTeamAdminsToManageRoles,
            bool newAllowTeamAdminsToManageRoles,
            string eventType = "ORGANIZATION_ACCESS_SETTINGS_UPDATED")
        {
            this.EventType = eventType;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.PreviousAllowTeamAdminsToManageRoles = previousAllowTeamAdminsToManageRoles;
            this.NewAllowTeamAdminsToManageRoles = newAllowTeamAdminsToManageRoles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventOrganizationAccessSettingsUpdatedV1" /> class.
        /// </summary>
        public AuditLogEventOrganizationAccessSettingsUpdatedV1()
        {
        }

    }
}