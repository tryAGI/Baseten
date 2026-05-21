#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a new model from a source<br/>
        /// Creates a new model in the caller's organization. The `source` field selects how the model is constructed (currently: `library_listing` — fork an accessible listing from `GET /v1/library_models`). The deployment isn't instantly ready — poll GET endpoint until status is ACTIVE.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/teams/{team_id}/models \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "source": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.CreatedModelDeploymentV1> CreateTeamsByTeamIdModelsAsync(
            string teamId,

            global::Baseten.CreateModelRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new model from a source<br/>
        /// Creates a new model in the caller's organization. The `source` field selects how the model is constructed (currently: `library_listing` — fork an accessible listing from `GET /v1/library_models`). The deployment isn't instantly ready — poll GET endpoint until status is ACTIVE.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/teams/{team_id}/models \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "source": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.CreatedModelDeploymentV1>> CreateTeamsByTeamIdModelsAsResponseAsync(
            string teamId,

            global::Baseten.CreateModelRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new model from a source<br/>
        /// Creates a new model in the caller's organization. The `source` field selects how the model is constructed (currently: `library_listing` — fork an accessible listing from `GET /v1/library_models`). The deployment isn't instantly ready — poll GET endpoint until status is ACTIVE.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="source">
        /// Where the new model is created from.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.CreatedModelDeploymentV1> CreateTeamsByTeamIdModelsAsync(
            string teamId,
            global::Baseten.Source source,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}