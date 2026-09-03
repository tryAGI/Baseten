#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets the volumes in a namespace<br/>
        /// Returns one row per volume in the namespace, each with its tags, head version, and version counts. Pass namespace to choose the namespace, which is required because the volume service has no cross-namespace inventory. Versions live on the versions sub-resource, so this response stays a fixed size per volume no matter how long a volume's history is.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="namespace"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/volumes \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ListVolumesResponseV1> GetVolumesAsync(
            string @namespace,
            string? cursor = default,
            int? limit = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the volumes in a namespace<br/>
        /// Returns one row per volume in the namespace, each with its tags, head version, and version counts. Pass namespace to choose the namespace, which is required because the volume service has no cross-namespace inventory. Versions live on the versions sub-resource, so this response stays a fixed size per volume no matter how long a volume's history is.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="namespace"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/volumes \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ListVolumesResponseV1>> GetVolumesAsResponseAsync(
            string @namespace,
            string? cursor = default,
            int? limit = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}