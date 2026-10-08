#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets a user's route settings in a team<br/>
        /// Returns the user's spend limit for Baseten Code in the team, their spend in the team this month, and whether that spend reached the limit. Members can read their own settings; organization admins can read anyone's.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/routes/settings/teams/{team_id}/users/{user_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RouteTeamUserSettingsV1> GetRoutesSettingsTeamsByTeamIdUsersByUserIdAsync(
            string teamId,
            string userId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a user's route settings in a team<br/>
        /// Returns the user's spend limit for Baseten Code in the team, their spend in the team this month, and whether that spend reached the limit. Members can read their own settings; organization admins can read anyone's.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/routes/settings/teams/{team_id}/users/{user_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RouteTeamUserSettingsV1>> GetRoutesSettingsTeamsByTeamIdUsersByUserIdAsResponseAsync(
            string teamId,
            string userId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}