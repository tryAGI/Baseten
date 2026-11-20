#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Sets a Loops checkpoint's TTL<br/>
        /// Sets when a Loops checkpoint expires, counted from now, or removes its TTL so it's kept until you delete it. An expired checkpoint is deleted within 24 hours. If it's in use when it expires, it's deleted within 24 hours after it stops being used.
        /// </summary>
        /// <param name="checkpointId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PUT \<br/>
        /// --url https://api.baseten.co/v1/loops/checkpoints/{checkpoint_id}/ttl \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "ttl_seconds": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.LoopsCheckpointV1> PutLoopsCheckpointsByCheckpointIdTtlAsync(
            string checkpointId,

            global::Baseten.SetLoopsCheckpointTtlRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sets a Loops checkpoint's TTL<br/>
        /// Sets when a Loops checkpoint expires, counted from now, or removes its TTL so it's kept until you delete it. An expired checkpoint is deleted within 24 hours. If it's in use when it expires, it's deleted within 24 hours after it stops being used.
        /// </summary>
        /// <param name="checkpointId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PUT \<br/>
        /// --url https://api.baseten.co/v1/loops/checkpoints/{checkpoint_id}/ttl \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "ttl_seconds": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.LoopsCheckpointV1>> PutLoopsCheckpointsByCheckpointIdTtlAsResponseAsync(
            string checkpointId,

            global::Baseten.SetLoopsCheckpointTtlRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sets a Loops checkpoint's TTL<br/>
        /// Sets when a Loops checkpoint expires, counted from now, or removes its TTL so it's kept until you delete it. An expired checkpoint is deleted within 24 hours. If it's in use when it expires, it's deleted within 24 hours after it stops being used.
        /// </summary>
        /// <param name="checkpointId"></param>
        /// <param name="ttlSeconds">
        /// Seconds from now until the checkpoint expires and is deleted, from 3600 (1 hour) to 315360000 (10 years). Null removes the TTL, so the checkpoint never expires.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.LoopsCheckpointV1> PutLoopsCheckpointsByCheckpointIdTtlAsync(
            string checkpointId,
            int? ttlSeconds = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}