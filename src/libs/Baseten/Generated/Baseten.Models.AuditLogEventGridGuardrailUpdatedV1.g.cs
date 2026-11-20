
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A Grid guardrail was renamed, reconfigured, or turned on or off.
    /// </summary>
    public sealed partial class AuditLogEventGridGuardrailUpdatedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"GRID_GUARDRAIL_UPDATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "GRID_GUARDRAIL_UPDATED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grid_guardrail_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GridGuardrailId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guardrail_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GuardrailName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_guardrail_id")]
        public string? ProviderGuardrailId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_guardrail_version")]
        public string? ProviderGuardrailVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

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
        /// Initializes a new instance of the <see cref="AuditLogEventGridGuardrailUpdatedV1" /> class.
        /// </summary>
        /// <param name="gridGuardrailId"></param>
        /// <param name="guardrailName"></param>
        /// <param name="provider"></param>
        /// <param name="enabled"></param>
        /// <param name="teamId"></param>
        /// <param name="teamName"></param>
        /// <param name="providerGuardrailId"></param>
        /// <param name="providerGuardrailVersion"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventGridGuardrailUpdatedV1(
            string gridGuardrailId,
            string guardrailName,
            string provider,
            bool enabled,
            string teamId,
            string teamName,
            string? providerGuardrailId,
            string? providerGuardrailVersion,
            string eventType = "GRID_GUARDRAIL_UPDATED")
        {
            this.EventType = eventType;
            this.GridGuardrailId = gridGuardrailId ?? throw new global::System.ArgumentNullException(nameof(gridGuardrailId));
            this.GuardrailName = guardrailName ?? throw new global::System.ArgumentNullException(nameof(guardrailName));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.ProviderGuardrailId = providerGuardrailId;
            this.ProviderGuardrailVersion = providerGuardrailVersion;
            this.Enabled = enabled;
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventGridGuardrailUpdatedV1" /> class.
        /// </summary>
        public AuditLogEventGridGuardrailUpdatedV1()
        {
        }

    }
}