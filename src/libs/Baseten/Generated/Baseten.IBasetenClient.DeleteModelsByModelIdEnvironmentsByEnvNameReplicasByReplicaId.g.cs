#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Terminates a replica in an environment<br/>
        /// Requests replica termination in the environment's current deployment. Returns 404 if the environment has no current deployment or no replica matches the replica ID. Returns 400 without requesting termination if multiple replicas in the current deployment match the replica ID.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="replicaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/replicas/{replica_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.TerminateReplicaResponseV1> DeleteModelsByModelIdEnvironmentsByEnvNameReplicasByReplicaIdAsync(
            string modelId,
            string envName,
            string replicaId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Terminates a replica in an environment<br/>
        /// Requests replica termination in the environment's current deployment. Returns 404 if the environment has no current deployment or no replica matches the replica ID. Returns 400 without requesting termination if multiple replicas in the current deployment match the replica ID.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="replicaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/replicas/{replica_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.TerminateReplicaResponseV1>> DeleteModelsByModelIdEnvironmentsByEnvNameReplicasByReplicaIdAsResponseAsync(
            string modelId,
            string envName,
            string replicaId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}