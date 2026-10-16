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
        /// <param name="public">
        /// Whether the URL is reachable without a preview token. Defaults to false.<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="responseHeaders">
        /// Headers added to every response served by the preview, for example CORS headers.
        /// </param>
        /// <param name="requestHeaders">
        /// Headers added to every request forwarded to the sandbox, for example an Authorization header expected by the application. Responses return each name with the value "****", except a GET with show_secrets=true by a workspace administrator. Sending "****" back as a value returns 400. A PATCH replaces the whole set.<br/>
        /// Example: {"Authorization":"Bearer app-internal-token"}
        /// </param>
        /// <param name="ttl">
        /// Lifetime counted from the request, using seconds, minutes, hours or composite durations such as 1h30m. Whole days are also supported, for example 7d; days cannot be combined with other units. The preview is deleted when it elapses.<br/>
        /// Example: 24h
        /// </param>
        /// <param name="expiresAt">
        /// Time at which the preview is deleted. Must be in the future.<br/>
        /// Example: 2026-10-19T12:00:00Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxPreviewV1> UpdateSandboxPreviewAsync(
            string sandboxName,
            string previewName,
            string? teamId = default,
            string? xTeamId = default,
            bool? @public = default,
            global::System.Collections.Generic.Dictionary<string, string>? responseHeaders = default,
            global::System.Collections.Generic.Dictionary<string, string>? requestHeaders = default,
            string? ttl = default,
            global::System.DateTime? expiresAt = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}