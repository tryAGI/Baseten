
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteVolumeTagResponseV1
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
        /// Tag name from the request, with its original capitalization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// Whether the tag existed and was deleted. False when the volume had no tag by that name, which is not an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

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
        /// Initializes a new instance of the <see cref="DeleteVolumeTagResponseV1" /> class.
        /// </summary>
        /// <param name="namespace">
        /// Namespace the volume belongs to, in lowercase.
        /// </param>
        /// <param name="volume">
        /// Name of the volume, in lowercase.
        /// </param>
        /// <param name="tag">
        /// Tag name from the request, with its original capitalization.
        /// </param>
        /// <param name="deleted">
        /// Whether the tag existed and was deleted. False when the volume had no tag by that name, which is not an error.
        /// </param>
        /// <param name="volumeSequence">
        /// Revision of the volume after the delete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteVolumeTagResponseV1(
            string @namespace,
            string volume,
            string tag,
            bool deleted,
            int volumeSequence)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Volume = volume ?? throw new global::System.ArgumentNullException(nameof(volume));
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.Deleted = deleted;
            this.VolumeSequence = volumeSequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVolumeTagResponseV1" /> class.
        /// </summary>
        public DeleteVolumeTagResponseV1()
        {
        }

    }
}