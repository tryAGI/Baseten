#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Create a Loops run.<br/>
        /// Creates a Loops run with an associated sampler in the given session.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/runs \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "session_id": null,<br/>
        ///   "base_model": null,<br/>
        ///   "max_seq_len": null,<br/>
        ///   "lora_rank": null,<br/>
        ///   "seed": null,<br/>
        ///   "scale_down_delay_seconds": null,<br/>
        ///   "path": "bt://loops:k4q95w5/weights/step-100",<br/>
        ///   "reuse_from_session_id": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.CreateLoopsRunResponseV1> CreateLoopsRunsAsync(

            global::Baseten.CreateLoopsRunRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Loops run.<br/>
        /// Creates a Loops run with an associated sampler in the given session.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/runs \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "session_id": null,<br/>
        ///   "base_model": null,<br/>
        ///   "max_seq_len": null,<br/>
        ///   "lora_rank": null,<br/>
        ///   "seed": null,<br/>
        ///   "scale_down_delay_seconds": null,<br/>
        ///   "path": "bt://loops:k4q95w5/weights/step-100",<br/>
        ///   "reuse_from_session_id": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.CreateLoopsRunResponseV1>> CreateLoopsRunsAsResponseAsync(

            global::Baseten.CreateLoopsRunRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Loops run.<br/>
        /// Creates a Loops run with an associated sampler in the given session.
        /// </summary>
        /// <param name="sessionId">
        /// ID of the Loops session this run belongs to.
        /// </param>
        /// <param name="baseModel">
        /// Base model ID (e.g. 'Qwen/Qwen3-8B').
        /// </param>
        /// <param name="maxSeqLen">
        /// Maximum prompt length (in tokens) the run must handle. Set this to the longest training example you plan to send. Defaults to the maximum supported by the model configuration.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="loraRank">
        /// LoRA rank.<br/>
        /// Default Value: 64
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="scaleDownDelaySeconds">
        /// Seconds of inactivity before the run scales to zero. Must be positive. Defaults to 3600 (1 hour).<br/>
        /// Default Value: 3600
        /// </param>
        /// <param name="path">
        /// Optional bt:// URI of an existing checkpoint to load weights from on startup. Form: bt://loops:&lt;run_id&gt;/weights/&lt;checkpoint_name&gt;.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="reuseFromSessionId">
        /// Optional Loops session ID whose trainer deployment should be reused for this run, sharing the infrastructure across sessions instead of provisioning fresh. The named session must belong to the same team. Reuse is best-effort: if the prior deployment is stopped, failed, or its sampler is unhealthy, a new deployment is provisioned instead.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.CreateLoopsRunResponseV1> CreateLoopsRunsAsync(
            string sessionId,
            string baseModel,
            int? maxSeqLen = default,
            int? loraRank = default,
            int? seed = default,
            int? scaleDownDelaySeconds = default,
            string? path = default,
            string? reuseFromSessionId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}