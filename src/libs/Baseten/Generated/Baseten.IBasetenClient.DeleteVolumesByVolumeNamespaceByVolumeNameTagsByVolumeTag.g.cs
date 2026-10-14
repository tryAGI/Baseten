#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deletes a volume tag<br/>
        /// The version remains available by digest and any other tags. If the tag is absent, the request succeeds with `deleted` set to `false`. Deleting `head` makes references without a tag or digest stop resolving until `head` is set again.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="volumeTag"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name}/tags/{volume_tag} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "expected_sequence": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DeleteVolumeTagResponseV1> DeleteVolumesByVolumeNamespaceByVolumeNameTagsByVolumeTagAsync(
            string volumeNamespace,
            string volumeName,
            string volumeTag,

            global::Baseten.DeleteVolumeTagRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a volume tag<br/>
        /// The version remains available by digest and any other tags. If the tag is absent, the request succeeds with `deleted` set to `false`. Deleting `head` makes references without a tag or digest stop resolving until `head` is set again.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="volumeTag"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name}/tags/{volume_tag} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "expected_sequence": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.DeleteVolumeTagResponseV1>> DeleteVolumesByVolumeNamespaceByVolumeNameTagsByVolumeTagAsResponseAsync(
            string volumeNamespace,
            string volumeName,
            string volumeTag,

            global::Baseten.DeleteVolumeTagRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a volume tag<br/>
        /// The version remains available by digest and any other tags. If the tag is absent, the request succeeds with `deleted` set to `false`. Deleting `head` makes references without a tag or digest stop resolving until `head` is set again.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="volumeTag"></param>
        /// <param name="expectedSequence">
        /// Revision the volume is expected to be at. When set, the delete fails with a conflict if the volume has changed since, so it cannot delete a tag someone else has just set on another version. Take the value from volume_sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.DeleteVolumeTagResponseV1> DeleteVolumesByVolumeNamespaceByVolumeNameTagsByVolumeTagAsync(
            string volumeNamespace,
            string volumeName,
            string volumeTag,
            int? expectedSequence = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}