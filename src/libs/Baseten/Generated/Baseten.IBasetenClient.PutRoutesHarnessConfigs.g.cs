#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Sets default models for a coding harness<br/>
        /// Replaces every model role of one harness. Roles left out use Baseten's defaults. Requires team admin, and every route must belong to the team. The `harness` in the request body determines which roles are accepted.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PUT \<br/>
        /// --url https://api.baseten.co/v1/routes/harness-configs \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "team_id": "abc1234",<br/>
        ///   "harness": "claude-code",<br/>
        ///   "models": {<br/>
        ///     "primary": "def5678",<br/>
        ///     "background": "ghi9012"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RouteHarnessConfigV1> PutRoutesHarnessConfigsAsync(

            global::Baseten.SetRouteHarnessConfigRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sets default models for a coding harness<br/>
        /// Replaces every model role of one harness. Roles left out use Baseten's defaults. Requires team admin, and every route must belong to the team. The `harness` in the request body determines which roles are accepted.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PUT \<br/>
        /// --url https://api.baseten.co/v1/routes/harness-configs \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "team_id": "abc1234",<br/>
        ///   "harness": "claude-code",<br/>
        ///   "models": {<br/>
        ///     "primary": "def5678",<br/>
        ///     "background": "ghi9012"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RouteHarnessConfigV1>> PutRoutesHarnessConfigsAsResponseAsync(

            global::Baseten.SetRouteHarnessConfigRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}