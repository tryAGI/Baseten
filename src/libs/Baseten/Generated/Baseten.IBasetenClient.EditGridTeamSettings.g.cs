#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a team's Grid settings by team ID or your only team<br/>
        /// Changes only the fields in the request, all or nothing. Requires team admin, and organization admin to change the team-wide spend limit. The team comes from `team_id` instead of the path. Omit it to use the team you belong to; when you belong to several, the request fails with a 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/grid/team_settings \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "harness_defaults": null,<br/>
        ///   "spend_limit": null,<br/>
        ///   "team_id": "abc1234"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GridTeamSettingsV1> EditGridTeamSettingsAsync(

            global::Baseten.UpdateGridTeamSettingsRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a team's Grid settings by team ID or your only team<br/>
        /// Changes only the fields in the request, all or nothing. Requires team admin, and organization admin to change the team-wide spend limit. The team comes from `team_id` instead of the path. Omit it to use the team you belong to; when you belong to several, the request fails with a 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/grid/team_settings \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "harness_defaults": null,<br/>
        ///   "spend_limit": null,<br/>
        ///   "team_id": "abc1234"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.GridTeamSettingsV1>> EditGridTeamSettingsAsResponseAsync(

            global::Baseten.UpdateGridTeamSettingsRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a team's Grid settings by team ID or your only team<br/>
        /// Changes only the fields in the request, all or nothing. Requires team admin, and organization admin to change the team-wide spend limit. The team comes from `team_id` instead of the path. Omit it to use the team you belong to; when you belong to several, the request fails with a 400.
        /// </summary>
        /// <param name="harnessDefaults">
        /// Harnesses to change; harnesses left out are unchanged. Pass null to clear every harness, so each role uses the team's default.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="spendLimit">
        /// Spend limit fields to change. Pass null to remove the team's limits; omit to leave them unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="teamId">
        /// ID of the team. When omitted, the team you belong to; required when you belong to several.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.GridTeamSettingsV1> EditGridTeamSettingsAsync(
            global::Baseten.UpdateGridHarnessDefaultsV1? harnessDefaults = default,
            global::Baseten.UpdateGridTeamSpendLimitSettingV1? spendLimit = default,
            string? teamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}