#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets a replica in an environment<br/>
        /// Searches deployments active in the environment during the preceding hour. Includes retained terminated replicas. Returns 404 if the replica is outside this scope. Returns 400 if multiple replicas match the replica ID.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="replicaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/replicas/{replica_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DeploymentReplicaV1> GetModelsByModelIdEnvironmentsByEnvNameReplicasByReplicaIdAsync(
            string modelId,
            string envName,
            string replicaId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a replica in an environment<br/>
        /// Searches deployments active in the environment during the preceding hour. Includes retained terminated replicas. Returns 404 if the replica is outside this scope. Returns 400 if multiple replicas match the replica ID.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="replicaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/replicas/{replica_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.DeploymentReplicaV1>> GetModelsByModelIdEnvironmentsByEnvNameReplicasByReplicaIdAsResponseAsync(
            string modelId,
            string envName,
            string replicaId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}