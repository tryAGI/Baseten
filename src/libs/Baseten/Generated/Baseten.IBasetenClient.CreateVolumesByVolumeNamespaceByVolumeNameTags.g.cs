#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Sets a volume tag<br/>
        /// Setting an existing tag overwrites it. The previous version remains available by digest. Pass `expires_at` to set the tag's expiration time. Omit `expires_at` to clear any expiration time on the tag. Version or volume expiration still deletes the tag. Setting `head` changes the version used by references without a tag or digest. You cannot set `head` on an expiring version or supply `expires_at` when setting `head`.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name}/tags \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "tag": "nightly",<br/>
        ///   "version": "head",<br/>
        ///   "expires_at": null,<br/>
        ///   "expected_sequence": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.SetVolumeTagResponseV1> CreateVolumesByVolumeNamespaceByVolumeNameTagsAsync(
            string volumeNamespace,
            string volumeName,

            global::Baseten.SetVolumeTagRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sets a volume tag<br/>
        /// Setting an existing tag overwrites it. The previous version remains available by digest. Pass `expires_at` to set the tag's expiration time. Omit `expires_at` to clear any expiration time on the tag. Version or volume expiration still deletes the tag. Setting `head` changes the version used by references without a tag or digest. You cannot set `head` on an expiring version or supply `expires_at` when setting `head`.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/volumes/{volume_namespace}/{volume_name}/tags \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "tag": "nightly",<br/>
        ///   "version": "head",<br/>
        ///   "expires_at": null,<br/>
        ///   "expected_sequence": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.SetVolumeTagResponseV1>> CreateVolumesByVolumeNamespaceByVolumeNameTagsAsResponseAsync(
            string volumeNamespace,
            string volumeName,

            global::Baseten.SetVolumeTagRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sets a volume tag<br/>
        /// Setting an existing tag overwrites it. The previous version remains available by digest. Pass `expires_at` to set the tag's expiration time. Omit `expires_at` to clear any expiration time on the tag. Version or volume expiration still deletes the tag. Setting `head` changes the version used by references without a tag or digest. You cannot set `head` on an expiring version or supply `expires_at` when setting `head`.
        /// </summary>
        /// <param name="volumeNamespace"></param>
        /// <param name="volumeName"></param>
        /// <param name="tag">
        /// Name of the tag to set. Tags are case-sensitive. Setting a tag that already exists overwrites it, and the version it pointed at before stays reachable by digest.
        /// </param>
        /// <param name="version">
        /// Version to set the tag on. Address it with `:&lt;tag&gt;` for a tag, `@&lt;digest&gt;` for a full content digest or a prefix of at least 12 hexadecimal characters, or `head` for the version a reference with no tag or digest resolves to.
        /// </param>
        /// <param name="expiresAt">
        /// Time at which the tag expires, in ISO 8601 format, with a UTC offset. It must be in the future and at most ten years ahead. Omit it for a tag with no expiration time of its own. Omitting it also clears the expiration time of an existing tag. Version or volume expiration still deletes the tag. Do not specify it when setting `head`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="expectedSequence">
        /// Revision the volume is expected to be at. When set, the request fails with a conflict if the volume has changed since. Take the value from volume_sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SetVolumeTagResponseV1> CreateVolumesByVolumeNamespaceByVolumeNameTagsAsync(
            string volumeNamespace,
            string volumeName,
            string tag,
            string version,
            global::System.DateTime? expiresAt = default,
            int? expectedSequence = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}