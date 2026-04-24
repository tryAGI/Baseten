#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Get trainer server checkpoint files.<br/>
        /// Get presigned URLs for the files under a trainer server checkpoint. Returns a paginated list; deviates from Tinker's single-archive-URL shape because trainer weight sync writes an unzipped folder.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="trainerServerId"></param>
        /// <param name="checkpointId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/trainers/sessions/{session_id}/trainers/{trainer_server_id}/checkpoints/{checkpoint_id}/files \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetTrainerServerCheckpointFilesResponseV1> GetTrainersSessionsBySessionIdTrainersByTrainerServerIdCheckpointsByCheckpointIdFilesAsync(
            string sessionId,
            string trainerServerId,
            string checkpointId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}