#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets all secrets for a team
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/teams/{team_id}/secrets \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.SecretsV1> GetTeamsByTeamIdSecretsAsync(
            string teamId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}