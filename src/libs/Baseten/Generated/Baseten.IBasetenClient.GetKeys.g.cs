#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Lists API keys (metadata only, no plain text keys)<br/>
        /// Returns metadata for your personal API keys and the workspace and team API keys you can manage. Organization admins also receive every member's personal API keys, each with an owner identifying the member it belongs to.
        /// </summary>
        /// <param name="type">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="createdByMe">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/api_keys \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.APIKeysV1> GetKeysAsync(
            global::Baseten.APIKeyCategory? type = default,
            bool? createdByMe = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lists API keys (metadata only, no plain text keys)<br/>
        /// Returns metadata for your personal API keys and the workspace and team API keys you can manage. Organization admins also receive every member's personal API keys, each with an owner identifying the member it belongs to.
        /// </summary>
        /// <param name="type">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="createdByMe">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/api_keys \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.APIKeysV1>> GetKeysAsResponseAsync(
            global::Baseten.APIKeyCategory? type = default,
            bool? createdByMe = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}