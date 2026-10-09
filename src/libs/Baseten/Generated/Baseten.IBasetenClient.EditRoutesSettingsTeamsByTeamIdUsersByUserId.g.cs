#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a user's route settings in a team<br/>
        /// Changes only the fields in the request. Once the user's metered spend in the team in a month reaches the spend limit, requests with Routes keys they created in the team are rejected until the limit is raised or the next month starts. Spend is metered every 15 minutes and can lag, so a user can go over the limit. Requires team admin for the specified team or organization admin.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/routes/settings/teams/{team_id}/users/{user_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "spend_limit": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RouteTeamUserSettingsV1> EditRoutesSettingsTeamsByTeamIdUsersByUserIdAsync(
            string teamId,
            string userId,

            global::Baseten.UpdateRouteUserSettingsRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a user's route settings in a team<br/>
        /// Changes only the fields in the request. Once the user's metered spend in the team in a month reaches the spend limit, requests with Routes keys they created in the team are rejected until the limit is raised or the next month starts. Spend is metered every 15 minutes and can lag, so a user can go over the limit. Requires team admin for the specified team or organization admin.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/routes/settings/teams/{team_id}/users/{user_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "spend_limit": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RouteTeamUserSettingsV1>> EditRoutesSettingsTeamsByTeamIdUsersByUserIdAsResponseAsync(
            string teamId,
            string userId,

            global::Baseten.UpdateRouteUserSettingsRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a user's route settings in a team<br/>
        /// Changes only the fields in the request. Once the user's metered spend in the team in a month reaches the spend limit, requests with Routes keys they created in the team are rejected until the limit is raised or the next month starts. Spend is metered every 15 minutes and can lag, so a user can go over the limit. Requires team admin for the specified team or organization admin.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="userId"></param>
        /// <param name="spendLimit">
        /// Spend limit fields to change. Pass null to remove the user's limit; omit to leave it unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.RouteTeamUserSettingsV1> EditRoutesSettingsTeamsByTeamIdUsersByUserIdAsync(
            string teamId,
            string userId,
            global::Baseten.UpdateRouteSpendLimitSettingV1? spendLimit = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}