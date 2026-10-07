#nullable enable

namespace Baseten
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Delete an image tag<br/>
        /// Delete a specific image version. Reject deletion if the version is referenced by an active deployment. Return the updated image with its remaining tags, possibly empty.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="imageName"></param>
        /// <param name="tagName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.ImageV1> DeleteImageTagAsync(
            string imageName,
            string tagName,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an image tag<br/>
        /// Delete a specific image version. Reject deletion if the version is referenced by an active deployment. Return the updated image with its remaining tags, possibly empty.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="imageName"></param>
        /// <param name="tagName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ImageV1>> DeleteImageTagAsResponseAsync(
            string imageName,
            string tagName,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}