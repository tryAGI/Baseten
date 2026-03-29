#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Activates a deployment<br/>
        /// Activates an inactive deployment and returns the activation status.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/activate \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ActivateResponseV1> CreateModelsByModelIdDeploymentsByDeploymentIdActivateAsync(
            string modelId,
            string deploymentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}