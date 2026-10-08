#nullable enable

namespace Baseten
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get sandbox metrics<br/>
        /// Returns every interval in the requested half-open range [start_time, end_time).<br/>
        /// Buckets align to UTC interval boundaries; partial boundary buckets include only samples<br/>
        /// within the requested range. The first bucket may start before start_time. Ranges are limited to 31 days<br/>
        /// and 10000 buckets. Request counts are zero when there is no traffic, and null<br/>
        /// for buckets entirely before sandbox creation. CPU and memory are null without<br/>
        /// samples, including standby. Error rate is the fraction of requests returning<br/>
        /// 4xx or 5xx, null when there are no requests. Telemetry failures return an error.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName">
        /// Example: baseten-api-review-0916
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="intervalSeconds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxMetricsV1> GetSandboxMetricsAsync(
            string sandboxName,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            int intervalSeconds,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get sandbox metrics<br/>
        /// Returns every interval in the requested half-open range [start_time, end_time).<br/>
        /// Buckets align to UTC interval boundaries; partial boundary buckets include only samples<br/>
        /// within the requested range. The first bucket may start before start_time. Ranges are limited to 31 days<br/>
        /// and 10000 buckets. Request counts are zero when there is no traffic, and null<br/>
        /// for buckets entirely before sandbox creation. CPU and memory are null without<br/>
        /// samples, including standby. Error rate is the fraction of requests returning<br/>
        /// 4xx or 5xx, null when there are no requests. Telemetry failures return an error.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName">
        /// Example: baseten-api-review-0916
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="intervalSeconds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.SandboxMetricsV1>> GetSandboxMetricsAsResponseAsync(
            string sandboxName,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            int intervalSeconds,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}