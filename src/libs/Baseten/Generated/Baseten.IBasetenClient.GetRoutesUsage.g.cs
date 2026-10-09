#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets daily route usage and estimated costs<br/>
        /// Buckets are UTC days, and days with no usage are included. Organization admins see all route usage in the organization. Team admins see usage in teams they manage. Other members, including viewers, see only usage from Routes keys they created, including keys that have since expired, been revoked, or been deleted. Usage can be filtered and grouped by the team it was metered in. Usage is metered every 15 minutes, so the current hour can lag. Model API costs use your prices at the time of each request and include tool calls. xAI costs are the charges xAI reports. OpenAI and Anthropic costs are estimated from Baseten's reference prices and may differ from your provider's bill. Vertex and OpenAI-compatible usage is not included. Costs for OpenAI, Anthropic, and xAI estimate what you pay those providers; they are not Baseten charges. Usage is retained for 92 days.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 7
        /// </param>
        /// <param name="teamId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="startDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="userIds"></param>
        /// <param name="models"></param>
        /// <param name="providers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/routes/usage \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RoutesUsageResponseV1> GetRoutesUsageAsync(
            string? cursor = default,
            int? limit = default,
            string? teamId = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::System.Collections.Generic.IList<global::Baseten.RouteUsageDimensionV1>? groupBy = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Baseten.RouteProviderV1>? providers = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets daily route usage and estimated costs<br/>
        /// Buckets are UTC days, and days with no usage are included. Organization admins see all route usage in the organization. Team admins see usage in teams they manage. Other members, including viewers, see only usage from Routes keys they created, including keys that have since expired, been revoked, or been deleted. Usage can be filtered and grouped by the team it was metered in. Usage is metered every 15 minutes, so the current hour can lag. Model API costs use your prices at the time of each request and include tool calls. xAI costs are the charges xAI reports. OpenAI and Anthropic costs are estimated from Baseten's reference prices and may differ from your provider's bill. Vertex and OpenAI-compatible usage is not included. Costs for OpenAI, Anthropic, and xAI estimate what you pay those providers; they are not Baseten charges. Usage is retained for 92 days.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 7
        /// </param>
        /// <param name="teamId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="startDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="userIds"></param>
        /// <param name="models"></param>
        /// <param name="providers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/routes/usage \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RoutesUsageResponseV1>> GetRoutesUsageAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            string? teamId = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::System.Collections.Generic.IList<global::Baseten.RouteUsageDimensionV1>? groupBy = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::Baseten.RouteProviderV1>? providers = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}