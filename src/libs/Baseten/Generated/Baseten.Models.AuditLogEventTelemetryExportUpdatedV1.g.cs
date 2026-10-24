
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A telemetry export configuration was updated. `enabled` is the new value when this update<br/>
    /// paused or resumed exporting and null when only the endpoint, protocol, headers, or credential<br/>
    /// changed; a pause whose actor is the Baseten system was Baseten's own.
    /// </summary>
    public sealed partial class AuditLogEventTelemetryExportUpdatedV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("telemetry_export_configuration_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TelemetryExportConfigurationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"TELEMETRY_EXPORT_UPDATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "TELEMETRY_EXPORT_UPDATED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credential_rotated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CredentialRotated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventTelemetryExportUpdatedV1" /> class.
        /// </summary>
        /// <param name="telemetryExportConfigurationId"></param>
        /// <param name="credentialRotated"></param>
        /// <param name="enabled"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventTelemetryExportUpdatedV1(
            string telemetryExportConfigurationId,
            bool credentialRotated,
            bool? enabled,
            string eventType = "TELEMETRY_EXPORT_UPDATED")
        {
            this.TelemetryExportConfigurationId = telemetryExportConfigurationId ?? throw new global::System.ArgumentNullException(nameof(telemetryExportConfigurationId));
            this.EventType = eventType;
            this.CredentialRotated = credentialRotated;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventTelemetryExportUpdatedV1" /> class.
        /// </summary>
        public AuditLogEventTelemetryExportUpdatedV1()
        {
        }

    }
}