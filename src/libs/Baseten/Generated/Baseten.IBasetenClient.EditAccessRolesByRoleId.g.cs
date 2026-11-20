#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a custom role<br/>
        /// Changes the fields you send. `permissions` and `include_role_ids` add to the role's lists, and the `_to_delete` fields remove from them. Needs `access.role.write` where the role applies; for a team's role, for the organization unless it lets team admins manage roles. Built-in roles return 400.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/access/roles/{role_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": null,<br/>
        ///   "description": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AccessRoleV1> EditAccessRolesByRoleIdAsync(
            string roleId,

            global::Baseten.UpdateAccessRoleRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a custom role<br/>
        /// Changes the fields you send. `permissions` and `include_role_ids` add to the role's lists, and the `_to_delete` fields remove from them. Needs `access.role.write` where the role applies; for a team's role, for the organization unless it lets team admins manage roles. Built-in roles return 400.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/access/roles/{role_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": null,<br/>
        ///   "description": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.AccessRoleV1>> EditAccessRolesByRoleIdAsResponseAsync(
            string roleId,

            global::Baseten.UpdateAccessRoleRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a custom role<br/>
        /// Changes the fields you send. `permissions` and `include_role_ids` add to the role's lists, and the `_to_delete` fields remove from them. Needs `access.role.write` where the role applies; for a team's role, for the organization unless it lets team admins manage roles. Built-in roles return 400.
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="name">
        /// New name of the role<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// New description of the role<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="permissions">
        /// Names of permissions to add to the role
        /// </param>
        /// <param name="permissionsToDelete">
        /// Names of permissions to remove from the role
        /// </param>
        /// <param name="includeRoleIds">
        /// IDs of built-in roles for the role to include
        /// </param>
        /// <param name="includeRoleIdsToDelete">
        /// IDs of built-in roles for the role to stop including
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AccessRoleV1> EditAccessRolesByRoleIdAsync(
            string roleId,
            string? name = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? permissions = default,
            global::System.Collections.Generic.IList<string>? permissionsToDelete = default,
            global::System.Collections.Generic.IList<string>? includeRoleIds = default,
            global::System.Collections.Generic.IList<string>? includeRoleIdsToDelete = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}