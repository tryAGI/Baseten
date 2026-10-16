#nullable enable

namespace Baseten
{
    public partial interface IPreviewsClient
    {
        /// <summary>
        /// Delete a sandbox preview<br/>
        /// Delete the preview and revoke its tokens. The URL stops serving immediately. Return the deleted preview, with status TERMINATED, or DELETING while a preview with many tokens finishes in the background.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName"></param>
        /// <param name="previewName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxPreviewV1> DeleteSandboxPreviewAsync(
            string sandboxName,
            string previewName,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a sandbox preview<br/>
        /// Delete the preview and revoke its tokens. The URL stops serving immediately. Return the deleted preview, with status TERMINATED, or DELETING while a preview with many tokens finishes in the background.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName"></param>
        /// <param name="previewName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.SandboxPreviewV1>> DeleteSandboxPreviewAsResponseAsync(
            string sandboxName,
            string previewName,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}