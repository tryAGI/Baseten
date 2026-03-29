#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Stop a training job.<br/>
        /// Stops a training job.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs/{training_job_id}/stop \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.StopTrainingJobResponseV1> CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopAsync(
            string trainingProjectId,
            string trainingJobId,

            global::Baseten.StopTrainingJobRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stop a training job.<br/>
        /// Stops a training job.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.StopTrainingJobResponseV1> CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdStopAsync(
            string trainingProjectId,
            string trainingJobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}