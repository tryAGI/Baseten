#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets daily Model APIs costs<br/>
        /// Returns daily Model API costs in USD for your organization, with optional filtering and grouping by API key, user, model, and service tier. Results may differ from finalized invoice amounts. Cost history is available from August 5, 2026 at 20:45 UTC. August 5 is a partial day; earlier dates are unavailable.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 7
        /// </param>
        /// <param name="startDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="apiKeyPrefixes"></param>
        /// <param name="userIds"></param>
        /// <param name="models"></param>
        /// <param name="serviceTiers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/billing/model_apis \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ModelApisCostsResponseV1> GetBillingModelApisAsync(
            string? cursor = default,
            int? limit = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::System.Collections.Generic.IList<global::Baseten.ModelApiCostDimensionV1>? groupBy = default,
            global::System.Collections.Generic.IList<string>? apiKeyPrefixes = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<string>? serviceTiers = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets daily Model APIs costs<br/>
        /// Returns daily Model API costs in USD for your organization, with optional filtering and grouping by API key, user, model, and service tier. Results may differ from finalized invoice amounts. Cost history is available from August 5, 2026 at 20:45 UTC. August 5 is a partial day; earlier dates are unavailable.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 7
        /// </param>
        /// <param name="startDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endDate">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="apiKeyPrefixes"></param>
        /// <param name="userIds"></param>
        /// <param name="models"></param>
        /// <param name="serviceTiers"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/billing/model_apis \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ModelApisCostsResponseV1>> GetBillingModelApisAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::System.Collections.Generic.IList<global::Baseten.ModelApiCostDimensionV1>? groupBy = default,
            global::System.Collections.Generic.IList<string>? apiKeyPrefixes = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<string>? serviceTiers = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}