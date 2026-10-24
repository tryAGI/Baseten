
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A telemetry export configuration was created.
    /// </summary>
    public sealed partial class AuditLogEventTelemetryExportCreatedV1
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
        /// <default>"TELEMETRY_EXPORT_CREATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "TELEMETRY_EXPORT_CREATED";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventTelemetryExportCreatedV1" /> class.
        /// </summary>
        /// <param name="telemetryExportConfigurationId"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventTelemetryExportCreatedV1(
            string telemetryExportConfigurationId,
            string eventType = "TELEMETRY_EXPORT_CREATED")
        {
            this.TelemetryExportConfigurationId = telemetryExportConfigurationId ?? throw new global::System.ArgumentNullException(nameof(telemetryExportConfigurationId));
            this.EventType = eventType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventTelemetryExportCreatedV1" /> class.
        /// </summary>
        public AuditLogEventTelemetryExportCreatedV1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AuditLogEventTelemetryExportCreatedV1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AuditLogEventTelemetryExportCreatedV1 FromTelemetryExportConfigurationId(string telemetryExportConfigurationId)
        {
            return new AuditLogEventTelemetryExportCreatedV1
            {
                TelemetryExportConfigurationId = telemetryExportConfigurationId,
            };
        }

    }
}