#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Lists a user's route settings in each of their teams<br/>
        /// Returns the user's settings in each team they have a role in and in any team they have Code spend in this month, alphabetical by team name: their spend limit for Baseten Code in the team, their spend in the team this month, and whether that spend reached the limit. Members can read their own settings; organization admins can read anyone's.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/routes/settings/users/{user_id}/teams \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RouteUserTeamSettingsListV1> GetRoutesSettingsUsersByUserIdTeamsAsync(
            string userId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lists a user's route settings in each of their teams<br/>
        /// Returns the user's settings in each team they have a role in and in any team they have Code spend in this month, alphabetical by team name: their spend limit for Baseten Code in the team, their spend in the team this month, and whether that spend reached the limit. Members can read their own settings; organization admins can read anyone's.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/routes/settings/users/{user_id}/teams \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RouteUserTeamSettingsListV1>> GetRoutesSettingsUsersByUserIdTeamsAsResponseAsync(
            string userId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}