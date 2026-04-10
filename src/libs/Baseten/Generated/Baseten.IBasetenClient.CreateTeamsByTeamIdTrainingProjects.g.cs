#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Upsert a training project in a specific team.<br/>
        /// Upserts a training project with the specified metadata for a team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/teams/{team_id}/training_projects \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "training_project": {<br/>
        ///     "name": "My Training Project"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.UpsertTrainingProjectResponseV1> CreateTeamsByTeamIdTrainingProjectsAsync(
            string teamId,

            global::Baseten.UpsertTrainingProjectRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert a training project in a specific team.<br/>
        /// Upserts a training project with the specified metadata for a team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="trainingProject">
        /// The training project to upsert.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.UpsertTrainingProjectResponseV1> CreateTeamsByTeamIdTrainingProjectsAsync(
            string teamId,
            global::Baseten.UpsertTrainingProjectV1 trainingProject,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}