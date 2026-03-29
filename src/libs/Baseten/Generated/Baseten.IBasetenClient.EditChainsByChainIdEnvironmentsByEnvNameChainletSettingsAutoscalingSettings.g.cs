#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Update a chainlet environment's autoscaling settings<br/>
        /// Updates a chainlet environment's autoscaling settings and returns the updated chainlet environment settings.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="envName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/environments/{env_name}/chainlet_settings/autoscaling_settings \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "updates": [<br/>
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
        ///       "chainlet_name": "HelloWorld"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.UpdateAutoscalingSettingsResponseV1> EditChainsByChainIdEnvironmentsByEnvNameChainletSettingsAutoscalingSettingsAsync(
            string chainId,
            string envName,

            global::Baseten.UpdateChainletEnvironmentAutoscalingSettingsRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a chainlet environment's autoscaling settings<br/>
        /// Updates a chainlet environment's autoscaling settings and returns the updated chainlet environment settings.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="envName"></param>
        /// <param name="updates">
        /// Mapping of chainlet name to the desired chainlet autoscaling settings. If the chainlet name doesn't exist, an error is returned.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.UpdateAutoscalingSettingsResponseV1> EditChainsByChainIdEnvironmentsByEnvNameChainletSettingsAutoscalingSettingsAsync(
            string chainId,
            string envName,
            global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentAutoscalingSettingsUpdateV1> updates,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}