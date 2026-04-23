#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets a presigned download URL for a deployment's truss<br/>
        /// Gets a presigned URL to download the truss tar file for a deployment.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/download \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DownloadDeploymentResponseV1> GetModelsByModelIdDeploymentsByDeploymentIdDownloadAsync(
            string modelId,
            string deploymentId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}