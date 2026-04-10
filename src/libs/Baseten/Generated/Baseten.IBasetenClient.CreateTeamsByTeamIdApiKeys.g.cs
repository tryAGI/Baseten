#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a team API key<br/>
        /// Creates a team API key with the provided name and type. The API key is returned in the response.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/teams/{team_id}/api_keys \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "my-api-key",<br/>
        ///   "type": "PERSONAL"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.APIKeyV1> CreateTeamsByTeamIdApiKeysAsync(
            string teamId,

            global::Baseten.CreateAPIKeyRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a team API key<br/>
        /// Creates a team API key with the provided name and type. The API key is returned in the response.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="name">
        /// Optional name for the API key<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Type of the API key.
        /// </param>
        /// <param name="modelIds">
        /// List of model IDs to scope the API key to, only present if type is 'WORKSPACE_EXPORT_METRICS' or 'WORKSPACE_INVOKE'<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.APIKeyV1> CreateTeamsByTeamIdApiKeysAsync(
            string teamId,
            global::Baseten.APIKeyCategory type,
            string? name = default,
            global::System.Collections.Generic.IList<string>? modelIds = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}