#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets an environment group by name<br/>
        /// Gets a single environment group by name. The team-scoped path targets the team in the path; the top-level path targets the caller's organization default team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="envName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/teams/{team_id}/environment_groups/{env_name} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.EnvironmentGroupV1> GetTeamsByTeamIdEnvironmentGroupsByEnvNameAsync(
            string teamId,
            string envName,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets an environment group by name<br/>
        /// Gets a single environment group by name. The team-scoped path targets the team in the path; the top-level path targets the caller's organization default team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="envName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/teams/{team_id}/environment_groups/{env_name} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.EnvironmentGroupV1>> GetTeamsByTeamIdEnvironmentGroupsByEnvNameAsResponseAsync(
            string teamId,
            string envName,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}