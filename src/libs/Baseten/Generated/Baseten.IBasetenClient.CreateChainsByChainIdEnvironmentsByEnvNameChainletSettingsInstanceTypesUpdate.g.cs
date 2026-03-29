#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Update a chainlet environment's instance type settings.<br/>
        /// Updates a chainlet environment's instance type settings. The chainlet environment setting must exist. When updated, a new chain deployment is created and deployed. It is promoted to the chain environment according to promotion settings on the environment.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="envName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/environments/{env_name}/chainlet_settings/instance_types/update \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "updates": [<br/>
        ///     {<br/>
        ///       "chainlet_name": "HelloWorld",<br/>
        ///       "instance_type_id": "1x4"<br/>
        ///     },<br/>
        ///     {<br/>
        ///       "chainlet_name": "RandInt",<br/>
        ///       "instance_type_id": "A10G:2x24x96"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.UpdateChainletEnvironmentInstanceTypeResponseV1> CreateChainsByChainIdEnvironmentsByEnvNameChainletSettingsInstanceTypesUpdateAsync(
            string chainId,
            string envName,

            global::Baseten.UpdateChainletEnvironmentInstanceTypeRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a chainlet environment's instance type settings.<br/>
        /// Updates a chainlet environment's instance type settings. The chainlet environment setting must exist. When updated, a new chain deployment is created and deployed. It is promoted to the chain environment according to promotion settings on the environment.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="envName"></param>
        /// <param name="updates">
        /// Mapping of chainlet name to the desired chainlet instance type. If the chainlet name doesn't exist, an error is returned.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.UpdateChainletEnvironmentInstanceTypeResponseV1> CreateChainsByChainIdEnvironmentsByEnvNameChainletSettingsInstanceTypesUpdateAsync(
            string chainId,
            string envName,
            global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentInstanceTypeUpdateV1> updates,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}