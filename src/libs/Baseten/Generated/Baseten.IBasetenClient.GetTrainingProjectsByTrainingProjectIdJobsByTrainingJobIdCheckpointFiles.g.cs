#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets training job checkpoint files<br/>
        /// Gets presigned URLs for all checkpoint files for a training job.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 1000
        /// </param>
        /// <param name="pageToken">
        /// Default Value: 0
        /// </param>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs/{training_job_id}/checkpoint_files \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetTrainingJobCheckpointFilesResponseV1> GetTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdCheckpointFilesAsync(
            string trainingProjectId,
            string trainingJobId,
            int? pageSize = default,
            int? pageToken = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets training job checkpoint files<br/>
        /// Gets presigned URLs for all checkpoint files for a training job.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 1000
        /// </param>
        /// <param name="pageToken">
        /// Default Value: 0
        /// </param>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs/{training_job_id}/checkpoint_files \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.GetTrainingJobCheckpointFilesResponseV1>> GetTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdCheckpointFilesAsResponseAsync(
            string trainingProjectId,
            string trainingJobId,
            int? pageSize = default,
            int? pageToken = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}