#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets the audit log for a chain<br/>
        /// Returns audit-log entries for a single chain, newest first. Use the filters to narrow by event type, actor, chain deployment, environment, source, or time window, and the cursor to page.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="direction">
        /// Sort order of returned entries, by creation time.<br/>
        /// Default Value: DESC
        /// </param>
        /// <param name="search">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="eventTypeGroups"></param>
        /// <param name="userIds"></param>
        /// <param name="deploymentIds"></param>
        /// <param name="chainDeploymentIds"></param>
        /// <param name="environmentNames"></param>
        /// <param name="sources"></param>
        /// <param name="startEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chainId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/audit_logs \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ListAuditLogsResponseV1> GetChainsByChainIdAuditLogsAsync(
            string chainId,
            string? cursor = default,
            int? limit = default,
            global::Baseten.AuditLogSortDirectionV1? direction = default,
            string? search = default,
            global::System.Collections.Generic.IList<global::Baseten.AuditLogEventTypeGroupV1>? eventTypeGroups = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? deploymentIds = default,
            global::System.Collections.Generic.IList<string>? chainDeploymentIds = default,
            global::System.Collections.Generic.IList<string>? environmentNames = default,
            global::System.Collections.Generic.IList<global::Baseten.AuditLogSourceV1>? sources = default,
            int? startEpochMillis = default,
            int? endEpochMillis = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the audit log for a chain<br/>
        /// Returns audit-log entries for a single chain, newest first. Use the filters to narrow by event type, actor, chain deployment, environment, source, or time window, and the cursor to page.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="direction">
        /// Sort order of returned entries, by creation time.<br/>
        /// Default Value: DESC
        /// </param>
        /// <param name="search">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="eventTypeGroups"></param>
        /// <param name="userIds"></param>
        /// <param name="deploymentIds"></param>
        /// <param name="chainDeploymentIds"></param>
        /// <param name="environmentNames"></param>
        /// <param name="sources"></param>
        /// <param name="startEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chainId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/chains/{chain_id}/audit_logs \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ListAuditLogsResponseV1>> GetChainsByChainIdAuditLogsAsResponseAsync(
            string chainId,
            string? cursor = default,
            int? limit = default,
            global::Baseten.AuditLogSortDirectionV1? direction = default,
            string? search = default,
            global::System.Collections.Generic.IList<global::Baseten.AuditLogEventTypeGroupV1>? eventTypeGroups = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? deploymentIds = default,
            global::System.Collections.Generic.IList<string>? chainDeploymentIds = default,
            global::System.Collections.Generic.IList<string>? environmentNames = default,
            global::System.Collections.Generic.IList<global::Baseten.AuditLogSourceV1>? sources = default,
            int? startEpochMillis = default,
            int? endEpochMillis = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}