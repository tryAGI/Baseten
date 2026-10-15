#nullable enable

namespace Baseten
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get sandbox metrics<br/>
        /// Returns every interval with labeled request counts, CPU cores, and RSS memory bytes. CURRENT returns one snapshot at now, with<br/>
        /// request counts over the preceding minute and latest gauges.<br/>
        /// SUMMARY returns one value set over the window. SERIES snaps the window outward<br/>
        /// to UTC step boundaries and echoes those boundaries; each value covers<br/>
        /// [start_epoch_millis, start_epoch_millis + step_seconds).<br/>
        /// Missing gauge samples remain null. Request counts are zero after<br/>
        /// creation without traffic, and null before creation. CPU averages are averages<br/>
        /// of valid sampled CPU rates; memory averages are averages of sampled RSS.<br/>
        /// Windows default to one hour, are limited to 7 days after alignment, and at most<br/>
        /// 10000 intervals. Telemetry failures return an error.
        /// </summary>
        /// <param name="sandboxName">
        /// Example: baseten-api-review-0916
        /// </param>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="mode"></param>
        /// <param name="startEpochMillis"></param>
        /// <param name="endEpochMillis"></param>
        /// <param name="metrics"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxMetricsV1> GetSandboxMetricsAsync(
            string sandboxName,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.SandboxMetricModeV1? mode = default,
            long? startEpochMillis = default,
            long? endEpochMillis = default,
            global::System.Collections.Generic.IList<global::Baseten.SandboxMetricNameV1>? metrics = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get sandbox metrics<br/>
        /// Returns every interval with labeled request counts, CPU cores, and RSS memory bytes. CURRENT returns one snapshot at now, with<br/>
        /// request counts over the preceding minute and latest gauges.<br/>
        /// SUMMARY returns one value set over the window. SERIES snaps the window outward<br/>
        /// to UTC step boundaries and echoes those boundaries; each value covers<br/>
        /// [start_epoch_millis, start_epoch_millis + step_seconds).<br/>
        /// Missing gauge samples remain null. Request counts are zero after<br/>
        /// creation without traffic, and null before creation. CPU averages are averages<br/>
        /// of valid sampled CPU rates; memory averages are averages of sampled RSS.<br/>
        /// Windows default to one hour, are limited to 7 days after alignment, and at most<br/>
        /// 10000 intervals. Telemetry failures return an error.
        /// </summary>
        /// <param name="sandboxName">
        /// Example: baseten-api-review-0916
        /// </param>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="mode"></param>
        /// <param name="startEpochMillis"></param>
        /// <param name="endEpochMillis"></param>
        /// <param name="metrics"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.SandboxMetricsV1>> GetSandboxMetricsAsResponseAsync(
            string sandboxName,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.SandboxMetricModeV1? mode = default,
            long? startEpochMillis = default,
            long? endEpochMillis = default,
            global::System.Collections.Generic.IList<global::Baseten.SandboxMetricNameV1>? metrics = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}