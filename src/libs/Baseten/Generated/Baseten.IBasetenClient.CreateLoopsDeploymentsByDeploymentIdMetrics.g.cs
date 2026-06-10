#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Get metrics for a Loops trainer deployment.<br/>
        /// Returns per-node GPU/CPU/memory utilization and Knative queue-proxy request rate / concurrency / latency for the trainer pods. The sampler half of a Loops deployment is an OracleVersion and uses the existing model-metrics endpoint.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/deployments/{deployment_id}/metrics \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "end_epoch_millis": null,<br/>
        ///   "start_epoch_millis": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetLoopsDeploymentMetricsResponseV1> CreateLoopsDeploymentsByDeploymentIdMetricsAsync(
            string deploymentId,

            global::Baseten.GetLoopsDeploymentMetricsRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get metrics for a Loops trainer deployment.<br/>
        /// Returns per-node GPU/CPU/memory utilization and Knative queue-proxy request rate / concurrency / latency for the trainer pods. The sampler half of a Loops deployment is an OracleVersion and uses the existing model-metrics endpoint.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/deployments/{deployment_id}/metrics \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "end_epoch_millis": null,<br/>
        ///   "start_epoch_millis": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.GetLoopsDeploymentMetricsResponseV1>> CreateLoopsDeploymentsByDeploymentIdMetricsAsResponseAsync(
            string deploymentId,

            global::Baseten.GetLoopsDeploymentMetricsRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get metrics for a Loops trainer deployment.<br/>
        /// Returns per-node GPU/CPU/memory utilization and Knative queue-proxy request rate / concurrency / latency for the trainer pods. The sampler half of a Loops deployment is an OracleVersion and uses the existing model-metrics endpoint.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="endEpochMillis">
        /// Epoch millis to end fetching metrics.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="startEpochMillis">
        /// Epoch millis to start fetching metrics.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.GetLoopsDeploymentMetricsResponseV1> CreateLoopsDeploymentsByDeploymentIdMetricsAsync(
            string deploymentId,
            int? endEpochMillis = default,
            int? startEpochMillis = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}