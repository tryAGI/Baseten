#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Lists regions available to a team<br/>
        /// Lists the regions the team specified in the path can place deployments in.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/teams/{team_id}/regions \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RegionsV1> GetTeamsByTeamIdRegionsAsync(
            string teamId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lists regions available to a team<br/>
        /// Lists the regions the team specified in the path can place deployments in.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/teams/{team_id}/regions \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RegionsV1>> GetTeamsByTeamIdRegionsAsResponseAsync(
            string teamId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}