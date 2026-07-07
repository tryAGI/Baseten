#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets a Loops deployment<br/>
        /// Fetches a Loops deployment by ID, including its latest status.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/loops/deployments/{deployment_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetLoopsDeploymentResponseV1> GetLoopsDeploymentsByDeploymentIdAsync(
            string deploymentId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a Loops deployment<br/>
        /// Fetches a Loops deployment by ID, including its latest status.
        /// </summary>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/loops/deployments/{deployment_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.GetLoopsDeploymentResponseV1>> GetLoopsDeploymentsByDeploymentIdAsResponseAsync(
            string deploymentId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}