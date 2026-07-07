#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets the metrics for a model deployment<br/>
        /// Gets the metrics for a model deployment in the given time range.
        /// </summary>
        /// <param name="mode">
        /// How metric values are aggregated over the request.<br/>
        /// Default Value: CURRENT
        /// </param>
        /// <param name="startEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metrics"></param>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/metrics \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetDeploymentMetricsResponseV1> GetModelsByModelIdDeploymentsByDeploymentIdMetricsAsync(
            string modelId,
            string deploymentId,
            global::Baseten.DeploymentMetricModeV1? mode = default,
            int? startEpochMillis = default,
            int? endEpochMillis = default,
            global::System.Collections.Generic.IList<string>? metrics = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the metrics for a model deployment<br/>
        /// Gets the metrics for a model deployment in the given time range.
        /// </summary>
        /// <param name="mode">
        /// How metric values are aggregated over the request.<br/>
        /// Default Value: CURRENT
        /// </param>
        /// <param name="startEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metrics"></param>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/metrics \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.GetDeploymentMetricsResponseV1>> GetModelsByModelIdDeploymentsByDeploymentIdMetricsAsResponseAsync(
            string modelId,
            string deploymentId,
            global::Baseten.DeploymentMetricModeV1? mode = default,
            int? startEpochMillis = default,
            int? endEpochMillis = default,
            global::System.Collections.Generic.IList<string>? metrics = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}