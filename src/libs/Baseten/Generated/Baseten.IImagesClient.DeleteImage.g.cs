#nullable enable

namespace Baseten
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Delete a sandbox image<br/>
        /// Delete the image repository and all its tags. Reject deletion if any version is referenced by an active deployment. Return the deleted image.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="imageName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.ImageV1> DeleteImageAsync(
            string imageName,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a sandbox image<br/>
        /// Delete the image repository and all its tags. Reject deletion if any version is referenced by an active deployment. Return the deleted image.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="imageName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ImageV1>> DeleteImageAsResponseAsync(
            string imageName,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}