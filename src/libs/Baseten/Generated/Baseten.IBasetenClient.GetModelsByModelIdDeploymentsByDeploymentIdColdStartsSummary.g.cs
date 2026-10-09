#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets the cold start summary for a model deployment<br/>
        /// Gets the distribution of replica cold start durations, in total and per phase, in the given time range.
        /// </summary>
        /// <param name="startEpochMillis"></param>
        /// <param name="endEpochMillis"></param>
        /// <param name="minDurationMs">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/cold_starts/summary \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ColdStartSummaryV1> GetModelsByModelIdDeploymentsByDeploymentIdColdStartsSummaryAsync(
            int startEpochMillis,
            int endEpochMillis,
            string modelId,
            string deploymentId,
            int? minDurationMs = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the cold start summary for a model deployment<br/>
        /// Gets the distribution of replica cold start durations, in total and per phase, in the given time range.
        /// </summary>
        /// <param name="startEpochMillis"></param>
        /// <param name="endEpochMillis"></param>
        /// <param name="minDurationMs">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/cold_starts/summary \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ColdStartSummaryV1>> GetModelsByModelIdDeploymentsByDeploymentIdColdStartsSummaryAsResponseAsync(
            int startEpochMillis,
            int endEpochMillis,
            string modelId,
            string deploymentId,
            int? minDurationMs = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}