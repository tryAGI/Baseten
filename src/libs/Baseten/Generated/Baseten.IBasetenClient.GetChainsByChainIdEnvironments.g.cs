#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Get all chain environments<br/>
        /// Gets all chain environments for a given chain
        /// </summary>
        /// <param name="chainId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/environments \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.EnvironmentsV1> GetChainsByChainIdEnvironmentsAsync(
            string chainId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}