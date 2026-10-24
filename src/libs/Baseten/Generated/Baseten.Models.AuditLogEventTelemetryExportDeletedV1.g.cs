
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A telemetry export configuration was deleted.
    /// </summary>
    public sealed partial class AuditLogEventTelemetryExportDeletedV1
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
        /// <default>"TELEMETRY_EXPORT_DELETED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "TELEMETRY_EXPORT_DELETED";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventTelemetryExportDeletedV1" /> class.
        /// </summary>
        /// <param name="telemetryExportConfigurationId"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventTelemetryExportDeletedV1(
            string telemetryExportConfigurationId,
            string eventType = "TELEMETRY_EXPORT_DELETED")
        {
            this.TelemetryExportConfigurationId = telemetryExportConfigurationId ?? throw new global::System.ArgumentNullException(nameof(telemetryExportConfigurationId));
            this.EventType = eventType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventTelemetryExportDeletedV1" /> class.
        /// </summary>
        public AuditLogEventTelemetryExportDeletedV1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AuditLogEventTelemetryExportDeletedV1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AuditLogEventTelemetryExportDeletedV1 FromTelemetryExportConfigurationId(string telemetryExportConfigurationId)
        {
            return new AuditLogEventTelemetryExportDeletedV1
            {
                TelemetryExportConfigurationId = telemetryExportConfigurationId,
            };
        }

    }
}