#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets Model APIs token usage in time buckets<br/>
        /// Returns Model APIs token usage for the teams you can manage as a series of contiguous time buckets, broken down by the dimensions you pass in group_by. Organization admins receive organization-wide totals by default; other callers may receive lower totals than callers with management-access to more teams. Buckets with no usage are included, so the series has no gaps. Usage is retained for 92 days, so buckets older than that are returned with no results.
        /// </summary>
        /// <param name="startTime">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endTime">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="bucketWidth">
        /// Default Value: 1d
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="apiKeys"></param>
        /// <param name="userIds"></param>
        /// <param name="models"></param>
        /// <param name="teamIds"></param>
        /// <param name="limit">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/model_apis/usage \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ModelApisUsageResponseV1> GetModelApisUsageAsync(
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::Baseten.BucketWidth? bucketWidth = default,
            global::System.Collections.Generic.IList<global::Baseten.UsageDimensionV1>? groupBy = default,
            global::System.Collections.Generic.IList<string>? apiKeys = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<string>? teamIds = default,
            int? limit = default,
            string? cursor = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets Model APIs token usage in time buckets<br/>
        /// Returns Model APIs token usage for the teams you can manage as a series of contiguous time buckets, broken down by the dimensions you pass in group_by. Organization admins receive organization-wide totals by default; other callers may receive lower totals than callers with management-access to more teams. Buckets with no usage are included, so the series has no gaps. Usage is retained for 92 days, so buckets older than that are returned with no results.
        /// </summary>
        /// <param name="startTime">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endTime">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="bucketWidth">
        /// Default Value: 1d
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="apiKeys"></param>
        /// <param name="userIds"></param>
        /// <param name="models"></param>
        /// <param name="teamIds"></param>
        /// <param name="limit">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/model_apis/usage \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ModelApisUsageResponseV1>> GetModelApisUsageAsResponseAsync(
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::Baseten.BucketWidth? bucketWidth = default,
            global::System.Collections.Generic.IList<global::Baseten.UsageDimensionV1>? groupBy = default,
            global::System.Collections.Generic.IList<string>? apiKeys = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<string>? teamIds = default,
            int? limit = default,
            string? cursor = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}