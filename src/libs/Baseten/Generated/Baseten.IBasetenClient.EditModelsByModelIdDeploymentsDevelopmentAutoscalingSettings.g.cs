#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a development deployment's autoscaling settings<br/>
        /// Updates a development deployment's autoscaling settings and returns the update status.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/development/autoscaling_settings \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "min_replica": 0,<br/>
        ///   "max_replica": 7,<br/>
        ///   "autoscaling_window": 600,<br/>
        ///   "scale_down_delay": 120,<br/>
        ///   "concurrency_target": 2,<br/>
        ///   "target_utilization_percentage": 70,<br/>
        ///   "target_in_flight_tokens": 40000<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.UpdateAutoscalingSettingsResponseV1> EditModelsByModelIdDeploymentsDevelopmentAutoscalingSettingsAsync(
            string modelId,

            global::Baseten.UpdateAutoscalingSettingsV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a development deployment's autoscaling settings<br/>
        /// Updates a development deployment's autoscaling settings and returns the update status.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="minReplica">
        /// Minimum number of replicas<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="maxReplica">
        /// Maximum number of replicas<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="autoscalingWindow">
        /// Timeframe of traffic considered for autoscaling decisions<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="scaleDownDelay">
        /// Waiting period before scaling down any active replica<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="concurrencyTarget">
        /// Number of requests per replica before scaling up<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="targetUtilizationPercentage">
        /// Target utilization percentage for scaling up/down.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="targetInFlightTokens">
        /// Target number of in-flight tokens for autoscaling decisions. Early access only.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.UpdateAutoscalingSettingsResponseV1> EditModelsByModelIdDeploymentsDevelopmentAutoscalingSettingsAsync(
            string modelId,
            int? minReplica = default,
            int? maxReplica = default,
            int? autoscalingWindow = default,
            int? scaleDownDelay = default,
            int? concurrencyTarget = default,
            int? targetUtilizationPercentage = default,
            int? targetInFlightTokens = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}