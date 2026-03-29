#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Delete a training project.<br/>
        /// Deletes a training project and all associated training jobs.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id} \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.TrainingProjectTombstoneV1> DeleteTrainingProjectsByTrainingProjectIdAsync(
            string trainingProjectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}