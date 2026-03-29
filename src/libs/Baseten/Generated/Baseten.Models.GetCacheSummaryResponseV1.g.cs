
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for getting cache summary.
    /// </summary>
    public sealed partial class GetCacheSummaryResponseV1
    {
        /// <summary>
        /// Timestamp when the cache summary was captured
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timestamp { get; set; }

        /// <summary>
        /// Project ID associated with the cache
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// List of files in the cache
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_summaries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.FileSummary> FileSummaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCacheSummaryResponseV1" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Timestamp when the cache summary was captured
        /// </param>
        /// <param name="projectId">
        /// Project ID associated with the cache
        /// </param>
        /// <param name="fileSummaries">
        /// List of files in the cache
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetCacheSummaryResponseV1(
            string timestamp,
            string projectId,
            global::System.Collections.Generic.IList<global::Baseten.FileSummary> fileSummaries)
        {
            this.Timestamp = timestamp ?? throw new global::System.ArgumentNullException(nameof(timestamp));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.FileSummaries = fileSummaries ?? throw new global::System.ArgumentNullException(nameof(fileSummaries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCacheSummaryResponseV1" /> class.
        /// </summary>
        public GetCacheSummaryResponseV1()
        {
        }
    }
}