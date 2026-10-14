#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a volume<br/>
        /// Updates a volume's settings, such as its expiration time. Only the settings in the request change.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "expires_at": "2030-01-01T00:00:00Z",<br/>
        ///   "expected_sequence": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.PatchVolumeResponseV1> EditVolumesByVolumeNamespaceByVolumeNameAsync(
            string volumeNamespace,
            string volumeName,

            global::Baseten.PatchVolumeRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a volume<br/>
        /// Updates a volume's settings, such as its expiration time. Only the settings in the request change.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "expires_at": "2030-01-01T00:00:00Z",<br/>
        ///   "expected_sequence": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.PatchVolumeResponseV1>> EditVolumesByVolumeNamespaceByVolumeNameAsResponseAsync(
            string volumeNamespace,
            string volumeName,

            global::Baseten.PatchVolumeRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a volume<br/>
        /// Updates a volume's settings, such as its expiration time. Only the settings in the request change.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="expiresAt">
        /// Time at which the volume expires, in ISO 8601 format, with a UTC offset. It must be in the future and at most ten years ahead. Set it to null to clear the expiration time. A body that sets no field is rejected. When the volume expires, all live versions are deleted, all tags are removed, and the volume disappears from listings. Clearing the expiration time afterward does not restore deleted versions. Each deleted version can be restored until its delete_after time. Setting or clearing the expiration time requires the same permission as deleting the volume.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="expectedSequence">
        /// Revision the volume is expected to be at. When set, the update fails with a conflict if the volume has changed since. Take the value from a volume's sequence, or from volume_sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.PatchVolumeResponseV1> EditVolumesByVolumeNamespaceByVolumeNameAsync(
            string volumeNamespace,
            string volumeName,
            global::System.DateTime? expiresAt = default,
            int? expectedSequence = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}