#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Get a chain environment's details<br/>
        /// Gets a chain environment's details and returns the chain environment.
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="envName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/environments/{env_name} \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ChainEnvironmentV1> GetChainsByChainIdEnvironmentsByEnvNameAsync(
            string chainId,
            string envName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}