#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deletes a Loops checkpoint<br/>
        /// Deletes a Loops checkpoint by ID and returns its tombstone. The checkpoint disappears from listings and can't be loaded, sampled, or deployed. Deletion is permanent, and storage for some checkpoints is reclaimed later. A checkpoint that is deployed, read by an unfinished LoRA merge, served by an active sampler, or the start of an active run can't be deleted, and the error says which. Deleting an already-deleted checkpoint returns the same tombstone.
        /// </summary>
        /// <param name="checkpointId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/loops/checkpoints/{checkpoint_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.LoopsCheckpointTombstoneV1> DeleteLoopsCheckpointsByCheckpointIdAsync(
            string checkpointId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a Loops checkpoint<br/>
        /// Deletes a Loops checkpoint by ID and returns its tombstone. The checkpoint disappears from listings and can't be loaded, sampled, or deployed. Deletion is permanent, and storage for some checkpoints is reclaimed later. A checkpoint that is deployed, read by an unfinished LoRA merge, served by an active sampler, or the start of an active run can't be deleted, and the error says which. Deleting an already-deleted checkpoint returns the same tombstone.
        /// </summary>
        /// <param name="checkpointId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/loops/checkpoints/{checkpoint_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.LoopsCheckpointTombstoneV1>> DeleteLoopsCheckpointsByCheckpointIdAsResponseAsync(
            string checkpointId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}