#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deletes an environment<br/>
        /// Deletes an environment and returns its tombstone. Any in-progress promotion to the environment is canceled, and the deployment currently serving the environment is scaled down to zero replicas rather than deleted. The production environment cannot be deleted.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.EnvironmentTombstoneV1> DeleteModelsByModelIdEnvironmentsByEnvNameAsync(
            string modelId,
            string envName,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes an environment<br/>
        /// Deletes an environment and returns its tombstone. Any in-progress promotion to the environment is canceled, and the deployment currently serving the environment is scaled down to zero replicas rather than deleted. The production environment cannot be deleted.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.EnvironmentTombstoneV1>> DeleteModelsByModelIdEnvironmentsByEnvNameAsResponseAsync(
            string modelId,
            string envName,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}