#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deletes a custom role<br/>
        /// Needs `access.role.delete` where the role applies; for a team's role, for the organization unless it lets team admins manage roles. While any assignment uses the role, it returns 409 with reason `ROLE_IN_USE`. Built-in roles return 400.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/access/roles/{role_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AccessRoleTombstoneV1> DeleteAccessRolesByRoleIdAsync(
            string roleId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a custom role<br/>
        /// Needs `access.role.delete` where the role applies; for a team's role, for the organization unless it lets team admins manage roles. While any assignment uses the role, it returns 409 with reason `ROLE_IN_USE`. Built-in roles return 400.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/access/roles/{role_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.AccessRoleTombstoneV1>> DeleteAccessRolesByRoleIdAsResponseAsync(
            string roleId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}