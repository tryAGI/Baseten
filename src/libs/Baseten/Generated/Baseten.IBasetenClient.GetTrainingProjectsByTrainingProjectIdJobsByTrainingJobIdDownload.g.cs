#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Get the uploaded training job as a S3 Artifact<br/>
        /// Get the uploaded training job as a S3 Artifact
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs/{training_job_id}/download \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DownloadTrainingJobResponseV1> GetTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdDownloadAsync(
            string trainingProjectId,
            string trainingJobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}