#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Activates a deployment associated with an environment<br/>
        /// Activates an inactive deployment associated with an environment and returns the activation status.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/activate \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ActivateResponseV1> CreateModelsByModelIdEnvironmentsByEnvNameActivateAsync(
            string modelId,
            string envName,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}