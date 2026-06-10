#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Get Loops checkpoint files.<br/>
        /// Get presigned URLs for the files under a Loops checkpoint. Returns a paginated list.
        /// </summary>
        /// <param name="checkpointId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/loops/checkpoints/{checkpoint_id}/files \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.LoopsCheckpointFilesResponseV1> GetLoopsCheckpointsByCheckpointIdFilesAsync(
            string checkpointId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Loops checkpoint files.<br/>
        /// Get presigned URLs for the files under a Loops checkpoint. Returns a paginated list.
        /// </summary>
        /// <param name="checkpointId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/loops/checkpoints/{checkpoint_id}/files \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.LoopsCheckpointFilesResponseV1>> GetLoopsCheckpointsByCheckpointIdFilesAsResponseAsync(
            string checkpointId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}