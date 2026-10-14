
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchVolumeResponseV1
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
        /// Volume expiration time in ISO 8601 format. Null when no expiration time is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Revision of the volume after the update.
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
        /// Initializes a new instance of the <see cref="PatchVolumeResponseV1" /> class.
        /// </summary>
        /// <param name="namespace">
        /// Namespace the volume belongs to, in lowercase.
        /// </param>
        /// <param name="volume">
        /// Name of the volume, in lowercase.
        /// </param>
        /// <param name="volumeSequence">
        /// Revision of the volume after the update.
        /// </param>
        /// <param name="expiresAt">
        /// Volume expiration time in ISO 8601 format. Null when no expiration time is set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchVolumeResponseV1(
            string @namespace,
            string volume,
            int volumeSequence,
            global::System.DateTime? expiresAt)
        {
            this.Namespace = @namespace ?? throw new global::System.ArgumentNullException(nameof(@namespace));
            this.Volume = volume ?? throw new global::System.ArgumentNullException(nameof(volume));
            this.ExpiresAt = expiresAt;
            this.VolumeSequence = volumeSequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchVolumeResponseV1" /> class.
        /// </summary>
        public PatchVolumeResponseV1()
        {
        }

    }
}