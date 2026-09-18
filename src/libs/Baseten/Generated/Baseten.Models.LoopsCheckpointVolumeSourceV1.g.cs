
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The checkpoint's files are pulled from a Baseten volume.
    /// </summary>
    public sealed partial class LoopsCheckpointVolumeSourceV1
    {
        /// <summary>
        /// Default Value: volume
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Ref of the volume version holding the checkpoint, as `bdn:&lt;namespace&gt;/&lt;volume&gt;:&lt;tag&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VolumeRef { get; set; }

        /// <summary>
        /// Directory inside that version holding the checkpoint's files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsCheckpointVolumeSourceV1" /> class.
        /// </summary>
        /// <param name="volumeRef">
        /// Ref of the volume version holding the checkpoint, as `bdn:&lt;namespace&gt;/&lt;volume&gt;:&lt;tag&gt;`.
        /// </param>
        /// <param name="path">
        /// Directory inside that version holding the checkpoint's files.
        /// </param>
        /// <param name="kind">
        /// Default Value: volume
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsCheckpointVolumeSourceV1(
            string volumeRef,
            string path,
            string? kind)
        {
            this.Kind = kind;
            this.VolumeRef = volumeRef ?? throw new global::System.ArgumentNullException(nameof(volumeRef));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsCheckpointVolumeSourceV1" /> class.
        /// </summary>
        public LoopsCheckpointVolumeSourceV1()
        {
        }

    }
}