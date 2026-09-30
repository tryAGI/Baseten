#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates default models for a coding harness<br/>
        /// Changes only the model roles in the request and leaves the others unchanged. Set a role to null to use Baseten's default. Requires team admin, and every route must belong to the team.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/routes/harness-configs \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "team_id": "abc1234",<br/>
        ///   "harness": "claude-code",<br/>
        ///   "models": {<br/>
        ///     "background": "ghi9012"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RouteHarnessConfigV1> EditRoutesHarnessConfigsAsync(

            global::Baseten.UpdateRouteHarnessConfigRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates default models for a coding harness<br/>
        /// Changes only the model roles in the request and leaves the others unchanged. Set a role to null to use Baseten's default. Requires team admin, and every route must belong to the team.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/routes/harness-configs \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "team_id": "abc1234",<br/>
        ///   "harness": "claude-code",<br/>
        ///   "models": {<br/>
        ///     "background": "ghi9012"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RouteHarnessConfigV1>> EditRoutesHarnessConfigsAsResponseAsync(

            global::Baseten.UpdateRouteHarnessConfigRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}