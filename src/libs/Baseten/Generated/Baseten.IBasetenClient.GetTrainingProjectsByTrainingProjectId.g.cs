#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Get a training project.<br/>
        /// Get the details of an existing training project.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id} \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetTrainingProjectResponseV1> GetTrainingProjectsByTrainingProjectIdAsync(
            string trainingProjectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}