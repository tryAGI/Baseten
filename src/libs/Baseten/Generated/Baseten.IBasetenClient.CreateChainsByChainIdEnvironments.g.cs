#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Create a chain environment<br/>
        /// Create a chain environment. Returns the resulting environment.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/environments \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "staging",<br/>
        ///   "promotion_settings": {<br/>
        ///     "promotion_cleanup_strategy": null,<br/>
        ///     "ramp_up_duration_seconds": 600,<br/>
        ///     "ramp_up_while_promoting": true,<br/>
        ///     "redeploy_on_promotion": true,<br/>
        ///     "rolling_deploy": null,<br/>
        ///     "rolling_deploy_config": null<br/>
        ///   },<br/>
        ///   "chainlet_settings": [<br/>
        ///     {<br/>
        ///       "autoscaling_settings": {<br/>
        ///         "autoscaling_window": 800,<br/>
        ///         "concurrency_target": 4,<br/>
        ///         "max_replica": 3,<br/>
        ///         "min_replica": 2,<br/>
        ///         "scale_down_delay": 63,<br/>
        ///         "target_in_flight_tokens": null,<br/>
        ///         "target_utilization_percentage": null<br/>
        ///       },<br/>
        ///       "chainlet_name": "HelloWorld",<br/>
        ///       "instance_type_id": "2x8"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "autoscaling_settings": {<br/>
        ///         "autoscaling_window": null,<br/>
        ///         "concurrency_target": null,<br/>
        ///         "max_replica": 3,<br/>
        ///         "min_replica": 3,<br/>
        ///         "scale_down_delay": null,<br/>
        ///         "target_in_flight_tokens": null,<br/>
        ///         "target_utilization_percentage": null<br/>
        ///       },<br/>
        ///       "chainlet_name": "RandInt",<br/>
        ///       "instance_type_id": "A10Gx8x32"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ChainEnvironmentV1> CreateChainsByChainIdEnvironmentsAsync(
            string chainId,

            global::Baseten.CreateChainEnvironmentRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chain environment<br/>
        /// Create a chain environment. Returns the resulting environment.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="name">
        /// Name of the environment
        /// </param>
        /// <param name="promotionSettings">
        /// Promotion settings for the environment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chainletSettings">
        /// Mapping of chainlet name to the desired chainlet environment settings<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.ChainEnvironmentV1> CreateChainsByChainIdEnvironmentsAsync(
            string chainId,
            string name,
            global::Baseten.UpdatePromotionSettingsV1? promotionSettings = default,
            global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentSettingsRequestV1>? chainletSettings = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}