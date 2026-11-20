#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Removes a role assignment<br/>
        /// Needs `access.member.delete` where the role applies, or `access.group.write` for a directory group. A service account's roles also need `service_account.write` where the account belongs.
        /// </summary>
        /// <param name="assignmentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/access/assignments/{assignment_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AccessAssignmentTombstoneV1> DeleteAccessAssignmentsByAssignmentIdAsync(
            string assignmentId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Removes a role assignment<br/>
        /// Needs `access.member.delete` where the role applies, or `access.group.write` for a directory group. A service account's roles also need `service_account.write` where the account belongs.
        /// </summary>
        /// <param name="assignmentId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/access/assignments/{assignment_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.AccessAssignmentTombstoneV1>> DeleteAccessAssignmentsByAssignmentIdAsResponseAsync(
            string assignmentId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}