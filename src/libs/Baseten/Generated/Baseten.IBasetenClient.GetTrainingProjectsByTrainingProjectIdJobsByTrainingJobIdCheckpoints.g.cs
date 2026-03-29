#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Get training job checkpoints.<br/>
        /// Get the checkpoints for a training job.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs/{training_job_id}/checkpoints \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetTrainingJobCheckpointsResponseV1> GetTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdCheckpointsAsync(
            string trainingProjectId,
            string trainingJobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}