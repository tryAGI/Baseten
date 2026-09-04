#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deletes one version of a volume<br/>
        /// Deletes the version the address names, along with every tag pointing at it. Addressing the version by tag deletes the version the tag points at, not the tag. The data is not erased: the version stays restorable until the recovery deadline in the response passes. Deleting a version that is already deleted is a conflict, not a repeat success.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="volumeVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name}/versions/{volume_version} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "expected_sequence": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DeleteVolumeVersionResponseV1> DeleteVolumesByVolumeNamespaceByVolumeNameVersionsByVolumeVersionAsync(
            string volumeNamespace,
            string volumeName,
            string volumeVersion,

            global::Baseten.DeleteVolumeVersionRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes one version of a volume<br/>
        /// Deletes the version the address names, along with every tag pointing at it. Addressing the version by tag deletes the version the tag points at, not the tag. The data is not erased: the version stays restorable until the recovery deadline in the response passes. Deleting a version that is already deleted is a conflict, not a repeat success.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="volumeVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name}/versions/{volume_version} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "expected_sequence": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.DeleteVolumeVersionResponseV1>> DeleteVolumesByVolumeNamespaceByVolumeNameVersionsByVolumeVersionAsResponseAsync(
            string volumeNamespace,
            string volumeName,
            string volumeVersion,

            global::Baseten.DeleteVolumeVersionRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes one version of a volume<br/>
        /// Deletes the version the address names, along with every tag pointing at it. Addressing the version by tag deletes the version the tag points at, not the tag. The data is not erased: the version stays restorable until the recovery deadline in the response passes. Deleting a version that is already deleted is a conflict, not a repeat success.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="volumeVersion"></param>
        /// <param name="expectedSequence">
        /// Revision the volume is expected to be at. When set, the delete fails with a conflict if the volume has changed since, so a read followed by a delete cannot act on a version a tag has since been moved off. Take the value from volume_sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.DeleteVolumeVersionResponseV1> DeleteVolumesByVolumeNamespaceByVolumeNameVersionsByVolumeVersionAsync(
            string volumeNamespace,
            string volumeName,
            string volumeVersion,
            int? expectedSequence = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}