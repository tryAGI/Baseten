#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets where a Loops checkpoint's files come from<br/>
        /// Reports how to fetch a checkpoint's files: `s3` when the files endpoint serves presigned URLs for it, or `volume` with the ref to pull. Clients that download checkpoints should ask here first.
        /// </summary>
        /// <param name="checkpointId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/loops/checkpoints/{checkpoint_id}/source \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.LoopsCheckpointSourceResponseV1> GetLoopsCheckpointsByCheckpointIdSourceAsync(
            string checkpointId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets where a Loops checkpoint's files come from<br/>
        /// Reports how to fetch a checkpoint's files: `s3` when the files endpoint serves presigned URLs for it, or `volume` with the ref to pull. Clients that download checkpoints should ask here first.
        /// </summary>
        /// <param name="checkpointId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/loops/checkpoints/{checkpoint_id}/source \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.LoopsCheckpointSourceResponseV1>> GetLoopsCheckpointsByCheckpointIdSourceAsResponseAsync(
            string checkpointId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}