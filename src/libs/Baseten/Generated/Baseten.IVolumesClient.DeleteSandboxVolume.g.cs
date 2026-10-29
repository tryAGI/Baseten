#nullable enable

namespace Baseten
{
    public partial interface IVolumesClient
    {
        /// <summary>
        /// Delete a volume<br/>
        /// Permanently delete the volume and its data asynchronously. The returned resource has status DELETING. A volume mounted in a sandbox cannot be deleted (409); delete the sandbox first. Repeating the call while it is deleting returns the same resource.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="volumeName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxVolumeV1> DeleteSandboxVolumeAsync(
            string volumeName,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a volume<br/>
        /// Permanently delete the volume and its data asynchronously. The returned resource has status DELETING. A volume mounted in a sandbox cannot be deleted (409); delete the sandbox first. Repeating the call while it is deleting returns the same resource.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="volumeName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.SandboxVolumeV1>> DeleteSandboxVolumeAsResponseAsync(
            string volumeName,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}