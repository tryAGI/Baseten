
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteVolumeVersionResponseV1
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
        /// Full address of the deleted version, as `bdn://&lt;namespace&gt;/&lt;volume&gt;@&lt;digest&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionRef { get; set; }

        /// <summary>
        /// Content digest of the deleted version, as `b3:&lt;hex&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// Lifecycle state of the version after the delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lifecycle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Lifecycle { get; set; }

        /// <summary>
        /// When the version stops being restorable, in ISO 8601 format. Until then it can be returned to service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_after")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime DeleteAfter { get; set; }

        /// <summary>
        /// Revision of the volume after the delete.
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
        /// Initializes a new instance of the <see cref="DeleteVolumeVersionResponseV1" /> class.
        /// </summary>
        /// <param name="namespace">
        /// Namespace the volume belongs to, in lowercase.
        /// </param>
        /// <param name="volume">
        /// Name of the volume, in lowercase.
        /// </param>
        /// <param name="versionRef">
        /// Full address of the deleted version, as `bdn://&lt;namespace&gt;/&lt;volume&gt;@&lt;digest&gt;`.
        /// </param>
        /// <param name="digest">
        /// Content digest of the deleted version, as `b3:&lt;hex&gt;`.
        /// </param>
        /// <param name="lifecycle">
        /// Lifecycle state of the version after the delete.
        /// </param>
        /// <param name="deleteAfter">
        /// When the version stops being restorable, in ISO 8601 format. Until then it can be returned to service.
        /// </param>
        /// <param name="volumeSequence">
        /// Revision of the volume after the delete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteVolumeVersionResponseV1(
            string @namespace,
            string volume,
            string versionRef,
            string digest,
            string lifecycle,
            global::System.DateTime deleteAfter,
            int volumeSequence)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Volume = volume ?? throw new global::System.ArgumentNullException(nameof(volume));
            this.VersionRef = versionRef ?? throw new global::System.ArgumentNullException(nameof(versionRef));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.Lifecycle = lifecycle ?? throw new global::System.ArgumentNullException(nameof(lifecycle));
            this.DeleteAfter = deleteAfter;
            this.VolumeSequence = volumeSequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVolumeVersionResponseV1" /> class.
        /// </summary>
        public DeleteVolumeVersionResponseV1()
        {
        }

    }
}