
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VolumeV1
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Full address of the volume, as `bdn:&lt;namespace&gt;/&lt;volume&gt;`. Paste this into the `bdn.mounts` section of a config.yaml.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionRef { get; set; }

        /// <summary>
        /// Revision counter for the volume, incremented on every commit, tag change, delete, and restore. A tag or version that expires leaves without changing it; the next write then increments it once. Use it to detect that a volume was written to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Sequence { get; set; }

        /// <summary>
        /// When the volume was last written to, in ISO 8601 format. An expiry does not update it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// When the whole volume expires, in ISO 8601 format. At that instant every live version is deleted, every tag drops, and the volume leaves the volume listing; each version then stays restorable until its recovery deadline passes. Null for a volume that never expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Version that the reserved `head` tag points at, which a reference with no tag or digest resolves to. Never an expiring version. Null when the volume has no head, or when your API key cannot read it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head")]
        public global::Baseten.VolumeVersionSummaryV1? Head { get; set; }

        /// <summary>
        /// Tags on the volume that your API key can read. A tag with `expires_at` leaves this list at that instant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.VolumeTagV1> Tags { get; set; }

        /// <summary>
        /// Total number of tags on the volume, which can exceed the length of `tags` when your API key cannot read all of them. Counts only tags that have not expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TagCount { get; set; }

        /// <summary>
        /// Number of versions that have not been deleted or expired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions_alive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionsAlive { get; set; }

        /// <summary>
        /// Number of versions that have been deleted or expired and are still within their recovery window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions_tombstoned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionsTombstoned { get; set; }

        /// <summary>
        /// Number of live versions that no tag points at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions_untagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionsUntagged { get; set; }

        /// <summary>
        /// Number of live versions with an expiry still ahead of them. A version that has already expired counts in `versions_tombstoned` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions_expiring")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionsExpiring { get; set; }

        /// <summary>
        /// Earliest expiry among the live versions, in ISO 8601 format. Null when no live version is scheduled to expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions_earliest_expires_at")]
        public global::System.DateTime? VersionsEarliestExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeV1" /> class.
        /// </summary>
        /// <param name="namespace">
        /// Namespace the volume belongs to, in lowercase.
        /// </param>
        /// <param name="name">
        /// Name of the volume, in lowercase.
        /// </param>
        /// <param name="versionRef">
        /// Full address of the volume, as `bdn:&lt;namespace&gt;/&lt;volume&gt;`. Paste this into the `bdn.mounts` section of a config.yaml.
        /// </param>
        /// <param name="sequence">
        /// Revision counter for the volume, incremented on every commit, tag change, delete, and restore. A tag or version that expires leaves without changing it; the next write then increments it once. Use it to detect that a volume was written to.
        /// </param>
        /// <param name="updatedAt">
        /// When the volume was last written to, in ISO 8601 format. An expiry does not update it.
        /// </param>
        /// <param name="tags">
        /// Tags on the volume that your API key can read. A tag with `expires_at` leaves this list at that instant.
        /// </param>
        /// <param name="tagCount">
        /// Total number of tags on the volume, which can exceed the length of `tags` when your API key cannot read all of them. Counts only tags that have not expired.
        /// </param>
        /// <param name="versionsAlive">
        /// Number of versions that have not been deleted or expired.
        /// </param>
        /// <param name="versionsTombstoned">
        /// Number of versions that have been deleted or expired and are still within their recovery window.
        /// </param>
        /// <param name="versionsUntagged">
        /// Number of live versions that no tag points at.
        /// </param>
        /// <param name="versionsExpiring">
        /// Number of live versions with an expiry still ahead of them. A version that has already expired counts in `versions_tombstoned` instead.
        /// </param>
        /// <param name="expiresAt">
        /// When the whole volume expires, in ISO 8601 format. At that instant every live version is deleted, every tag drops, and the volume leaves the volume listing; each version then stays restorable until its recovery deadline passes. Null for a volume that never expires.
        /// </param>
        /// <param name="head">
        /// Version that the reserved `head` tag points at, which a reference with no tag or digest resolves to. Never an expiring version. Null when the volume has no head, or when your API key cannot read it.
        /// </param>
        /// <param name="versionsEarliestExpiresAt">
        /// Earliest expiry among the live versions, in ISO 8601 format. Null when no live version is scheduled to expire.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeV1(
            string @namespace,
            string name,
            string versionRef,
            int sequence,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::Baseten.VolumeTagV1> tags,
            int tagCount,
            int versionsAlive,
            int versionsTombstoned,
            int versionsUntagged,
            int versionsExpiring,
            global::System.DateTime? expiresAt,
            global::Baseten.VolumeVersionSummaryV1? head,
            global::System.DateTime? versionsEarliestExpiresAt)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.VersionRef = versionRef ?? throw new global::System.ArgumentNullException(nameof(versionRef));
            this.Sequence = sequence;
            this.UpdatedAt = updatedAt;
            this.ExpiresAt = expiresAt;
            this.Head = head;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.TagCount = tagCount;
            this.VersionsAlive = versionsAlive;
            this.VersionsTombstoned = versionsTombstoned;
            this.VersionsUntagged = versionsUntagged;
            this.VersionsExpiring = versionsExpiring;
            this.VersionsEarliestExpiresAt = versionsEarliestExpiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeV1" /> class.
        /// </summary>
        public VolumeV1()
        {
        }

    }
}