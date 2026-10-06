#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a user's route settings<br/>
        /// Changes only the fields in the request. Once the user's metered spend in a month reaches the spend limit, requests with Routes keys they created are rejected until the limit is raised or the next month starts. Spend is metered every 15 minutes and can lag, so a user can go over the limit. The user's own limit supersedes their team's per-member limit.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/routes/settings/users/{user_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "spend_limit": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RouteUserSettingsV1> EditRoutesSettingsUsersByUserIdAsync(
            string userId,

            global::Baseten.UpdateRouteUserSettingsRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a user's route settings<br/>
        /// Changes only the fields in the request. Once the user's metered spend in a month reaches the spend limit, requests with Routes keys they created are rejected until the limit is raised or the next month starts. Spend is metered every 15 minutes and can lag, so a user can go over the limit. The user's own limit supersedes their team's per-member limit.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/routes/settings/users/{user_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "spend_limit": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RouteUserSettingsV1>> EditRoutesSettingsUsersByUserIdAsResponseAsync(
            string userId,

            global::Baseten.UpdateRouteUserSettingsRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a user's route settings<br/>
        /// Changes only the fields in the request. Once the user's metered spend in a month reaches the spend limit, requests with Routes keys they created are rejected until the limit is raised or the next month starts. Spend is metered every 15 minutes and can lag, so a user can go over the limit. The user's own limit supersedes their team's per-member limit.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="spendLimit">
        /// Spend limit fields to change. Pass null to remove the user's limit; omit to leave it unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.RouteUserSettingsV1> EditRoutesSettingsUsersByUserIdAsync(
            string userId,
            global::Baseten.UpdateRouteSpendLimitSettingV1? spendLimit = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}