#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Restores a deleted version of a volume<br/>
        /// Returns a deleted version to service, provided its recovery deadline has not passed. The tags the version carried when it was deleted are not restored with it, so re-tag it if anything depended on those. Address the version by digest: a deleted version has no tags left to name it by.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="volumeVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name}/versions/{volume_version}/restore \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "expected_sequence": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RestoreVolumeVersionResponseV1> CreateVolumesByVolumeNamespaceByVolumeNameVersionsByVolumeVersionRestoreAsync(
            string volumeNamespace,
            string volumeName,
            string volumeVersion,

            global::Baseten.RestoreVolumeVersionRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restores a deleted version of a volume<br/>
        /// Returns a deleted version to service, provided its recovery deadline has not passed. The tags the version carried when it was deleted are not restored with it, so re-tag it if anything depended on those. Address the version by digest: a deleted version has no tags left to name it by.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="volumeVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name}/versions/{volume_version}/restore \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "expected_sequence": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RestoreVolumeVersionResponseV1>> CreateVolumesByVolumeNamespaceByVolumeNameVersionsByVolumeVersionRestoreAsResponseAsync(
            string volumeNamespace,
            string volumeName,
            string volumeVersion,

            global::Baseten.RestoreVolumeVersionRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Restores a deleted version of a volume<br/>
        /// Returns a deleted version to service, provided its recovery deadline has not passed. The tags the version carried when it was deleted are not restored with it, so re-tag it if anything depended on those. Address the version by digest: a deleted version has no tags left to name it by.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="volumeVersion"></param>
        /// <param name="expectedSequence">
        /// Revision the volume is expected to be at. When set, the restore fails with a conflict if the volume has changed since. Take the value from volume_sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.RestoreVolumeVersionResponseV1> CreateVolumesByVolumeNamespaceByVolumeNameVersionsByVolumeVersionRestoreAsync(
            string volumeNamespace,
            string volumeName,
            string volumeVersion,
            int? expectedSequence = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}