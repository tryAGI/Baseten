#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets the logs for a chainlet within a chain deployment.<br/>
        /// Resolves the chainlet (by ID, scoped to the given chain deployment) to its underlying model deployment and returns its logs in the given time range.
        /// </summary>
        /// <param name="startEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="direction">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 500
        /// </param>
        /// <param name="minLevel">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="replica">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="component">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="searchPattern">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="includes"></param>
        /// <param name="excludes"></param>
        /// <param name="chainId"></param>
        /// <param name="chainDeploymentId"></param>
        /// <param name="chainletId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/deployments/{chain_deployment_id}/chainlets/{chainlet_id}/logs \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetLogsResponseV1> GetChainsByChainIdDeploymentsByChainDeploymentIdChainletsByChainletIdLogsAsync(
            string chainId,
            string chainDeploymentId,
            string chainletId,
            int? startEpochMillis = default,
            int? endEpochMillis = default,
            global::Baseten.SortOrderV1? direction = default,
            int? limit = default,
            global::Baseten.LogLevelV1? minLevel = default,
            string? replica = default,
            string? requestId = default,
            string? component = default,
            string? searchPattern = default,
            global::System.Collections.Generic.IList<string>? includes = default,
            global::System.Collections.Generic.IList<string>? excludes = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the logs for a chainlet within a chain deployment.<br/>
        /// Resolves the chainlet (by ID, scoped to the given chain deployment) to its underlying model deployment and returns its logs in the given time range.
        /// </summary>
        /// <param name="startEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="direction">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 500
        /// </param>
        /// <param name="minLevel">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="replica">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="component">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="searchPattern">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="includes"></param>
        /// <param name="excludes"></param>
        /// <param name="chainId"></param>
        /// <param name="chainDeploymentId"></param>
        /// <param name="chainletId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/deployments/{chain_deployment_id}/chainlets/{chainlet_id}/logs \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.GetLogsResponseV1>> GetChainsByChainIdDeploymentsByChainDeploymentIdChainletsByChainletIdLogsAsResponseAsync(
            string chainId,
            string chainDeploymentId,
            string chainletId,
            int? startEpochMillis = default,
            int? endEpochMillis = default,
            global::Baseten.SortOrderV1? direction = default,
            int? limit = default,
            global::Baseten.LogLevelV1? minLevel = default,
            string? replica = default,
            string? requestId = default,
            string? component = default,
            string? searchPattern = default,
            global::System.Collections.Generic.IList<string>? includes = default,
            global::System.Collections.Generic.IList<string>? excludes = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}