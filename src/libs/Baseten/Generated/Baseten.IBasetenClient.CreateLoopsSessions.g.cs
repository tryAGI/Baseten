#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Create a Loops session.<br/>
        /// Creates a Loops session for the given training project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/sessions \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "training_project_id": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.CreateLoopSessionResponseV1> CreateLoopsSessionsAsync(

            global::Baseten.CreateLoopSessionRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Loops session.<br/>
        /// Creates a Loops session for the given training project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/sessions \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "training_project_id": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.CreateLoopSessionResponseV1>> CreateLoopsSessionsAsResponseAsync(

            global::Baseten.CreateLoopSessionRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Loops session.<br/>
        /// Creates a Loops session for the given training project.
        /// </summary>
        /// <param name="trainingProjectId">
        /// ID of the training project to associate with. If omitted, a default project is created for the org.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.CreateLoopSessionResponseV1> CreateLoopsSessionsAsync(
            string? trainingProjectId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}