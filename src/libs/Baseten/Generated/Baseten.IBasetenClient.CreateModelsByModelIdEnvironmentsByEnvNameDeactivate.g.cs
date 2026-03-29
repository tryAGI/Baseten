#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deactivates a deployment associated with an environment<br/>
        /// Deactivates a deployment associated with an environment and returns the deactivation status.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/deactivate \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DeactivateResponseV1> CreateModelsByModelIdEnvironmentsByEnvNameDeactivateAsync(
            string modelId,
            string envName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}