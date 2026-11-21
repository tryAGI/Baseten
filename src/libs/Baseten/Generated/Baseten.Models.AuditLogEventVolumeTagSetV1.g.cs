
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A volume tag was set on a version.
    /// </summary>
    public sealed partial class AuditLogEventVolumeTagSetV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VolumeRef { get; set; }

        /// <summary>
        /// Where the volume is stored: BASETEN_CLOUD, SINGLE_TENANT, or SELF_HOSTED. The same volume_ref under two hostings names two different volumes.<br/>
        /// Default Value: BASETEN_CLOUD
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hosting")]
        public string? Hosting { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"VOLUME_TAG_SET"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "VOLUME_TAG_SET";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventVolumeTagSetV1" /> class.
        /// </summary>
        /// <param name="volumeRef"></param>
        /// <param name="tag"></param>
        /// <param name="digest"></param>
        /// <param name="hosting">
        /// Where the volume is stored: BASETEN_CLOUD, SINGLE_TENANT, or SELF_HOSTED. The same volume_ref under two hostings names two different volumes.<br/>
        /// Default Value: BASETEN_CLOUD
        /// </param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventVolumeTagSetV1(
            string volumeRef,
            string tag,
            string digest,
            string? hosting,
            string eventType = "VOLUME_TAG_SET")
        {
            this.VolumeRef = volumeRef ?? throw new global::System.ArgumentNullException(nameof(volumeRef));
            this.Hosting = hosting;
            this.EventType = eventType;
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventVolumeTagSetV1" /> class.
        /// </summary>
        public AuditLogEventVolumeTagSetV1()
        {
        }

    }
}