#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets one version of a volume<br/>
        /// Returns a single version of the volume. Address it with `:&lt;tag&gt;` for a tag, `@&lt;digest&gt;` for a content digest of at least 12 hexadecimal characters, or `head` for the version a reference with no tag or digest resolves to. A digest that matches more than one version is rejected: supply more characters.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="volumeVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name}/versions/{volume_version} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.VolumeVersionV1> GetVolumesByVolumeNamespaceByVolumeNameVersionsByVolumeVersionAsync(
            string volumeNamespace,
            string volumeName,
            string volumeVersion,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets one version of a volume<br/>
        /// Returns a single version of the volume. Address it with `:&lt;tag&gt;` for a tag, `@&lt;digest&gt;` for a content digest of at least 12 hexadecimal characters, or `head` for the version a reference with no tag or digest resolves to. A digest that matches more than one version is rejected: supply more characters.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="volumeVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name}/versions/{volume_version} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.VolumeVersionV1>> GetVolumesByVolumeNamespaceByVolumeNameVersionsByVolumeVersionAsResponseAsync(
            string volumeNamespace,
            string volumeName,
            string volumeVersion,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}