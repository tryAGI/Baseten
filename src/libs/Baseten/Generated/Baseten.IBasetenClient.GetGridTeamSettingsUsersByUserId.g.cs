#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets a user's Grid settings by team ID or your only team<br/>
        /// Returns the user's spend limit for Baseten Grid in the team, their spend in the team this month, and whether that spend reached the limit. Members can read their own settings; team admins can read members' settings in teams they administer, and organization admins can read anyone's. The team comes from `team_id` instead of the path. Omit it to use the team you belong to; when you belong to several, the request fails with a 400.
        /// </summary>
        /// <param name="teamId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/grid/team_settings/users/{user_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GridTeamUserSettingsV1> GetGridTeamSettingsUsersByUserIdAsync(
            string userId,
            string? teamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a user's Grid settings by team ID or your only team<br/>
        /// Returns the user's spend limit for Baseten Grid in the team, their spend in the team this month, and whether that spend reached the limit. Members can read their own settings; team admins can read members' settings in teams they administer, and organization admins can read anyone's. The team comes from `team_id` instead of the path. Omit it to use the team you belong to; when you belong to several, the request fails with a 400.
        /// </summary>
        /// <param name="teamId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/grid/team_settings/users/{user_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.GridTeamUserSettingsV1>> GetGridTeamSettingsUsersByUserIdAsResponseAsync(
            string userId,
            string? teamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}