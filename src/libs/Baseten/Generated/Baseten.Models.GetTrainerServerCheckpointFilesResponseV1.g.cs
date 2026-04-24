
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A response to fetch presigned URLs for files under a trainer server checkpoint.
    /// </summary>
    public sealed partial class GetTrainerServerCheckpointFilesResponseV1
    {
        /// <summary>
        /// List of presigned URLs for checkpoint files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presigned_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.CheckpointFile> PresignedUrls { get; set; }

        /// <summary>
        /// Token to use for fetching the next page of results. None when there are no more results.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public int? NextPageToken { get; set; }

        /// <summary>
        /// Total number of checkpoint files available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainerServerCheckpointFilesResponseV1" /> class.
        /// </summary>
        /// <param name="presignedUrls">
        /// List of presigned URLs for checkpoint files.
        /// </param>
        /// <param name="totalCount">
        /// Total number of checkpoint files available.
        /// </param>
        /// <param name="nextPageToken">
        /// Token to use for fetching the next page of results. None when there are no more results.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrainerServerCheckpointFilesResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.CheckpointFile> presignedUrls,
            int totalCount,
            int? nextPageToken)
        {
            this.PresignedUrls = presignedUrls ?? throw new global::System.ArgumentNullException(nameof(presignedUrls));
            this.NextPageToken = nextPageToken;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainerServerCheckpointFilesResponseV1" /> class.
        /// </summary>
        public GetTrainerServerCheckpointFilesResponseV1()
        {
        }
    }
}