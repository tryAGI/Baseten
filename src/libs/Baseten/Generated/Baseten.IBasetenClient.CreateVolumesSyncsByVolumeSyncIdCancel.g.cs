#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Cancels a volume sync<br/>
        /// Requests cancellation of a pending or running sync. Repeated cancellation and cancellation of terminal syncs return the existing state. Once cancellation is accepted, a later completion callback cannot replace the CANCELED state.
        /// </summary>
        /// <param name="volumeSyncId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/volumes/syncs/{volume_sync_id}/cancel \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.VolumeSyncV1> CreateVolumesSyncsByVolumeSyncIdCancelAsync(
            string volumeSyncId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancels a volume sync<br/>
        /// Requests cancellation of a pending or running sync. Repeated cancellation and cancellation of terminal syncs return the existing state. Once cancellation is accepted, a later completion callback cannot replace the CANCELED state.
        /// </summary>
        /// <param name="volumeSyncId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/volumes/syncs/{volume_sync_id}/cancel \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.VolumeSyncV1>> CreateVolumesSyncsByVolumeSyncIdCancelAsResponseAsync(
            string volumeSyncId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}