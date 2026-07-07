#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Stages a patch against a development deployment<br/>
        /// Persists a patch durably without applying it; call the sync endpoint to apply staged patches to the running deployment. The target must be a development deployment (its archive created with `is_development` set to `true`); patching any other deployment is rejected.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/patches \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "prev_patch_hash": null,<br/>
        ///   "next_patch_point": {<br/>
        ///     "content_hashes": null,<br/>
        ///     "config": null<br/>
        ///   },<br/>
        ///   "patch_ops": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.CreateDeploymentPatchResponseV1> CreateModelsByModelIdDeploymentsByDeploymentIdPatchesAsync(
            string modelId,
            string deploymentId,

            global::Baseten.CreateDeploymentPatchRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stages a patch against a development deployment<br/>
        /// Persists a patch durably without applying it; call the sync endpoint to apply staged patches to the running deployment. The target must be a development deployment (its archive created with `is_development` set to `true`); patching any other deployment is rejected.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/patches \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "prev_patch_hash": null,<br/>
        ///   "next_patch_point": {<br/>
        ///     "content_hashes": null,<br/>
        ///     "config": null<br/>
        ///   },<br/>
        ///   "patch_ops": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.CreateDeploymentPatchResponseV1>> CreateModelsByModelIdDeploymentsByDeploymentIdPatchesAsResponseAsync(
            string modelId,
            string deploymentId,

            global::Baseten.CreateDeploymentPatchRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Stages a patch against a development deployment<br/>
        /// Persists a patch durably without applying it; call the sync endpoint to apply staged patches to the running deployment. The target must be a development deployment (its archive created with `is_development` set to `true`); patching any other deployment is rejected.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="prevPatchHash">
        /// Content hash of the patch point this patch is applied on - the link the staged patch must build on. A stale value (the base moved underneath the client) is rejected with a conflict.
        /// </param>
        /// <param name="nextPatchPoint">
        /// The source state after this patch. The server derives its content hash from `content_hashes`.
        /// </param>
        /// <param name="patchOps">
        /// The ordered ops that make up this patch. At least one op is required; a patch that changes nothing is not a valid request. There is no op for a directory: a directory comes into existence when the first file under it is added, and is removed when its last file is removed, so directory creation and deletion happen implicitly through the file ops. Adding or removing an otherwise empty directory therefore produces no ops even though it changes the source hash; do not send a patch request for such a change.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.CreateDeploymentPatchResponseV1> CreateModelsByModelIdDeploymentsByDeploymentIdPatchesAsync(
            string modelId,
            string deploymentId,
            string prevPatchHash,
            global::Baseten.DeploymentPatchPointV1 nextPatchPoint,
            global::System.Collections.Generic.IList<global::Baseten.PatchOpsItem> patchOps,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}