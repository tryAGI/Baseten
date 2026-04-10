#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deletes an API key by prefix<br/>
        /// Deletes an API key by prefix and returns info about the API key.
        /// </summary>
        /// <param name="apiKeyPrefix"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/api_keys/{api_key_prefix} \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.APIKeyTombstoneV1> DeleteKeysByApiKeyPrefixAsync(
            string apiKeyPrefix,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}