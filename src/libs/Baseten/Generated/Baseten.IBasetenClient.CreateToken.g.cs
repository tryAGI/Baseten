#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a sandbox access token<br/>
        /// Exchanges your Baseten credentials for a short-lived token that authenticates against the sandbox API. The token carries every team you belong to. Tokens expire after two hours and cannot be renewed; request a new one when needed. This endpoint is experimental and may change or be removed without notice.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/token \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "scopes": [<br/>
        ///     "sandboxes"<br/>
        ///   ]<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.TokenV1> CreateTokenAsync(

            global::Baseten.CreateTokenRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a sandbox access token<br/>
        /// Exchanges your Baseten credentials for a short-lived token that authenticates against the sandbox API. The token carries every team you belong to. Tokens expire after two hours and cannot be renewed; request a new one when needed. This endpoint is experimental and may change or be removed without notice.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/token \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "scopes": [<br/>
        ///     "sandboxes"<br/>
        ///   ]<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.TokenV1>> CreateTokenAsResponseAsync(

            global::Baseten.CreateTokenRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a sandbox access token<br/>
        /// Exchanges your Baseten credentials for a short-lived token that authenticates against the sandbox API. The token carries every team you belong to. Tokens expire after two hours and cannot be renewed; request a new one when needed. This endpoint is experimental and may change or be removed without notice.
        /// </summary>
        /// <param name="scopes">
        /// What the token should grant access to. Only `sandboxes` is supported today; the token then authenticates against the sandbox API.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.TokenV1> CreateTokenAsync(
            global::System.Collections.Generic.IList<global::Baseten.TokenScopeV1> scopes,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}