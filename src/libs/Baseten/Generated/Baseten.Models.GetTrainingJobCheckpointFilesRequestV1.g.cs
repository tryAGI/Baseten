
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Pagination params for ``GET /v1/training_projects/.../checkpoint_files``.
    /// </summary>
    public sealed partial class GetTrainingJobCheckpointFilesRequestV1
    {
        /// <summary>
        /// Max files per page (default 1000).<br/>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Offset into the file list (default 0).<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_token")]
        public int? PageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingJobCheckpointFilesRequestV1" /> class.
        /// </summary>
        /// <param name="pageSize">
        /// Max files per page (default 1000).<br/>
        /// Default Value: 1000
        /// </param>
        /// <param name="pageToken">
        /// Offset into the file list (default 0).<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTrainingJobCheckpointFilesRequestV1(
            int? pageSize,
            int? pageToken)
        {
            this.PageSize = pageSize;
            this.PageToken = pageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTrainingJobCheckpointFilesRequestV1" /> class.
        /// </summary>
        public GetTrainingJobCheckpointFilesRequestV1()
        {
        }

    }
}