#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deactivates a Loops deployment<br/>
        /// Shuts down a Loops deployment by ID. Saved checkpoints remain accessible. Resolving the base model to a deployment ID is the caller's responsibility: list deployments and pick the active one.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/deployments/{deployment_id}/deactivate \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DeactivateLoopsDeploymentResponseV1> CreateLoopsDeploymentsByDeploymentIdDeactivateAsync(
            string deploymentId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deactivates a Loops deployment<br/>
        /// Shuts down a Loops deployment by ID. Saved checkpoints remain accessible. Resolving the base model to a deployment ID is the caller's responsibility: list deployments and pick the active one.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/deployments/{deployment_id}/deactivate \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.DeactivateLoopsDeploymentResponseV1>> CreateLoopsDeploymentsByDeploymentIdDeactivateAsResponseAsync(
            string deploymentId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}