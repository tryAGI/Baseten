#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Sync staged patches to a development deployment.<br/>
        /// Applies any staged patches to the running deployment. A 2xx response means the sync reached a verdict: in sync, or a full push is required (needs_full_deploy_reason). A 503 means the sync was not attempted or failed recoverably and should be retried; any other error is terminal.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/patches/sync \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.SyncDeploymentPatchesResponseV1> CreateModelsByModelIdDeploymentsByDeploymentIdPatchesSyncAsync(
            string modelId,
            string deploymentId,

            global::Baseten.SyncDeploymentPatchesRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sync staged patches to a development deployment.<br/>
        /// Applies any staged patches to the running deployment. A 2xx response means the sync reached a verdict: in sync, or a full push is required (needs_full_deploy_reason). A 503 means the sync was not attempted or failed recoverably and should be retried; any other error is terminal.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/patches/sync \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.SyncDeploymentPatchesResponseV1>> CreateModelsByModelIdDeploymentsByDeploymentIdPatchesSyncAsResponseAsync(
            string modelId,
            string deploymentId,

            global::Baseten.SyncDeploymentPatchesRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sync staged patches to a development deployment.<br/>
        /// Applies any staged patches to the running deployment. A 2xx response means the sync reached a verdict: in sync, or a full push is required (needs_full_deploy_reason). A 503 means the sync was not attempted or failed recoverably and should be retried; any other error is terminal.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SyncDeploymentPatchesResponseV1> CreateModelsByModelIdDeploymentsByDeploymentIdPatchesSyncAsync(
            string modelId,
            string deploymentId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}