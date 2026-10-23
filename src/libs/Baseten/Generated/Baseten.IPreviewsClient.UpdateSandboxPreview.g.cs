#nullable enable

namespace Baseten
{
    public partial interface IPreviewsClient
    {
        /// <summary>
        /// Update a sandbox preview<br/>
        /// Partially update the preview. Omitted fields remain unchanged; supplied header maps replace their previous values. The URL does not change. Setting ttl or expires_at replaces any previous expiration and restarts it from now. The name and port are immutable; supplying either returns 400.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName"></param>
        /// <param name="previewName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxPreviewV1> UpdateSandboxPreviewAsync(
            string sandboxName,
            string previewName,

            global::Baseten.UpdateSandboxPreviewRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a sandbox preview<br/>
        /// Partially update the preview. Omitted fields remain unchanged; supplied header maps replace their previous values. The URL does not change. Setting ttl or expires_at replaces any previous expiration and restarts it from now. The name and port are immutable; supplying either returns 400.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName"></param>
        /// <param name="previewName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.SandboxPreviewV1>> UpdateSandboxPreviewAsResponseAsync(
            string sandboxName,
            string previewName,

            global::Baseten.UpdateSandboxPreviewRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a sandbox preview<br/>
        /// Partially update the preview. Omitted fields remain unchanged; supplied header maps replace their previous values. The URL does not change. Setting ttl or expires_at replaces any previous expiration and restarts it from now. The name and port are immutable; supplying either returns 400.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName"></param>
        /// <param name="previewName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxPreviewV1> UpdateSandboxPreviewAsync(
            string sandboxName,
            string previewName,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}