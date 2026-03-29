#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets the logs for a model deployment.<br/>
        /// Gets all the logs for a model deployment in the given time range.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/logs \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "start_epoch_millis": null,<br/>
        ///   "end_epoch_millis": null,<br/>
        ///   "direction": null,<br/>
        ///   "limit": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetLogsResponseV1> CreateModelsByModelIdDeploymentsByDeploymentIdLogsAsync(
            string modelId,
            string deploymentId,

            global::Baseten.GetDeploymentLogsRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the logs for a model deployment.<br/>
        /// Gets all the logs for a model deployment in the given time range.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.GetLogsResponseV1> CreateModelsByModelIdDeploymentsByDeploymentIdLogsAsync(
            string modelId,
            string deploymentId,
            int? startEpochMillis = default,
            int? endEpochMillis = default,
            global::Baseten.SortOrderV1? direction = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}