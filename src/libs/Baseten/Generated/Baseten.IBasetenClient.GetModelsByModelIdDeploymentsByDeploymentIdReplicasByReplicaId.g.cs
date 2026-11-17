#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets a replica in a deployment<br/>
        /// Returns lifecycle information without metrics, including for terminated replicas. Returns 404 if the replica does not exist in the specified deployment. Returns 400 if multiple replicas match the replica ID.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="replicaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/replicas/{replica_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DeploymentReplicaV1> GetModelsByModelIdDeploymentsByDeploymentIdReplicasByReplicaIdAsync(
            string modelId,
            string deploymentId,
            string replicaId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a replica in a deployment<br/>
        /// Returns lifecycle information without metrics, including for terminated replicas. Returns 404 if the replica does not exist in the specified deployment. Returns 400 if multiple replicas match the replica ID.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="replicaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/replicas/{replica_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.DeploymentReplicaV1>> GetModelsByModelIdDeploymentsByDeploymentIdReplicasByReplicaIdAsResponseAsync(
            string modelId,
            string deploymentId,
            string replicaId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}