#nullable enable

namespace Baseten
{
    public partial interface IPreviewsClient
    {
        /// <summary>
        /// Create a preview token<br/>
        /// Create a token granting access to a private preview until expires_at. Append it to the preview URL as ?preview_token=&lt;token&gt;.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName"></param>
        /// <param name="previewName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxPreviewTokenV1> CreateSandboxPreviewTokenAsync(
            string sandboxName,
            string previewName,

            global::Baseten.CreateSandboxPreviewTokenRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a preview token<br/>
        /// Create a token granting access to a private preview until expires_at. Append it to the preview URL as ?preview_token=&lt;token&gt;.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName"></param>
        /// <param name="previewName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.SandboxPreviewTokenV1>> CreateSandboxPreviewTokenAsResponseAsync(
            string sandboxName,
            string previewName,

            global::Baseten.CreateSandboxPreviewTokenRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a preview token<br/>
        /// Create a token granting access to a private preview until expires_at. Append it to the preview URL as ?preview_token=&lt;token&gt;.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName"></param>
        /// <param name="previewName"></param>
        /// <param name="createIfNotExists">
        /// When true, may return an existing unexpired token of this preview that stays valid at least until expires_at instead of creating a new one. A token created a moment earlier may not be found yet, in which case a new token is created. Defaults to false when omitted.
        /// </param>
        /// <param name="expiresAt">
        /// Time at which the token stops working. Must be in the future.<br/>
        /// Example: 2026-10-13T12:00:00Z
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxPreviewTokenV1> CreateSandboxPreviewTokenAsync(
            string sandboxName,
            string previewName,
            global::System.DateTime expiresAt,
            string? teamId = default,
            string? xTeamId = default,
            bool? createIfNotExists = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}