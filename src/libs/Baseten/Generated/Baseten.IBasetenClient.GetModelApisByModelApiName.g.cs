#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets a Model API<br/>
        /// Returns model metadata with added-model details for teams where you can invoke Model APIs. Legacy Default Team fields remain deprecated but unchanged. Pass team_ids to narrow team details; unauthorized teams cause a 403.
        /// </summary>
        /// <param name="teamIds"></param>
        /// <param name="modelApiName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/model_apis/{model_api_name} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ModelAPIV1> GetModelApisByModelApiNameAsync(
            string modelApiName,
            global::System.Collections.Generic.IList<string>? teamIds = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets a Model API<br/>
        /// Returns model metadata with added-model details for teams where you can invoke Model APIs. Legacy Default Team fields remain deprecated but unchanged. Pass team_ids to narrow team details; unauthorized teams cause a 403.
        /// </summary>
        /// <param name="teamIds"></param>
        /// <param name="modelApiName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/model_apis/{model_api_name} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ModelAPIV1>> GetModelApisByModelApiNameAsResponseAsync(
            string modelApiName,
            global::System.Collections.Generic.IList<string>? teamIds = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}