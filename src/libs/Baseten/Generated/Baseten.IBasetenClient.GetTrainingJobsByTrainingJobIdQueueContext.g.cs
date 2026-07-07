#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Reconstructs queue context for a training job<br/>
        /// Returns the (org, gpu_type) capacity pool the job was gated by, jobs that were holding GPU capacity in that pool when this job was submitted, and every TrainingJobStatus event in [submitted_at, released_at] for those jobs, useful for understanding why a job sat in PENDING. Caller must be an org admin and the job must belong to the caller's org.
        /// </summary>
        /// <param name="trainingJobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/training/jobs/{training_job_id}/queue_context \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetTrainingJobQueueContextResponseV1> GetTrainingJobsByTrainingJobIdQueueContextAsync(
            string trainingJobId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reconstructs queue context for a training job<br/>
        /// Returns the (org, gpu_type) capacity pool the job was gated by, jobs that were holding GPU capacity in that pool when this job was submitted, and every TrainingJobStatus event in [submitted_at, released_at] for those jobs, useful for understanding why a job sat in PENDING. Caller must be an org admin and the job must belong to the caller's org.
        /// </summary>
        /// <param name="trainingJobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/training/jobs/{training_job_id}/queue_context \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.GetTrainingJobQueueContextResponseV1>> GetTrainingJobsByTrainingJobIdQueueContextAsResponseAsync(
            string trainingJobId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}