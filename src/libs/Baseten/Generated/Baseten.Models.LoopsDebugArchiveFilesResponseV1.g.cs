
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response with presigned URLs for a Loops deployment's debug archive.
    /// </summary>
    public sealed partial class LoopsDebugArchiveFilesResponseV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presigned_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.CheckpointFile> PresignedUrls { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsDebugArchiveFilesResponseV1" /> class.
        /// </summary>
        /// <param name="presignedUrls"></param>
        /// <param name="nextPageToken">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsDebugArchiveFilesResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.CheckpointFile> presignedUrls,
            string? nextPageToken)
        {
            this.PresignedUrls = presignedUrls ?? throw new global::System.ArgumentNullException(nameof(presignedUrls));
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsDebugArchiveFilesResponseV1" /> class.
        /// </summary>
        public LoopsDebugArchiveFilesResponseV1()
        {
        }

    }
}