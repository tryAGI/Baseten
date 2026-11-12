#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a service account<br/>
        /// Creates a service account that workload identity federation tokens act as. It's enabled at once. Omit `team_id` for an organization account, which only an organization admin can create. A team admin can create accounts for their own team.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/service_accounts \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "ci-deployer",<br/>
        ///   "description": "GitHub Actions deploys from acme/models",<br/>
        ///   "team_id": "abcd1234",<br/>
        ///   "preset_permissions": {<br/>
        ///     "type": "WORKSPACE_MANAGE_ALL"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ServiceAccountV1> CreateServiceAccountsAsync(

            global::Baseten.CreateServiceAccountRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a service account<br/>
        /// Creates a service account that workload identity federation tokens act as. It's enabled at once. Omit `team_id` for an organization account, which only an organization admin can create. A team admin can create accounts for their own team.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/service_accounts \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "ci-deployer",<br/>
        ///   "description": "GitHub Actions deploys from acme/models",<br/>
        ///   "team_id": "abcd1234",<br/>
        ///   "preset_permissions": {<br/>
        ///     "type": "WORKSPACE_MANAGE_ALL"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ServiceAccountV1>> CreateServiceAccountsAsResponseAsync(

            global::Baseten.CreateServiceAccountRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a service account<br/>
        /// Creates a service account that workload identity federation tokens act as. It's enabled at once. Omit `team_id` for an organization account, which only an organization admin can create. A team admin can create accounts for their own team.
        /// </summary>
        /// <param name="name">
        /// Name, unique in the organization. Can be changed later.
        /// </param>
        /// <param name="description">
        /// Optional description, up to 1,024 characters<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="teamId">
        /// The team that owns the account. Omit for an organization account. Can't be changed.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="presetPermissions">
        /// What the service account may do. Can be changed later. Temporary; may be removed once fine-grained access control is available.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.ServiceAccountV1> CreateServiceAccountsAsync(
            string name,
            global::Baseten.ServiceAccountPresetPermissionsRequestV1 presetPermissions,
            string? description = default,
            string? teamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}