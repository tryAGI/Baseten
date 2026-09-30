#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Lists default models for coding harnesses<br/>
        /// Each role uses the route a team admin set for it (`source` is `team`). A role with no route set uses Baseten's default (`source` is `baseten`), chosen from the team's Model API routes: the recommended model for `primary` and the lowest-priced model for `background`. Baseten's defaults never use external-provider routes.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/routes/harness-configs \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RouteHarnessConfigsResponseV1> GetRoutesHarnessConfigsAsync(
            string teamId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lists default models for coding harnesses<br/>
        /// Each role uses the route a team admin set for it (`source` is `team`). A role with no route set uses Baseten's default (`source` is `baseten`), chosen from the team's Model API routes: the recommended model for `primary` and the lowest-priced model for `background`. Baseten's defaults never use external-provider routes.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/routes/harness-configs \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RouteHarnessConfigsResponseV1>> GetRoutesHarnessConfigsAsResponseAsync(
            string teamId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}