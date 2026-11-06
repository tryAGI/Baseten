#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Lists Model APIs<br/>
        /// Lists model metadata with added-model details for teams where you can invoke Model APIs. Legacy Default Team fields remain deprecated but unchanged. Pass team_ids to narrow team details; unauthorized teams cause a 403. added_only=true returns models added by any team in scope. Models added in scope sort first, by their latest addition. Pagination is by model; cursor filters are preserved and reauthorized on every page.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="teamIds"></param>
        /// <param name="addedOnly">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/model_apis \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ModelAPIsResponseV1> GetModelApisAsync(
            string? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? teamIds = default,
            bool? addedOnly = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lists Model APIs<br/>
        /// Lists model metadata with added-model details for teams where you can invoke Model APIs. Legacy Default Team fields remain deprecated but unchanged. Pass team_ids to narrow team details; unauthorized teams cause a 403. added_only=true returns models added by any team in scope. Models added in scope sort first, by their latest addition. Pagination is by model; cursor filters are preserved and reauthorized on every page.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="teamIds"></param>
        /// <param name="addedOnly">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/model_apis \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ModelAPIsResponseV1>> GetModelApisAsResponseAsync(
            string? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? teamIds = default,
            bool? addedOnly = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}