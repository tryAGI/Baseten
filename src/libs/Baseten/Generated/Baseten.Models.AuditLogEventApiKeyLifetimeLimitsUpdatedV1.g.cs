
#nullable enable

namespace Baseten
{
    /// <summary>
    /// An administrator updated the organization's API key lifetime limits.
    /// </summary>
    public sealed partial class AuditLogEventApiKeyLifetimeLimitsUpdatedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"API_KEY_LIFETIME_LIMITS_UPDATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "API_KEY_LIFETIME_LIMITS_UPDATED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_personal_limit_days")]
        public int? PreviousPersonalLimitDays { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_personal_limit_days")]
        public int? NewPersonalLimitDays { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_team_limit_days")]
        public int? PreviousTeamLimitDays { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_team_limit_days")]
        public int? NewTeamLimitDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventApiKeyLifetimeLimitsUpdatedV1" /> class.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="previousPersonalLimitDays"></param>
        /// <param name="newPersonalLimitDays"></param>
        /// <param name="previousTeamLimitDays"></param>
        /// <param name="newTeamLimitDays"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventApiKeyLifetimeLimitsUpdatedV1(
            string organizationId,
            int? previousPersonalLimitDays,
            int? newPersonalLimitDays,
            int? previousTeamLimitDays,
            int? newTeamLimitDays,
            string eventType = "API_KEY_LIFETIME_LIMITS_UPDATED")
        {
            this.EventType = eventType;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.PreviousPersonalLimitDays = previousPersonalLimitDays;
            this.NewPersonalLimitDays = newPersonalLimitDays;
            this.PreviousTeamLimitDays = previousTeamLimitDays;
            this.NewTeamLimitDays = newTeamLimitDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventApiKeyLifetimeLimitsUpdatedV1" /> class.
        /// </summary>
        public AuditLogEventApiKeyLifetimeLimitsUpdatedV1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AuditLogEventApiKeyLifetimeLimitsUpdatedV1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AuditLogEventApiKeyLifetimeLimitsUpdatedV1 FromOrganizationId(string organizationId)
        {
            return new AuditLogEventApiKeyLifetimeLimitsUpdatedV1
            {
                OrganizationId = organizationId,
            };
        }

    }
}