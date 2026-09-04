
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Every version of a volume, newest first.<br/>
    /// Unpaginated: `limit` and `cursor` are absent rather than accepted and<br/>
    /// ignored, so adding them once the volume service pages this listing is a<br/>
    /// purely additive change.
    /// </summary>
    public sealed partial class ListVolumeVersionsResponseV1
    {
        /// <summary>
        /// Versions of the volume, newest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.VolumeVersionV1> Versions { get; set; }

        /// <summary>
        /// Revision of the volume as a whole when the versions were read. Pass it as expected_sequence on a later delete to make that delete conditional on the volume not having changed since. Distinct from the per-version sequence, which is the revision a version was committed at.
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
        /// Initializes a new instance of the <see cref="ListVolumeVersionsResponseV1" /> class.
        /// </summary>
        /// <param name="versions">
        /// Versions of the volume, newest first.
        /// </param>
        /// <param name="volumeSequence">
        /// Revision of the volume as a whole when the versions were read. Pass it as expected_sequence on a later delete to make that delete conditional on the volume not having changed since. Distinct from the per-version sequence, which is the revision a version was committed at.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVolumeVersionsResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.VolumeVersionV1> versions,
            int volumeSequence)
        {
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
            this.VolumeSequence = volumeSequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVolumeVersionsResponseV1" /> class.
        /// </summary>
        public ListVolumeVersionsResponseV1()
        {
        }

    }
}