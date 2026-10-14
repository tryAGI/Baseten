
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Deleting a volume tag succeeded. `deleted` is false if the tag was already absent.
    /// </summary>
    public sealed partial class AuditLogEventVolumeTagDeletedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"VOLUME_TAG_DELETED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "VOLUME_TAG_DELETED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VolumeRef { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventVolumeTagDeletedV1" /> class.
        /// </summary>
        /// <param name="volumeRef"></param>
        /// <param name="tag"></param>
        /// <param name="deleted"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventVolumeTagDeletedV1(
            string volumeRef,
            string tag,
            bool deleted,
            string eventType = "VOLUME_TAG_DELETED")
        {
            this.EventType = eventType;
            this.VolumeRef = volumeRef ?? throw new global::System.ArgumentNullException(nameof(volumeRef));
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventVolumeTagDeletedV1" /> class.
        /// </summary>
        public AuditLogEventVolumeTagDeletedV1()
        {
        }

    }
}