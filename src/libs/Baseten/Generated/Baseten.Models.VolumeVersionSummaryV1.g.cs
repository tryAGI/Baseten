
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VolumeVersionSummaryV1
    {
        /// <summary>
        /// Content digest of the version, as `b3:&lt;hex&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// Total size of the version's files in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TotalSizeBytes { get; set; }

        /// <summary>
        /// When the version was committed, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeVersionSummaryV1" /> class.
        /// </summary>
        /// <param name="digest">
        /// Content digest of the version, as `b3:&lt;hex&gt;`.
        /// </param>
        /// <param name="totalSizeBytes">
        /// Total size of the version's files in bytes.
        /// </param>
        /// <param name="createdAt">
        /// When the version was committed, in ISO 8601 format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeVersionSummaryV1(
            string digest,
            long totalSizeBytes,
            global::System.DateTime createdAt)
        {
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.TotalSizeBytes = totalSizeBytes;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeVersionSummaryV1" /> class.
        /// </summary>
        public VolumeVersionSummaryV1()
        {
        }

    }
}