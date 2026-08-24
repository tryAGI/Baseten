
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Pagination params for a Loops deployment debug archive.
    /// </summary>
    public sealed partial class GetLoopsDebugArchiveFilesRequestV1
    {
        /// <summary>
        /// Max files per page (default and maximum 1000).<br/>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Opaque token for the next page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_token")]
        public string? PageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsDebugArchiveFilesRequestV1" /> class.
        /// </summary>
        /// <param name="pageSize">
        /// Max files per page (default and maximum 1000).<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="pageToken">
        /// Opaque token for the next page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLoopsDebugArchiveFilesRequestV1(
            int? pageSize,
            string? pageToken)
        {
            this.PageSize = pageSize;
            this.PageToken = pageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsDebugArchiveFilesRequestV1" /> class.
        /// </summary>
        public GetLoopsDebugArchiveFilesRequestV1()
        {
        }

    }
}