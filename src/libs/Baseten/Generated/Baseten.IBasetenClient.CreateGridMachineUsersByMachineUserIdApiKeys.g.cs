#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates an API key for a machine user<br/>
        /// The machine user's other API keys stay active. Requires team admin for the machine user's team.
        /// </summary>
        /// <param name="machineUserId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/grid/machine_users/{machine_user_id}/api_keys \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "production"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.APIKeyV1> CreateGridMachineUsersByMachineUserIdApiKeysAsync(
            string machineUserId,

            global::Baseten.CreateGridMachineUserAPIKeyRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates an API key for a machine user<br/>
        /// The machine user's other API keys stay active. Requires team admin for the machine user's team.
        /// </summary>
        /// <param name="machineUserId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/grid/machine_users/{machine_user_id}/api_keys \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "production"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.APIKeyV1>> CreateGridMachineUsersByMachineUserIdApiKeysAsResponseAsync(
            string machineUserId,

            global::Baseten.CreateGridMachineUserAPIKeyRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates an API key for a machine user<br/>
        /// The machine user's other API keys stay active. Requires team admin for the machine user's team.
        /// </summary>
        /// <param name="machineUserId"></param>
        /// <param name="name">
        /// Name of the API key: lowercase letters, numbers, and hyphens, at most 255 characters, and unique among the machine user's active keys. Defaults to a name derived from the machine user's.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.APIKeyV1> CreateGridMachineUsersByMachineUserIdApiKeysAsync(
            string machineUserId,
            string? name = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}