
#nullable enable

namespace Baseten
{
    /// <summary>
    /// One version, with the fields only a single-version read reports.
    /// </summary>
    public sealed partial class VolumeVersionDetailV1
    {
        /// <summary>
        /// Namespace the volume belongs to, in lowercase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Namespace { get; set; }

        /// <summary>
        /// Name of the volume, in lowercase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Volume { get; set; }

        /// <summary>
        /// Full address of this version, as `bdn://&lt;namespace&gt;/&lt;volume&gt;@&lt;digest&gt;`. Paste this into the `bdn.mounts` section of a config.yaml to pin to it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionRef { get; set; }

        /// <summary>
        /// Content digest of the version, as `b3:&lt;hex&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// Revision the version was committed at. Null for versions committed before the volume service recorded it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence")]
        public int? Sequence { get; set; }

        /// <summary>
        /// Lifecycle state of the version, for example ALIVE or TOMBSTONED.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifecycle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lifecycle { get; set; }

        /// <summary>
        /// Whether the reserved `head` tag points at this version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_head")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsHead { get; set; }

        /// <summary>
        /// Tags pointing at this version that your API key can read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Total size of the version's files in bytes. Null when not recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_size_bytes")]
        public long? TotalSizeBytes { get; set; }

        /// <summary>
        /// When the version was committed, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the version was deleted, in ISO 8601 format. Null unless the lifecycle is TOMBSTONED.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tombstoned_at")]
        public global::System.DateTime? TombstonedAt { get; set; }

        /// <summary>
        /// When the version stops being restorable, in ISO 8601 format. Null unless the lifecycle is TOMBSTONED.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_after")]
        public global::System.DateTime? DeleteAfter { get; set; }

        /// <summary>
        /// Number of files in the version. Null when not recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entry_count")]
        public int? EntryCount { get; set; }

        /// <summary>
        /// Revision of the volume as a whole when this version was read. Pass it as expected_sequence on a later delete to make that delete conditional on the volume not having changed since.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_sequence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VolumeSequence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeVersionDetailV1" /> class.
        /// </summary>
        /// <param name="namespace">
        /// Namespace the volume belongs to, in lowercase.
        /// </param>
        /// <param name="volume">
        /// Name of the volume, in lowercase.
        /// </param>
        /// <param name="versionRef">
        /// Full address of this version, as `bdn://&lt;namespace&gt;/&lt;volume&gt;@&lt;digest&gt;`. Paste this into the `bdn.mounts` section of a config.yaml to pin to it.
        /// </param>
        /// <param name="digest">
        /// Content digest of the version, as `b3:&lt;hex&gt;`.
        /// </param>
        /// <param name="lifecycle">
        /// Lifecycle state of the version, for example ALIVE or TOMBSTONED.
        /// </param>
        /// <param name="isHead">
        /// Whether the reserved `head` tag points at this version.
        /// </param>
        /// <param name="tags">
        /// Tags pointing at this version that your API key can read.
        /// </param>
        /// <param name="createdAt">
        /// When the version was committed, in ISO 8601 format.
        /// </param>
        /// <param name="volumeSequence">
        /// Revision of the volume as a whole when this version was read. Pass it as expected_sequence on a later delete to make that delete conditional on the volume not having changed since.
        /// </param>
        /// <param name="sequence">
        /// Revision the version was committed at. Null for versions committed before the volume service recorded it.
        /// </param>
        /// <param name="totalSizeBytes">
        /// Total size of the version's files in bytes. Null when not recorded.
        /// </param>
        /// <param name="tombstonedAt">
        /// When the version was deleted, in ISO 8601 format. Null unless the lifecycle is TOMBSTONED.
        /// </param>
        /// <param name="deleteAfter">
        /// When the version stops being restorable, in ISO 8601 format. Null unless the lifecycle is TOMBSTONED.
        /// </param>
        /// <param name="entryCount">
        /// Number of files in the version. Null when not recorded.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeVersionDetailV1(
            string @namespace,
            string volume,
            string versionRef,
            string digest,
            string lifecycle,
            bool isHead,
            global::System.Collections.Generic.IList<string> tags,
            global::System.DateTime createdAt,
            int volumeSequence,
            int? sequence,
            long? totalSizeBytes,
            global::System.DateTime? tombstonedAt,
            global::System.DateTime? deleteAfter,
            int? entryCount)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Volume = volume ?? throw new global::System.ArgumentNullException(nameof(volume));
            this.VersionRef = versionRef ?? throw new global::System.ArgumentNullException(nameof(versionRef));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.Sequence = sequence;
            this.Lifecycle = lifecycle ?? throw new global::System.ArgumentNullException(nameof(lifecycle));
            this.IsHead = isHead;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.TotalSizeBytes = totalSizeBytes;
            this.CreatedAt = createdAt;
            this.TombstonedAt = tombstonedAt;
            this.DeleteAfter = deleteAfter;
            this.EntryCount = entryCount;
            this.VolumeSequence = volumeSequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeVersionDetailV1" /> class.
        /// </summary>
        public VolumeVersionDetailV1()
        {
        }

    }
}