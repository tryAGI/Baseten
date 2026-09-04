#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deletes a volume<br/>
        /// Deletes every live version of the volume, after which the volume stops appearing in listings. The data is not erased: each version stays restorable until its recovery deadline passes, and the versions sub-resource still reports them when you pass include_tombstoned. Deleting a volume that has no live versions left succeeds and reports zero versions deleted.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "expected_sequence": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DeleteVolumeResponseV1> DeleteVolumesByVolumeNamespaceByVolumeNameAsync(
            string volumeNamespace,
            string volumeName,

            global::Baseten.DeleteVolumeRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a volume<br/>
        /// Deletes every live version of the volume, after which the volume stops appearing in listings. The data is not erased: each version stays restorable until its recovery deadline passes, and the versions sub-resource still reports them when you pass include_tombstoned. Deleting a volume that has no live versions left succeeds and reports zero versions deleted.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "expected_sequence": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.DeleteVolumeResponseV1>> DeleteVolumesByVolumeNamespaceByVolumeNameAsResponseAsync(
            string volumeNamespace,
            string volumeName,

            global::Baseten.DeleteVolumeRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a volume<br/>
        /// Deletes every live version of the volume, after which the volume stops appearing in listings. The data is not erased: each version stays restorable until its recovery deadline passes, and the versions sub-resource still reports them when you pass include_tombstoned. Deleting a volume that has no live versions left succeeds and reports zero versions deleted.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="expectedSequence">
        /// Revision the volume is expected to be at. When set, the delete fails with a conflict if the volume has changed since, so it cannot act on a volume someone else has pushed to. Take the value from a volume's sequence, or from volume_sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.DeleteVolumeResponseV1> DeleteVolumesByVolumeNamespaceByVolumeNameAsync(
            string volumeNamespace,
            string volumeName,
            int? expectedSequence = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}