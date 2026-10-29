#nullable enable

namespace Baseten
{
    public partial interface IVolumesClient
    {
        /// <summary>
        /// List volumes<br/>
        /// Return a cursor-paginated page of persistent volumes, newest first. Keep q and status unchanged when following a cursor.
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
        /// Example: datasets
        /// </param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.ListSandboxVolumesResponseV1> ListSandboxVolumesAsync(
            string? teamId = default,
            string? xTeamId = default,
            string? cursor = default,
            int? limit = default,
            string? q = default,
            global::System.Collections.Generic.IList<global::Baseten.SandboxVolumeStatusV1>? status = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List volumes<br/>
        /// Return a cursor-paginated page of persistent volumes, newest first. Keep q and status unchanged when following a cursor.
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
        /// Example: datasets
        /// </param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ListSandboxVolumesResponseV1>> ListSandboxVolumesAsResponseAsync(
            string? teamId = default,
            string? xTeamId = default,
            string? cursor = default,
            int? limit = default,
            string? q = default,
            global::System.Collections.Generic.IList<global::Baseten.SandboxVolumeStatusV1>? status = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}