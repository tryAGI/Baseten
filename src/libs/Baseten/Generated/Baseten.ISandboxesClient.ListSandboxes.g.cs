#nullable enable

namespace Baseten
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List sandboxes<br/>
        /// Return a cursor-paginated page of sandboxes. Terminated sandboxes are hidden by default.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="cursor">
        /// Example: eyJ2IjoxLCJsYXN0X2tleSI6ImJhc2V0ZW4tYXBpLXJldmlldy0wOTE2Iiwic29ydCI6ImRlc2MifQ
        /// </param>
        /// <param name="limit">
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="q">
        /// Example: api-review
        /// </param>
        /// <param name="status">
        /// Example: [DEPLOYED, FAILED]
        /// </param>
        /// <param name="externalId">
        /// Example: api-review-20260916-001
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.ListSandboxesResponseV1> ListSandboxesAsync(
            string? teamId = default,
            string? xTeamId = default,
            string? cursor = default,
            int? limit = default,
            string? q = default,
            global::System.Collections.Generic.IList<string>? status = default,
            string? externalId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List sandboxes<br/>
        /// Return a cursor-paginated page of sandboxes. Terminated sandboxes are hidden by default.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="cursor">
        /// Example: eyJ2IjoxLCJsYXN0X2tleSI6ImJhc2V0ZW4tYXBpLXJldmlldy0wOTE2Iiwic29ydCI6ImRlc2MifQ
        /// </param>
        /// <param name="limit">
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="q">
        /// Example: api-review
        /// </param>
        /// <param name="status">
        /// Example: [DEPLOYED, FAILED]
        /// </param>
        /// <param name="externalId">
        /// Example: api-review-20260916-001
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ListSandboxesResponseV1>> ListSandboxesAsResponseAsync(
            string? teamId = default,
            string? xTeamId = default,
            string? cursor = default,
            int? limit = default,
            string? q = default,
            global::System.Collections.Generic.IList<string>? status = default,
            string? externalId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}