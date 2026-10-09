#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a team's route settings<br/>
        /// Changes only the fields in the request, all or nothing. Requires team admin, and organization admin to change the team-wide spend limit.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/routes/settings/teams/{team_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "harness_defaults": null,<br/>
        ///   "spend_limit": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RouteTeamSettingsV1> EditRoutesSettingsTeamsByTeamIdAsync(
            string teamId,

            global::Baseten.UpdateRouteTeamSettingsRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a team's route settings<br/>
        /// Changes only the fields in the request, all or nothing. Requires team admin, and organization admin to change the team-wide spend limit.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/routes/settings/teams/{team_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "harness_defaults": null,<br/>
        ///   "spend_limit": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RouteTeamSettingsV1>> EditRoutesSettingsTeamsByTeamIdAsResponseAsync(
            string teamId,

            global::Baseten.UpdateRouteTeamSettingsRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a team's route settings<br/>
        /// Changes only the fields in the request, all or nothing. Requires team admin, and organization admin to change the team-wide spend limit.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="harnessDefaults">
        /// Harnesses to change; harnesses left out are unchanged. Pass null to clear every harness, so each role uses the team's default.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="spendLimit">
        /// Spend limit fields to change. Pass null to remove the team's limits; omit to leave them unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.RouteTeamSettingsV1> EditRoutesSettingsTeamsByTeamIdAsync(
            string teamId,
            global::Baseten.UpdateRouteHarnessDefaultsV1? harnessDefaults = default,
            global::Baseten.UpdateRouteTeamSpendLimitSettingV1? spendLimit = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}