
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A volume was deleted, tombstoning every version it still held.
    /// </summary>
    public sealed partial class AuditLogEventVolumeDeletedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"VOLUME_DELETED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "VOLUME_DELETED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VolumeRef { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VolumeName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions_deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionsDeleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventVolumeDeletedV1" /> class.
        /// </summary>
        /// <param name="volumeRef"></param>
        /// <param name="namespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="versionsDeleted"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventVolumeDeletedV1(
            string volumeRef,
            string @namespace,
            string volumeName,
            int versionsDeleted,
            string eventType = "VOLUME_DELETED")
        {
            this.EventType = eventType;
            this.VolumeRef = volumeRef ?? throw new global::System.ArgumentNullException(nameof(volumeRef));
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.VolumeName = volumeName ?? throw new global::System.ArgumentNullException(nameof(volumeName));
            this.VersionsDeleted = versionsDeleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventVolumeDeletedV1" /> class.
        /// </summary>
        public AuditLogEventVolumeDeletedV1()
        {
        }

    }
}