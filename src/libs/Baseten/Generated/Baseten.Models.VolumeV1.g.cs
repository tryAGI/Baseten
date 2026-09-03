
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
        /// Full address of the volume, as `bdn://&lt;namespace&gt;/&lt;volume&gt;`. Paste this into the `bdn.mounts` section of a config.yaml.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionRef { get; set; }

        /// <summary>
        /// Revision counter for the volume, incremented on every commit and tag change. Use it to detect that a volume changed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Sequence { get; set; }

        /// <summary>
        /// When the volume last changed, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Version that the reserved `head` tag points at, which a reference with no tag or digest resolves to. Null when the volume has no head, or when your API key cannot read it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head")]
        public global::Baseten.VolumeVersionSummaryV1? Head { get; set; }

        /// <summary>
        /// Tags on the volume that your API key can read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.VolumeTagV1> Tags { get; set; }

        /// <summary>
        /// Total number of tags on the volume, which can exceed the length of `tags` when your API key cannot read all of them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TagCount { get; set; }

        /// <summary>
        /// Number of versions that have not been deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions_alive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionsAlive { get; set; }

        /// <summary>
        /// Number of versions that have been deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions_tombstoned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionsTombstoned { get; set; }

        /// <summary>
        /// Number of versions that no tag points at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions_untagged")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionsUntagged { get; set; }

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
        /// Full address of the volume, as `bdn://&lt;namespace&gt;/&lt;volume&gt;`. Paste this into the `bdn.mounts` section of a config.yaml.
        /// </param>
        /// <param name="sequence">
        /// Revision counter for the volume, incremented on every commit and tag change. Use it to detect that a volume changed.
        /// </param>
        /// <param name="updatedAt">
        /// When the volume last changed, in ISO 8601 format.
        /// </param>
        /// <param name="tags">
        /// Tags on the volume that your API key can read.
        /// </param>
        /// <param name="tagCount">
        /// Total number of tags on the volume, which can exceed the length of `tags` when your API key cannot read all of them.
        /// </param>
        /// <param name="versionsAlive">
        /// Number of versions that have not been deleted.
        /// </param>
        /// <param name="versionsTombstoned">
        /// Number of versions that have been deleted.
        /// </param>
        /// <param name="versionsUntagged">
        /// Number of versions that no tag points at.
        /// </param>
        /// <param name="head">
        /// Version that the reserved `head` tag points at, which a reference with no tag or digest resolves to. Null when the volume has no head, or when your API key cannot read it.
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
            global::Baseten.VolumeVersionSummaryV1? head)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.VersionRef = versionRef ?? throw new global::System.ArgumentNullException(nameof(versionRef));
            this.Sequence = sequence;
            this.UpdatedAt = updatedAt;
            this.Head = head;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.TagCount = tagCount;
            this.VersionsAlive = versionsAlive;
            this.VersionsTombstoned = versionsTombstoned;
            this.VersionsUntagged = versionsUntagged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeV1" /> class.
        /// </summary>
        public VolumeV1()
        {
        }

    }
}