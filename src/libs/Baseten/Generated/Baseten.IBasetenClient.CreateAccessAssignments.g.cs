#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Assigns a role<br/>
        /// Gives a user, service account, or directory group a role, for the organization or in a team. Needs `access.member.write` there, or `access.group.write` for a directory group. A service account's roles also need `service_account.write` where the account belongs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/access/assignments \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "role_id": null,<br/>
        ///   "subject_type": "USER",<br/>
        ///   "subject_id": null,<br/>
        ///   "team_id": null,<br/>
        ///   "resource_sets": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AccessAssignmentV1> CreateAccessAssignmentsAsync(

            global::Baseten.CreateAccessAssignmentRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assigns a role<br/>
        /// Gives a user, service account, or directory group a role, for the organization or in a team. Needs `access.member.write` there, or `access.group.write` for a directory group. A service account's roles also need `service_account.write` where the account belongs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/access/assignments \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "role_id": null,<br/>
        ///   "subject_type": "USER",<br/>
        ///   "subject_id": null,<br/>
        ///   "team_id": null,<br/>
        ///   "resource_sets": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.AccessAssignmentV1>> CreateAccessAssignmentsAsResponseAsync(

            global::Baseten.CreateAccessAssignmentRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assigns a role<br/>
        /// Gives a user, service account, or directory group a role, for the organization or in a team. Needs `access.member.write` there, or `access.group.write` for a directory group. A service account's roles also need `service_account.write` where the account belongs.
        /// </summary>
        /// <param name="roleId">
        /// ID of the role to assign
        /// </param>
        /// <param name="subjectType">
        /// Type of the subject to give the role to
        /// </param>
        /// <param name="subjectId">
        /// ID of the user, service account, or directory group to give the role to
        /// </param>
        /// <param name="teamId">
        /// ID of the team to assign a team role in. Omit for an organization role.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="resourceSets">
        /// Sets of resources the role applies to. It applies to what any set matches, and a set matches what every resource in its `all_of` matches. For example, one set for a model in staging and another for a different model in production. An environment name no deployment uses yet applies once one does. Omit for every resource where the role applies.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AccessAssignmentV1> CreateAccessAssignmentsAsync(
            string roleId,
            global::Baseten.AccessSubjectTypeV1 subjectType,
            string subjectId,
            string? teamId = default,
            global::System.Collections.Generic.IList<global::Baseten.AccessResourceSetRequestV1>? resourceSets = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}