#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a user's spend limits<br/>
        /// Once the user's metered spend in a month reaches the limit, requests with Routes keys they created are rejected until the limit is raised or the next month starts. A limit of 0 blocks the user after their first metered request. Spend is metered every 15 minutes and can lag, so a user can go over the limit. If the user has spend this month, changes take effect within seconds; otherwise at the next metering run.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/routes/spend_limits/{user_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "monthly_limit_usd": "200"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RouteSpendLimitV1> EditRoutesSpendLimitsByUserIdAsync(
            string userId,

            global::Baseten.UpdateRouteSpendLimitRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a user's spend limits<br/>
        /// Once the user's metered spend in a month reaches the limit, requests with Routes keys they created are rejected until the limit is raised or the next month starts. A limit of 0 blocks the user after their first metered request. Spend is metered every 15 minutes and can lag, so a user can go over the limit. If the user has spend this month, changes take effect within seconds; otherwise at the next metering run.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/routes/spend_limits/{user_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "monthly_limit_usd": "200"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RouteSpendLimitV1>> EditRoutesSpendLimitsByUserIdAsResponseAsync(
            string userId,

            global::Baseten.UpdateRouteSpendLimitRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a user's spend limits<br/>
        /// Once the user's metered spend in a month reaches the limit, requests with Routes keys they created are rejected until the limit is raised or the next month starts. A limit of 0 blocks the user after their first metered request. Spend is metered every 15 minutes and can lag, so a user can go over the limit. If the user has spend this month, changes take effect within seconds; otherwise at the next metering run.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="monthlyLimitUsd">
        /// Standing spend limit in USD for each UTC calendar month, as a non-negative decimal string with at most 9 decimal places. Send null to remove the limit; omit to leave it unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.RouteSpendLimitV1> EditRoutesSpendLimitsByUserIdAsync(
            string userId,
            string? monthlyLimitUsd = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}