#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets the versions of a volume<br/>
        /// Returns every live version of the volume, newest first, each with its digest, size, lifecycle, and the tags pointing at it. Pass include_tombstoned to list deleted versions alongside them.
        /// </summary>
        /// <param name="includeTombstoned">
        /// Default Value: false
        /// </param>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name}/versions \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ListVolumeVersionsResponseV1> GetVolumesByVolumeNamespaceByVolumeNameVersionsAsync(
            string volumeNamespace,
            string volumeName,
            bool? includeTombstoned = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the versions of a volume<br/>
        /// Returns every live version of the volume, newest first, each with its digest, size, lifecycle, and the tags pointing at it. Pass include_tombstoned to list deleted versions alongside them.
        /// </summary>
        /// <param name="includeTombstoned">
        /// Default Value: false
        /// </param>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name}/versions \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ListVolumeVersionsResponseV1>> GetVolumesByVolumeNamespaceByVolumeNameVersionsAsResponseAsync(
            string volumeNamespace,
            string volumeName,
            bool? includeTombstoned = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}