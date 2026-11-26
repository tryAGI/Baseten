
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The formats a delta snapshot is encoded with.
    /// </summary>
    public sealed partial class HotLoadIncrementalSnapshotMetadataV1
    {
        /// <summary>
        /// The delta's compression format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compression_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CompressionFormat { get; set; }

        /// <summary>
        /// The delta's checksum format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checksum_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChecksumFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HotLoadIncrementalSnapshotMetadataV1" /> class.
        /// </summary>
        /// <param name="compressionFormat">
        /// The delta's compression format.
        /// </param>
        /// <param name="checksumFormat">
        /// The delta's checksum format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HotLoadIncrementalSnapshotMetadataV1(
            string compressionFormat,
            string checksumFormat)
        {
            this.CompressionFormat = compressionFormat ?? throw new global::System.ArgumentNullException(nameof(compressionFormat));
            this.ChecksumFormat = checksumFormat ?? throw new global::System.ArgumentNullException(nameof(checksumFormat));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HotLoadIncrementalSnapshotMetadataV1" /> class.
        /// </summary>
        public HotLoadIncrementalSnapshotMetadataV1()
        {
        }

    }
}