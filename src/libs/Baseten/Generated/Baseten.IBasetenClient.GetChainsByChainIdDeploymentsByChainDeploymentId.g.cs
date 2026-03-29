#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets a chain deployment by ID
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="chainDeploymentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/deployments/{chain_deployment_id} \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ChainDeploymentV1> GetChainsByChainIdDeploymentsByChainDeploymentIdAsync(
            string chainId,
            string chainDeploymentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}