
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteVolumeResponseV1
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
        /// Number of versions this request deleted. Zero when the volume had no live versions left, which is not an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions_deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionsDeleted { get; set; }

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
        /// Initializes a new instance of the <see cref="DeleteVolumeResponseV1" /> class.
        /// </summary>
        /// <param name="namespace">
        /// Namespace the volume belongs to, in lowercase.
        /// </param>
        /// <param name="name">
        /// Name of the volume, in lowercase.
        /// </param>
        /// <param name="versionsDeleted">
        /// Number of versions this request deleted. Zero when the volume had no live versions left, which is not an error.
        /// </param>
        /// <param name="volumeSequence">
        /// Revision of the volume after the delete.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteVolumeResponseV1(
            string @namespace,
            string name,
            int versionsDeleted,
            int volumeSequence)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.VersionsDeleted = versionsDeleted;
            this.VolumeSequence = volumeSequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVolumeResponseV1" /> class.
        /// </summary>
        public DeleteVolumeResponseV1()
        {
        }

    }
}