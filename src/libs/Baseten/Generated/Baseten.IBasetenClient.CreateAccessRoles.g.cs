#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a custom role<br/>
        /// Needs `access.role.write` for the organization, or in the role's team while your organization lets team admins manage roles. Unknown, reserved, or unavailable permissions return 400 with the `reason` in the error details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/access/roles \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": null,<br/>
        ///   "kind": "ORGANIZATION",<br/>
        ///   "team_id": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AccessRoleV1> CreateAccessRolesAsync(

            global::Baseten.CreateAccessRoleRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a custom role<br/>
        /// Needs `access.role.write` for the organization, or in the role's team while your organization lets team admins manage roles. Unknown, reserved, or unavailable permissions return 400 with the `reason` in the error details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/access/roles \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": null,<br/>
        ///   "kind": "ORGANIZATION",<br/>
        ///   "team_id": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.AccessRoleV1>> CreateAccessRolesAsResponseAsync(

            global::Baseten.CreateAccessRoleRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a custom role<br/>
        /// Needs `access.role.write` for the organization, or in the role's team while your organization lets team admins manage roles. Unknown, reserved, or unavailable permissions return 400 with the `reason` in the error details.
        /// </summary>
        /// <param name="name">
        /// Name of the role, unique in your organization
        /// </param>
        /// <param name="kind">
        /// `ORGANIZATION` to assign the role for the whole organization, or `TEAM` to assign it in teams
        /// </param>
        /// <param name="teamId">
        /// For a team role, ID of the only team it can be assigned in. Omit to let any team use it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Description of the role
        /// </param>
        /// <param name="permissions">
        /// Names of the permissions the role grants
        /// </param>
        /// <param name="includeRoleIds">
        /// IDs of built-in roles whose permissions the role also grants, such as `baseten:reader`
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AccessRoleV1> CreateAccessRolesAsync(
            string name,
            global::Baseten.AccessRoleKindV1 kind,
            string? teamId = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? permissions = default,
            global::System.Collections.Generic.IList<string>? includeRoleIds = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}