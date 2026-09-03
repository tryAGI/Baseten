#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets a volume<br/>
        /// Returns a volume with its tags, head version, and version counts. Versions live on the versions sub-resource so they can be paged separately.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.VolumeV1> GetVolumesByVolumeNamespaceByVolumeNameAsync(
            string volumeNamespace,
            string volumeName,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a volume<br/>
        /// Returns a volume with its tags, head version, and version counts. Versions live on the versions sub-resource so they can be paged separately.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.VolumeV1>> GetVolumesByVolumeNamespaceByVolumeNameAsResponseAsync(
            string volumeNamespace,
            string volumeName,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}