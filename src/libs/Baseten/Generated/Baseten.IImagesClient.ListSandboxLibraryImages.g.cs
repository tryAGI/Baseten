#nullable enable

namespace Baseten
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// List built-in sandbox images<br/>
        /// Return the built-in sandbox images, the same for every team, so no team is selected. Use the image field directly as the image of a sandbox, without building or pushing it. Hidden and upcoming images are excluded.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.ListSandboxLibraryImagesResponseV1> ListSandboxLibraryImagesAsync(
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List built-in sandbox images<br/>
        /// Return the built-in sandbox images, the same for every team, so no team is selected. Use the image field directly as the image of a sandbox, without building or pushing it. Hidden and upcoming images are excluded.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ListSandboxLibraryImagesResponseV1>> ListSandboxLibraryImagesAsResponseAsync(
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}