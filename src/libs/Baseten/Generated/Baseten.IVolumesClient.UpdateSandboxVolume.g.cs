#nullable enable

namespace Baseten
{
    public partial interface IVolumesClient
    {
        /// <summary>
        /// Update a volume<br/>
        /// Grow the volume or replace its labels. size can only increase. The name and region are immutable; supplying either returns 400.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="volumeName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxVolumeV1> UpdateSandboxVolumeAsync(
            string volumeName,

            global::Baseten.UpdateSandboxVolumeRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a volume<br/>
        /// Grow the volume or replace its labels. size can only increase. The name and region are immutable; supplying either returns 400.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="volumeName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.SandboxVolumeV1>> UpdateSandboxVolumeAsResponseAsync(
            string volumeName,

            global::Baseten.UpdateSandboxVolumeRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a volume<br/>
        /// Grow the volume or replace its labels. size can only increase. The name and region are immutable; supplying either returns 400.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="volumeName"></param>
        /// <param name="size">
        /// New capacity, as a size (e.g. "20Gi") or a number of Mi, greater than or equal to the current size.<br/>
        /// Example: 20Gi
        /// </param>
        /// <param name="labels">
        /// Labels replacing all current labels, not merged with them. Omit to keep them.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxVolumeV1> UpdateSandboxVolumeAsync(
            string volumeName,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.OneOf<string, int?>? size = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}