#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Create an environment<br/>
        /// Creates an environment for the specified model and returns the environment.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "staging",<br/>
        ///   "autoscaling_settings": {<br/>
        ///     "autoscaling_window": 800,<br/>
        ///     "concurrency_target": 3,<br/>
        ///     "max_replica": 2,<br/>
        ///     "min_replica": 1,<br/>
        ///     "scale_down_delay": 60,<br/>
        ///     "target_in_flight_tokens": null,<br/>
        ///     "target_utilization_percentage": null<br/>
        ///   },<br/>
        ///   "promotion_settings": {<br/>
        ///     "promotion_cleanup_strategy": null,<br/>
        ///     "ramp_up_duration_seconds": 600,<br/>
        ///     "ramp_up_while_promoting": true,<br/>
        ///     "redeploy_on_promotion": true,<br/>
        ///     "rolling_deploy": true,<br/>
        ///     "rolling_deploy_config": null<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.EnvironmentV1> CreateModelsByModelIdEnvironmentsAsync(
            string modelId,

            global::Baseten.CreateEnvironmentRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an environment<br/>
        /// Creates an environment for the specified model and returns the environment.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="name">
        /// Name of the environment
        /// </param>
        /// <param name="autoscalingSettings">
        /// Autoscaling settings for the environment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="promotionSettings">
        /// Promotion settings for the environment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.EnvironmentV1> CreateModelsByModelIdEnvironmentsAsync(
            string modelId,
            string name,
            global::Baseten.UpdateAutoscalingSettingsV1? autoscalingSettings = default,
            global::Baseten.UpdatePromotionSettingsV1? promotionSettings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}