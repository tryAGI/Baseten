#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Validate a Loops checkpoint bt:// URI.<br/>
        /// Whether the caller can manage and use this checkpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/checkpoints/validate \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "checkpoint_path": "bt://loops:k4q95w5/sampler_weights/step-100"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ValidateLoopsCheckpointResponseV1> CreateLoopsCheckpointsValidateAsync(

            global::Baseten.ValidateLoopsCheckpointRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate a Loops checkpoint bt:// URI.<br/>
        /// Whether the caller can manage and use this checkpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/checkpoints/validate \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "checkpoint_path": "bt://loops:k4q95w5/sampler_weights/step-100"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ValidateLoopsCheckpointResponseV1>> CreateLoopsCheckpointsValidateAsResponseAsync(

            global::Baseten.ValidateLoopsCheckpointRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validate a Loops checkpoint bt:// URI.<br/>
        /// Whether the caller can manage and use this checkpoint.
        /// </summary>
        /// <param name="checkpointPath">
        /// bt:// URI of a sampler checkpoint. Form: bt://loops:&lt;run_id&gt;/sampler_weights/&lt;checkpoint_name&gt;.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.ValidateLoopsCheckpointResponseV1> CreateLoopsCheckpointsValidateAsync(
            string checkpointPath,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}