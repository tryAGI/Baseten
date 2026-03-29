#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Update a chain environment's settings<br/>
        /// Update a chain environment's settings and returns the chain environment.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="envName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/environments/{env_name} \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "promotion_settings": {<br/>
        ///     "promotion_cleanup_strategy": null,<br/>
        ///     "ramp_up_duration_seconds": 600,<br/>
        ///     "ramp_up_while_promoting": true,<br/>
        ///     "redeploy_on_promotion": null,<br/>
        ///     "rolling_deploy": null,<br/>
        ///     "rolling_deploy_config": null<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.UpdateChainEnvironmentResponseV1> EditChainsByChainIdEnvironmentsByEnvNameAsync(
            string chainId,
            string envName,

            global::Baseten.UpdateChainEnvironmentRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a chain environment's settings<br/>
        /// Update a chain environment's settings and returns the chain environment.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="envName"></param>
        /// <param name="promotionSettings">
        /// Promotion settings for the environment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.UpdateChainEnvironmentResponseV1> EditChainsByChainIdEnvironmentsByEnvNameAsync(
            string chainId,
            string envName,
            global::Baseten.UpdatePromotionSettingsV1? promotionSettings = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}