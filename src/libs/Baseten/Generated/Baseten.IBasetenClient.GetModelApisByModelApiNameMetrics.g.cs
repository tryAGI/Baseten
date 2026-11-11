#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets the metrics for a Model API<br/>
        /// Gets the metrics for a Model API in the given time range for the teams you can manage, with each series labeled by team_id. Organization admins receive organization-wide metrics by default. For a Model API your lab organization lists, other organizations' consumption is included regardless of team_ids.
        /// </summary>
        /// <param name="mode">
        /// How metric values are aggregated over the request.<br/>
        /// Default Value: CURRENT
        /// </param>
        /// <param name="startEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metrics"></param>
        /// <param name="teamIds"></param>
        /// <param name="modelApiName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/model_apis/{model_api_name}/metrics \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetMetricsResponseV1> GetModelApisByModelApiNameMetricsAsync(
            string modelApiName,
            global::Baseten.MetricModeV1? mode = default,
            int? startEpochMillis = default,
            int? endEpochMillis = default,
            global::System.Collections.Generic.IList<string>? metrics = default,
            global::System.Collections.Generic.IList<string>? teamIds = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets the metrics for a Model API<br/>
        /// Gets the metrics for a Model API in the given time range for the teams you can manage, with each series labeled by team_id. Organization admins receive organization-wide metrics by default. For a Model API your lab organization lists, other organizations' consumption is included regardless of team_ids.
        /// </summary>
        /// <param name="mode">
        /// How metric values are aggregated over the request.<br/>
        /// Default Value: CURRENT
        /// </param>
        /// <param name="startEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endEpochMillis">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metrics"></param>
        /// <param name="teamIds"></param>
        /// <param name="modelApiName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/model_apis/{model_api_name}/metrics \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.GetMetricsResponseV1>> GetModelApisByModelApiNameMetricsAsResponseAsync(
            string modelApiName,
            global::Baseten.MetricModeV1? mode = default,
            int? startEpochMillis = default,
            int? endEpochMillis = default,
            global::System.Collections.Generic.IList<string>? metrics = default,
            global::System.Collections.Generic.IList<string>? teamIds = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}