#nullable enable

namespace Baseten
{
    public partial interface IPreviewsClient
    {
        /// <summary>
        /// Get a sandbox preview<br/>
        /// Return the preview configuration, URL and status.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="showSecrets">
        /// Default Value: false
        /// </param>
        /// <param name="sandboxName"></param>
        /// <param name="previewName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxPreviewV1> GetSandboxPreviewAsync(
            string sandboxName,
            string previewName,
            string? teamId = default,
            string? xTeamId = default,
            bool? showSecrets = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a sandbox preview<br/>
        /// Return the preview configuration, URL and status.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="showSecrets">
        /// Default Value: false
        /// </param>
        /// <param name="sandboxName"></param>
        /// <param name="previewName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.SandboxPreviewV1>> GetSandboxPreviewAsResponseAsync(
            string sandboxName,
            string previewName,
            string? teamId = default,
            string? xTeamId = default,
            bool? showSecrets = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}