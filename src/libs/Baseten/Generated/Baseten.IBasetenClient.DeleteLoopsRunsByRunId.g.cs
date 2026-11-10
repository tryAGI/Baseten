#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deletes a Loops run<br/>
        /// Deletes a Loops run by ID, deactivating it first if it is active, and deletes its checkpoints. Checkpoints still in use, such as deployed ones, are kept and listed in the response; they stay usable until that use stops. Deletion is permanent, and storage for some checkpoints is reclaimed later.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/loops/runs/{run_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DeleteLoopsRunResponseV1> DeleteLoopsRunsByRunIdAsync(
            string runId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a Loops run<br/>
        /// Deletes a Loops run by ID, deactivating it first if it is active, and deletes its checkpoints. Checkpoints still in use, such as deployed ones, are kept and listed in the response; they stay usable until that use stops. Deletion is permanent, and storage for some checkpoints is reclaimed later.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/loops/runs/{run_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.DeleteLoopsRunResponseV1>> DeleteLoopsRunsByRunIdAsResponseAsync(
            string runId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}