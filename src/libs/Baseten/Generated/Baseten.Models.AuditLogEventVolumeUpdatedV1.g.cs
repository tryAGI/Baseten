
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A volume's settings were updated.
    /// </summary>
    public sealed partial class AuditLogEventVolumeUpdatedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"VOLUME_UPDATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "VOLUME_UPDATED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VolumeRef { get; set; }

        /// <summary>
        /// The volume's expiration time after the update, as an ISO 8601 string. Null when the update cleared it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// The expiration time the update replaced, as an ISO 8601 string. Null when the volume had none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_expires_at")]
        public string? PreviousExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventVolumeUpdatedV1" /> class.
        /// </summary>
        /// <param name="volumeRef"></param>
        /// <param name="expiresAt">
        /// The volume's expiration time after the update, as an ISO 8601 string. Null when the update cleared it.
        /// </param>
        /// <param name="previousExpiresAt">
        /// The expiration time the update replaced, as an ISO 8601 string. Null when the volume had none.
        /// </param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventVolumeUpdatedV1(
            string volumeRef,
            string? expiresAt,
            string? previousExpiresAt,
            string eventType = "VOLUME_UPDATED")
        {
            this.EventType = eventType;
            this.VolumeRef = volumeRef ?? throw new global::System.ArgumentNullException(nameof(volumeRef));
            this.ExpiresAt = expiresAt;
            this.PreviousExpiresAt = previousExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventVolumeUpdatedV1" /> class.
        /// </summary>
        public AuditLogEventVolumeUpdatedV1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AuditLogEventVolumeUpdatedV1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AuditLogEventVolumeUpdatedV1 FromVolumeRef(string volumeRef)
        {
            return new AuditLogEventVolumeUpdatedV1
            {
                VolumeRef = volumeRef,
            };
        }

    }
}