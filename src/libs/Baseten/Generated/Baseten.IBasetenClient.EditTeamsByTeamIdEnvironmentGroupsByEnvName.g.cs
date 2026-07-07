#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates an environment group's restriction settings<br/>
        /// Sets whether the environment is restricted and replaces the list of users granted manage access. The team-scoped path targets the team in the path; the top-level path targets the caller's organization default team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="envName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/teams/{team_id}/environment_groups/{env_name} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "manage_access": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.EnvironmentGroupV1> EditTeamsByTeamIdEnvironmentGroupsByEnvNameAsync(
            string teamId,
            string envName,

            global::Baseten.UpdateEnvironmentGroupRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an environment group's restriction settings<br/>
        /// Sets whether the environment is restricted and replaces the list of users granted manage access. The team-scoped path targets the team in the path; the top-level path targets the caller's organization default team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="envName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/teams/{team_id}/environment_groups/{env_name} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "manage_access": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.EnvironmentGroupV1>> EditTeamsByTeamIdEnvironmentGroupsByEnvNameAsResponseAsync(
            string teamId,
            string envName,

            global::Baseten.UpdateEnvironmentGroupRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an environment group's restriction settings<br/>
        /// Sets whether the environment is restricted and replaces the list of users granted manage access. The team-scoped path targets the team in the path; the top-level path targets the caller's organization default team.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="envName"></param>
        /// <param name="manageAccess">
        /// Manage-access settings to apply. Omit to leave manage access unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.EnvironmentGroupV1> EditTeamsByTeamIdEnvironmentGroupsByEnvNameAsync(
            string teamId,
            string envName,
            global::Baseten.UpdateEnvironmentGroupManageAccessV1? manageAccess = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}