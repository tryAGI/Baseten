#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a route<br/>
        /// Replaces the entire target when provided. The route name and owning team are immutable.
        /// </summary>
        /// <param name="routeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/routes/{route_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "description": "Assistant for code review and debugging.",<br/>
        ///   "display_name": "Assistant",<br/>
        ///   "target": {<br/>
        ///     "model_api": "zai-org/GLM-5.3",<br/>
        ///     "type": "BASETEN_MODEL_API"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RouteV1> EditRoutesByRouteIdAsync(
            string routeId,

            global::Baseten.UpdateRouteRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a route<br/>
        /// Replaces the entire target when provided. The route name and owning team are immutable.
        /// </summary>
        /// <param name="routeId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/routes/{route_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "description": "Assistant for code review and debugging.",<br/>
        ///   "display_name": "Assistant",<br/>
        ///   "target": {<br/>
        ///     "model_api": "zai-org/GLM-5.3",<br/>
        ///     "type": "BASETEN_MODEL_API"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RouteV1>> EditRoutesByRouteIdAsResponseAsync(
            string routeId,

            global::Baseten.UpdateRouteRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a route<br/>
        /// Replaces the entire target when provided. The route name and owning team are immutable.
        /// </summary>
        /// <param name="routeId"></param>
        /// <param name="description">
        /// New description. Omit to keep the current description; use an empty string to clear it. Null is not accepted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="displayName">
        /// New display label. Omit to keep the current label; null is not accepted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="target">
        /// Replaces the entire target. Omit to keep the current target; null is not accepted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.RouteV1> EditRoutesByRouteIdAsync(
            string routeId,
            string? description = default,
            string? displayName = default,
            global::Baseten.TargetVariant1? target = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}