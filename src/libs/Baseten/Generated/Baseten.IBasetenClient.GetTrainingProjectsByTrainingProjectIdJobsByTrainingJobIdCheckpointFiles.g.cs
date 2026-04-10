#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Get training job checkpoint files.<br/>
        /// Get presigned URLs for all checkpoint files for a training job.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs/{training_job_id}/checkpoint_files \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetTrainingJobCheckpointFilesResponseV1> GetTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdCheckpointFilesAsync(
            string trainingProjectId,
            string trainingJobId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}