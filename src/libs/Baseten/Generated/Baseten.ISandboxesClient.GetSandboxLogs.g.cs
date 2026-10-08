#nullable enable

namespace Baseten
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get sandbox logs<br/>
        /// Returns sandbox runtime logs, newest first, within the half-open range<br/>
        /// [start_time, end_time). Ranges are limited to 7 days. Follow next_cursor<br/>
        /// until it is null to retrieve all pages, keeping the same range and limit.<br/>
        /// Logs before sandbox creation are excluded. Unavailable telemetry returns an error.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName">
        /// Example: baseten-api-review-0916
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxLogsV1> GetSandboxLogsAsync(
            string sandboxName,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            string? teamId = default,
            string? xTeamId = default,
            int? limit = default,
            string? cursor = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get sandbox logs<br/>
        /// Returns sandbox runtime logs, newest first, within the half-open range<br/>
        /// [start_time, end_time). Ranges are limited to 7 days. Follow next_cursor<br/>
        /// until it is null to retrieve all pages, keeping the same range and limit.<br/>
        /// Logs before sandbox creation are excluded. Unavailable telemetry returns an error.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName">
        /// Example: baseten-api-review-0916
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.SandboxLogsV1>> GetSandboxLogsAsResponseAsync(
            string sandboxName,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            string? teamId = default,
            string? xTeamId = default,
            int? limit = default,
            string? cursor = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}