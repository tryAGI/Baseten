#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Checks whether you hold permissions<br/>
        /// Answers each check as fine-grained authorization decides it. Users and service accounts can call it, with the same access as `GET /v1/users/me/access`. Returns 503 while authorization is unavailable.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/access/check \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "checks": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.CheckAccessResponseV1> CreateAccessCheckAsync(

            global::Baseten.CheckAccessRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Checks whether you hold permissions<br/>
        /// Answers each check as fine-grained authorization decides it. Users and service accounts can call it, with the same access as `GET /v1/users/me/access`. Returns 503 while authorization is unavailable.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/access/check \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "checks": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.CheckAccessResponseV1>> CreateAccessCheckAsResponseAsync(

            global::Baseten.CheckAccessRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Checks whether you hold permissions<br/>
        /// Answers each check as fine-grained authorization decides it. Users and service accounts can call it, with the same access as `GET /v1/users/me/access`. Returns 503 while authorization is unavailable.
        /// </summary>
        /// <param name="checks">
        /// Permissions to check, at most 100
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.CheckAccessResponseV1> CreateAccessCheckAsync(
            global::System.Collections.Generic.IList<global::Baseten.AccessCheckV1> checks,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}