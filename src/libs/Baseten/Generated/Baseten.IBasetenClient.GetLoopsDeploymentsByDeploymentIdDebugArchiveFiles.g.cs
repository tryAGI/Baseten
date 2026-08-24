#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets Loops debug archive files<br/>
        /// Gets presigned download URLs for a Loops deployment's debug archive.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 1000
        /// </param>
        /// <param name="pageToken">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/loops/deployments/{deployment_id}/debug_archive/files \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.LoopsDebugArchiveFilesResponseV1> GetLoopsDeploymentsByDeploymentIdDebugArchiveFilesAsync(
            string deploymentId,
            int? pageSize = default,
            string? pageToken = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets Loops debug archive files<br/>
        /// Gets presigned download URLs for a Loops deployment's debug archive.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 1000
        /// </param>
        /// <param name="pageToken">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="deploymentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/loops/deployments/{deployment_id}/debug_archive/files \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.LoopsDebugArchiveFilesResponseV1>> GetLoopsDeploymentsByDeploymentIdDebugArchiveFilesAsResponseAsync(
            string deploymentId,
            int? pageSize = default,
            string? pageToken = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}