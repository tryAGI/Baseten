#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets the logs for a chainlet within a chain deployment.<br/>
        /// Resolves the chainlet (by ID, scoped to the given chain deployment) to its underlying model deployment and returns its logs in the given time range.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="chainDeploymentId"></param>
        /// <param name="chainletId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/deployments/{chain_deployment_id}/chainlets/{chainlet_id}/logs \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "start_epoch_millis": null,<br/>
        ///   "end_epoch_millis": null,<br/>
        ///   "direction": null,<br/>
        ///   "limit": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetLogsResponseV1> CreateChainsByChainIdDeploymentsByChainDeploymentIdChainletsByChainletIdLogsAsync(
            string chainId,
            string chainDeploymentId,
            string chainletId,

            global::Baseten.GetDeploymentLogsRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the logs for a chainlet within a chain deployment.<br/>
        /// Resolves the chainlet (by ID, scoped to the given chain deployment) to its underlying model deployment and returns its logs in the given time range.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="chainDeploymentId"></param>
        /// <param name="chainletId"></param>
        /// <param name="startEpochMillis">
        /// Epoch millis timestamp to start fetching logs<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endEpochMillis">
        /// Epoch millis timestamp to end fetching logs<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="direction">
        /// Sort order for logs<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Limit of logs to fetch in a single request<br/>
        /// Default Value: 500
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.GetLogsResponseV1> CreateChainsByChainIdDeploymentsByChainDeploymentIdChainletsByChainletIdLogsAsync(
            string chainId,
            string chainDeploymentId,
            string chainletId,
            int? startEpochMillis = default,
            int? endEpochMillis = default,
            global::Baseten.SortOrderV1? direction = default,
            int? limit = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}