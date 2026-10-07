#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a connection<br/>
        /// Creates a connection from the team to an upstream provider.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/routes/connections \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "team_id": "abc1234",<br/>
        ///   "config": {<br/>
        ///     "provider": "ANTHROPIC",<br/>
        ///     "secret_id": "abc1234"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RouteConnectionV1> CreateRoutesConnectionsAsync(

            global::Baseten.CreateRouteConnectionRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a connection<br/>
        /// Creates a connection from the team to an upstream provider.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/routes/connections \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "team_id": "abc1234",<br/>
        ///   "config": {<br/>
        ///     "provider": "ANTHROPIC",<br/>
        ///     "secret_id": "abc1234"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RouteConnectionV1>> CreateRoutesConnectionsAsResponseAsync(

            global::Baseten.CreateRouteConnectionRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a connection<br/>
        /// Creates a connection from the team to an upstream provider.
        /// </summary>
        /// <param name="teamId">
        /// Identifier of the team that owns the connection.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="config">
        /// Provider the connection authenticates with, and the team secret holding its API key.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.RouteConnectionV1> CreateRoutesConnectionsAsync(
            global::Baseten.Config2 config,
            string? teamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}