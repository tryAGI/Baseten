#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets a deployment's RL weight-sync status<br/>
        /// Lists each replica's lifecycle status and RL weight-sync state, with the revision of the deployment's newest target. A replica is done with a target when its hotload_stage is done and its revision equals the deployment's revision. loading_state is null for a replica that has not reported a state.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/hot_load \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.HotLoadStatusV1> GetModelsByModelIdDeploymentsByDeploymentIdHotLoadAsync(
            string modelId,
            string deploymentId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a deployment's RL weight-sync status<br/>
        /// Lists each replica's lifecycle status and RL weight-sync state, with the revision of the deployment's newest target. A replica is done with a target when its hotload_stage is done and its revision equals the deployment's revision. loading_state is null for a replica that has not reported a state.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/hot_load \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.HotLoadStatusV1>> GetModelsByModelIdDeploymentsByDeploymentIdHotLoadAsResponseAsync(
            string modelId,
            string deploymentId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}