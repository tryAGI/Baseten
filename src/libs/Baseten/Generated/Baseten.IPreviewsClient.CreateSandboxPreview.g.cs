#nullable enable

namespace Baseten
{
    public partial interface IPreviewsClient
    {
        /// <summary>
        /// Create a sandbox preview<br/>
        /// Expose a port of the sandbox on an HTTPS URL. A public preview is reachable by anyone with the URL. A private preview requires a preview token, created with the tokens endpoint and sent as the preview_token query parameter; the first request sets a cookie so a browser can keep navigating without it. Port 80 and the sandbox's reserved system ports are rejected, and port 443 must stay private. Without a name, the name is generated from the sandbox name and port, or is public-&lt;port&gt; or private-&lt;port&gt; when create_if_not_exists is true.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxPreviewV1> CreateSandboxPreviewAsync(
            string sandboxName,

            global::Baseten.CreateSandboxPreviewRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a sandbox preview<br/>
        /// Expose a port of the sandbox on an HTTPS URL. A public preview is reachable by anyone with the URL. A private preview requires a preview token, created with the tokens endpoint and sent as the preview_token query parameter; the first request sets a cookie so a browser can keep navigating without it. Port 80 and the sandbox's reserved system ports are rejected, and port 443 must stay private. Without a name, the name is generated from the sandbox name and port, or is public-&lt;port&gt; or private-&lt;port&gt; when create_if_not_exists is true.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.SandboxPreviewV1>> CreateSandboxPreviewAsResponseAsync(
            string sandboxName,

            global::Baseten.CreateSandboxPreviewRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a sandbox preview<br/>
        /// Expose a port of the sandbox on an HTTPS URL. A public preview is reachable by anyone with the URL. A private preview requires a preview token, created with the tokens endpoint and sent as the preview_token query parameter; the first request sets a cookie so a browser can keep navigating without it. Port 80 and the sandbox's reserved system ports are rejected, and port 443 must stay private. Without a name, the name is generated from the sandbox name and port, or is public-&lt;port&gt; or private-&lt;port&gt; when create_if_not_exists is true.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxPreviewV1> CreateSandboxPreviewAsync(
            string sandboxName,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}