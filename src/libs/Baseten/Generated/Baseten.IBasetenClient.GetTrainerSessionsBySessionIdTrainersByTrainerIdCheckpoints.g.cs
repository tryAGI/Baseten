#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// List trainer server checkpoints.<br/>
        /// List the checkpoints saved by a trainer server.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="trainerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/trainer_sessions/{session_id}/trainers/{trainer_id}/checkpoints \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetTrainerServerCheckpointsResponseV1> GetTrainerSessionsBySessionIdTrainersByTrainerIdCheckpointsAsync(
            string sessionId,
            string trainerId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}