#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a training job<br/>
        /// Updates mutable fields on a training job. Currently supports changing the queue priority of a PENDING job; higher priorities are dequeued first.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs/{training_job_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "priority": 0<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.UpdateTrainingJobResponseV1> EditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdAsync(
            string trainingProjectId,
            string trainingJobId,

            global::Baseten.UpdateTrainingJobRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a training job<br/>
        /// Updates mutable fields on a training job. Currently supports changing the queue priority of a PENDING job; higher priorities are dequeued first.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs/{training_job_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "priority": 0<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.UpdateTrainingJobResponseV1>> EditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdAsResponseAsync(
            string trainingProjectId,
            string trainingJobId,

            global::Baseten.UpdateTrainingJobRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a training job<br/>
        /// Updates mutable fields on a training job. Currently supports changing the queue priority of a PENDING job; higher priorities are dequeued first.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="priority">
        /// New queue priority for a PENDING training job. Higher values are dequeued first. Only jobs in the PENDING state can have their priority changed.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.UpdateTrainingJobResponseV1> EditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdAsync(
            string trainingProjectId,
            string trainingJobId,
            int priority,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}