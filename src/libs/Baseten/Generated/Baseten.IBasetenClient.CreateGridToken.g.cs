#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a Grid access token<br/>
        /// Exchanges your Baseten credentials for a short-lived token that authenticates against the Grid gateway as you, in the given team. Tokens expire after four hours and cannot be renewed; request a new one when needed. Routes keys cannot create tokens.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/grid/token \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "team_id": "abc1234"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GridTokenV1> CreateGridTokenAsync(

            global::Baseten.CreateGridTokenRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a Grid access token<br/>
        /// Exchanges your Baseten credentials for a short-lived token that authenticates against the Grid gateway as you, in the given team. Tokens expire after four hours and cannot be renewed; request a new one when needed. Routes keys cannot create tokens.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/grid/token \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "team_id": "abc1234"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.GridTokenV1>> CreateGridTokenAsResponseAsync(

            global::Baseten.CreateGridTokenRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a Grid access token<br/>
        /// Exchanges your Baseten credentials for a short-lived token that authenticates against the Grid gateway as you, in the given team. Tokens expire after four hours and cannot be renewed; request a new one when needed. Routes keys cannot create tokens.
        /// </summary>
        /// <param name="teamId">
        /// ID of the team. When omitted, the team you belong to; required when you belong to several.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.GridTokenV1> CreateGridTokenAsync(
            string? teamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}