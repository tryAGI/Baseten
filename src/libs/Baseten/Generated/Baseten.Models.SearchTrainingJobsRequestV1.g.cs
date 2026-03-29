
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to search training jobs.
    /// </summary>
    public sealed partial class SearchTrainingJobsRequestV1
    {
        /// <summary>
        /// Filter the training jobs by project ID.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Filter the training jobs by job ID.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// Filter the training jobs by status.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        public global::System.Collections.Generic.IList<string>? Statuses { get; set; }

        /// <summary>
        /// Order the training jobs by a field. Currently supports created_at<br/>
        /// Default Value: [{"field":"created_at","order":"desc"}]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public global::System.Collections.Generic.IList<global::Baseten.OrderByV1>? OrderBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTrainingJobsRequestV1" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Filter the training jobs by project ID.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="jobId">
        /// Filter the training jobs by job ID.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="statuses">
        /// Filter the training jobs by status.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="orderBy">
        /// Order the training jobs by a field. Currently supports created_at<br/>
        /// Default Value: [{"field":"created_at","order":"desc"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchTrainingJobsRequestV1(
            string? projectId,
            string? jobId,
            global::System.Collections.Generic.IList<string>? statuses,
            global::System.Collections.Generic.IList<global::Baseten.OrderByV1>? orderBy)
        {
            this.ProjectId = projectId;
            this.JobId = jobId;
            this.Statuses = statuses;
            this.OrderBy = orderBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchTrainingJobsRequestV1" /> class.
        /// </summary>
        public SearchTrainingJobsRequestV1()
        {
        }
    }
}