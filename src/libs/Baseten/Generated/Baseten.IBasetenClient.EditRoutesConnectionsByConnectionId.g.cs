#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a connection<br/>
        /// Updates the connection's fields. The provider and owning team are immutable; point the connection at a new team secret to change its API key, or rotate the key itself by updating the secret.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/routes/connections/{connection_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "config": {<br/>
        ///     "provider": "ANTHROPIC",<br/>
        ///     "secret_id": "abc1234"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RouteConnectionV1> EditRoutesConnectionsByConnectionIdAsync(
            string connectionId,

            global::Baseten.UpdateRouteConnectionRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a connection<br/>
        /// Updates the connection's fields. The provider and owning team are immutable; point the connection at a new team secret to change its API key, or rotate the key itself by updating the secret.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/routes/connections/{connection_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "config": {<br/>
        ///     "provider": "ANTHROPIC",<br/>
        ///     "secret_id": "abc1234"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RouteConnectionV1>> EditRoutesConnectionsByConnectionIdAsResponseAsync(
            string connectionId,

            global::Baseten.UpdateRouteConnectionRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a connection<br/>
        /// Updates the connection's fields. The provider and owning team are immutable; point the connection at a new team secret to change its API key, or rotate the key itself by updating the secret.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="config">
        /// Connection fields to change. The provider must match the connection and is immutable.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.RouteConnectionV1> EditRoutesConnectionsByConnectionIdAsync(
            string connectionId,
            global::Baseten.Config3 config,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}