
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SetVolumeTagResponseV1
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
        /// Name of the tag that was set, with its original capitalization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// Content digest of the version the tag points at, as `b3:&lt;hex&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// Full address of the tagged version, as `bdn:&lt;namespace&gt;/&lt;volume&gt;@&lt;digest&gt;`. Paste it into a config.yaml to pin this version, even if the tag is later set on another version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionRef { get; set; }

        /// <summary>
        /// Revision of the volume after the tag was set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_sequence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VolumeSequence { get; set; }

        /// <summary>
        /// Tag expiration time in ISO 8601 format. Null when the tag has no expiration time of its own.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetVolumeTagResponseV1" /> class.
        /// </summary>
        /// <param name="namespace">
        /// Namespace the volume belongs to, in lowercase.
        /// </param>
        /// <param name="volume">
        /// Name of the volume, in lowercase.
        /// </param>
        /// <param name="tag">
        /// Name of the tag that was set, with its original capitalization.
        /// </param>
        /// <param name="digest">
        /// Content digest of the version the tag points at, as `b3:&lt;hex&gt;`.
        /// </param>
        /// <param name="versionRef">
        /// Full address of the tagged version, as `bdn:&lt;namespace&gt;/&lt;volume&gt;@&lt;digest&gt;`. Paste it into a config.yaml to pin this version, even if the tag is later set on another version.
        /// </param>
        /// <param name="volumeSequence">
        /// Revision of the volume after the tag was set.
        /// </param>
        /// <param name="expiresAt">
        /// Tag expiration time in ISO 8601 format. Null when the tag has no expiration time of its own.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetVolumeTagResponseV1(
            string @namespace,
            string volume,
            string tag,
            string digest,
            string versionRef,
            int volumeSequence,
            global::System.DateTime? expiresAt)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Volume = volume ?? throw new global::System.ArgumentNullException(nameof(volume));
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.VersionRef = versionRef ?? throw new global::System.ArgumentNullException(nameof(versionRef));
            this.VolumeSequence = volumeSequence;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetVolumeTagResponseV1" /> class.
        /// </summary>
        public SetVolumeTagResponseV1()
        {
        }

    }
}