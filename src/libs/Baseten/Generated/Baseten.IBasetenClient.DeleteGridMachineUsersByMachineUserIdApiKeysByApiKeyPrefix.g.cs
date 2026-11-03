#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Revokes a machine user's API key<br/>
        /// The machine user's other API keys stay active. Requires team admin for the machine user's team.
        /// </summary>
        /// <param name="machineUserId"></param>
        /// <param name="apiKeyPrefix"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/grid/machine_users/{machine_user_id}/api_keys/{api_key_prefix} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.APIKeyTombstoneV1> DeleteGridMachineUsersByMachineUserIdApiKeysByApiKeyPrefixAsync(
            string machineUserId,
            string apiKeyPrefix,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Revokes a machine user's API key<br/>
        /// The machine user's other API keys stay active. Requires team admin for the machine user's team.
        /// </summary>
        /// <param name="machineUserId"></param>
        /// <param name="apiKeyPrefix"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/grid/machine_users/{machine_user_id}/api_keys/{api_key_prefix} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.APIKeyTombstoneV1>> DeleteGridMachineUsersByMachineUserIdApiKeysByApiKeyPrefixAsResponseAsync(
            string machineUserId,
            string apiKeyPrefix,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}