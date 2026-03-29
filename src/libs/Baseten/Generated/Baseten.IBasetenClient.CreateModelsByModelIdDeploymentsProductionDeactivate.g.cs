#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deactivates a production deployment<br/>
        /// Deactivates a production deployment and returns the deactivation status.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/production/deactivate \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DeactivateResponseV1> CreateModelsByModelIdDeploymentsProductionDeactivateAsync(
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}