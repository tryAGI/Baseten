#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Search training jobs.<br/>
        /// Search training jobs for the organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/training_jobs/search \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "project_id": "n4q95w5",<br/>
        ///   "job_id": "p7qr9qv",<br/>
        ///   "statuses": [<br/>
        ///     "TRAINING_JOB_RUNNING",<br/>
        ///     "TRAINING_JOB_COMPLETED"<br/>
        ///   ],<br/>
        ///   "order_by": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.SearchTrainingJobsResponseV1> CreateTrainingJobsSearchAsync(

            global::Baseten.SearchTrainingJobsRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search training jobs.<br/>
        /// Search training jobs for the organization.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SearchTrainingJobsResponseV1> CreateTrainingJobsSearchAsync(
            string? projectId = default,
            string? jobId = default,
            global::System.Collections.Generic.IList<string>? statuses = default,
            global::System.Collections.Generic.IList<global::Baseten.OrderByV1>? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}