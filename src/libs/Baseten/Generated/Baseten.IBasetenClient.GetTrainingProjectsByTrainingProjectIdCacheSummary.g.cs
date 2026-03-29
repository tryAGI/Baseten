#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Get training project cache summary.<br/>
        /// Get the cache summary for the most recent training job in the project.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/cache/summary \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetCacheSummaryResponseV1> GetTrainingProjectsByTrainingProjectIdCacheSummaryAsync(
            string trainingProjectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}