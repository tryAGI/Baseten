#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Lists users' route settings in a team<br/>
        /// Returns the settings in the team of each user with a role in the team and of anyone with Code spend in the team this month. Requires team admin for the specified team or organization admin.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/routes/settings/teams/{team_id}/users \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RouteTeamUserSettingsListV1> GetRoutesSettingsTeamsByTeamIdUsersAsync(
            string teamId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lists users' route settings in a team<br/>
        /// Returns the settings in the team of each user with a role in the team and of anyone with Code spend in the team this month. Requires team admin for the specified team or organization admin.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/routes/settings/teams/{team_id}/users \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RouteTeamUserSettingsListV1>> GetRoutesSettingsTeamsByTeamIdUsersAsResponseAsync(
            string teamId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}