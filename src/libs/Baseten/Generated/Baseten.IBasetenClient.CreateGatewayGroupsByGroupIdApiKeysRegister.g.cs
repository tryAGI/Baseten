#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Registers an API key for a group<br/>
        /// Registers a Gateway API key with the provided value and name.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/gateway/groups/{group_id}/api_keys/register \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "my-model-api-key",<br/>
        ///   "key": "my-secure-api-key-value"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RegisterAPIKeyResponseV1> CreateGatewayGroupsByGroupIdApiKeysRegisterAsync(
            string groupId,

            global::Baseten.RegisterAPIKeyRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Registers an API key for a group<br/>
        /// Registers a Gateway API key with the provided value and name.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/gateway/groups/{group_id}/api_keys/register \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "my-model-api-key",<br/>
        ///   "key": "my-secure-api-key-value"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RegisterAPIKeyResponseV1>> CreateGatewayGroupsByGroupIdApiKeysRegisterAsResponseAsync(
            string groupId,

            global::Baseten.RegisterAPIKeyRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Registers an API key for a group<br/>
        /// Registers a Gateway API key with the provided value and name.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="name">
        /// Optional name for the Model API key<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="key">
        /// Value of the API key to register
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.RegisterAPIKeyResponseV1> CreateGatewayGroupsByGroupIdApiKeysRegisterAsync(
            string groupId,
            string key,
            string? name = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}