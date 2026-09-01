#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a training job<br/>
        /// Updates mutable fields on a PENDING training job: the queue priority (higher priorities are dequeued first) and the availability model (dedicated or spot capacity). Changes take effect on the next queue evaluation, which is triggered immediately.
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
        ///   "priority": 0,<br/>
        ///   "availability_model": "spot"<br/>
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
        /// Updates mutable fields on a PENDING training job: the queue priority (higher priorities are dequeued first) and the availability model (dedicated or spot capacity). Changes take effect on the next queue evaluation, which is triggered immediately.
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
        ///   "priority": 0,<br/>
        ///   "availability_model": "spot"<br/>
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
        /// Updates mutable fields on a PENDING training job: the queue priority (higher priorities are dequeued first) and the availability model (dedicated or spot capacity). Changes take effect on the next queue evaluation, which is triggered immediately.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="priority">
        /// New queue priority for a PENDING training job. Higher values are dequeued first. Only jobs in the PENDING state can have their priority changed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="availabilityModel">
        /// New capacity guarantee for a PENDING training job. 'dedicated' runs on on-demand capacity that is not preempted. 'spot' runs on interruptible capacity that may be preempted; the user is responsible for checkpointing their own progress. Only jobs in the PENDING state can have their availability model changed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.UpdateTrainingJobResponseV1> EditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdAsync(
            string trainingProjectId,
            string trainingJobId,
            int? priority = default,
            global::Baseten.V1AvailabilityModel? availabilityModel = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}