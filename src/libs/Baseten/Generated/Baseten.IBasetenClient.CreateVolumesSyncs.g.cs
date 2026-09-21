#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Starts a volume sync<br/>
        /// Starts one durable asynchronous transfer from a remote source into a BDN volume.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/volumes/syncs \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "source": null,<br/>
        ///   "destination": {<br/>
        ///     "ref": null<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.VolumeSyncV1> CreateVolumesSyncsAsync(

            global::Baseten.CreateVolumeSyncRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Starts a volume sync<br/>
        /// Starts one durable asynchronous transfer from a remote source into a BDN volume.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/volumes/syncs \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "source": null,<br/>
        ///   "destination": {<br/>
        ///     "ref": null<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.VolumeSyncV1>> CreateVolumesSyncsAsResponseAsync(

            global::Baseten.CreateVolumeSyncRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Starts a volume sync<br/>
        /// Starts one durable asynchronous transfer from a remote source into a BDN volume.
        /// </summary>
        /// <param name="source">
        /// Remote source to sync from.
        /// </param>
        /// <param name="destination">
        /// BDN volume to sync into.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.VolumeSyncV1> CreateVolumesSyncsAsync(
            global::Baseten.Source2 source,
            global::Baseten.VolumeSyncDestinationV1 destination,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}