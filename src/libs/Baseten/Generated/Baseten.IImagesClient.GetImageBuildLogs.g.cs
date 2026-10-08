#nullable enable

namespace Baseten
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Get image build logs<br/>
        /// Return one page of logs from the latest recorded build of this image, including failed builds, newest first. Logs may take a short time to appear. Defaults to the last 24 hours; the requested time range must not exceed 7 days. Keep start_time and end_time fixed when paging with offset. A new build changes the log source; this endpoint does not retrieve a historical build by ID. While a new upload is waiting to start, logs may still refer to the preceding build. Older builds without a recorded environment use image-level build logs within the requested time range.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="imageName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxImageBuildLogsResponseV1> GetImageBuildLogsAsync(
            string imageName,
            string? teamId = default,
            string? xTeamId = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            int? limit = default,
            int? offset = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get image build logs<br/>
        /// Return one page of logs from the latest recorded build of this image, including failed builds, newest first. Logs may take a short time to appear. Defaults to the last 24 hours; the requested time range must not exceed 7 days. Keep start_time and end_time fixed when paging with offset. A new build changes the log source; this endpoint does not retrieve a historical build by ID. While a new upload is waiting to start, logs may still refer to the preceding build. Older builds without a recorded environment use image-level build logs within the requested time range.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="imageName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.SandboxImageBuildLogsResponseV1>> GetImageBuildLogsAsResponseAsync(
            string imageName,
            string? teamId = default,
            string? xTeamId = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            int? limit = default,
            int? offset = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}