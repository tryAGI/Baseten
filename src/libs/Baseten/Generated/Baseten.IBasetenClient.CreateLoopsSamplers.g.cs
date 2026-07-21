#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a Loops sampler<br/>
        /// Creates a standalone Loops sampler not linked to a run.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/samplers \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "session_id": null,<br/>
        ///   "base_model": null,<br/>
        ///   "run_id": null,<br/>
        ///   "max_seq_length": null,<br/>
        ///   "model_path": "bt://loops:k4q95w5/sampler_weights/step-100",<br/>
        ///   "reuse_from_session_id": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.CreateLoopsSamplerResponseV1> CreateLoopsSamplersAsync(

            global::Baseten.CreateLoopsSamplerRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a Loops sampler<br/>
        /// Creates a standalone Loops sampler not linked to a run.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/samplers \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "session_id": null,<br/>
        ///   "base_model": null,<br/>
        ///   "run_id": null,<br/>
        ///   "max_seq_length": null,<br/>
        ///   "model_path": "bt://loops:k4q95w5/sampler_weights/step-100",<br/>
        ///   "reuse_from_session_id": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.CreateLoopsSamplerResponseV1>> CreateLoopsSamplersAsResponseAsync(

            global::Baseten.CreateLoopsSamplerRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a Loops sampler<br/>
        /// Creates a standalone Loops sampler not linked to a run.
        /// </summary>
        /// <param name="sessionId">
        /// ID of the Loops session this sampler belongs to.
        /// </param>
        /// <param name="baseModel">
        /// Base model ID for a standalone sampler (for example, a baseline). Required unless run_id is set, in which case the base model is inherited from the run.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="runId">
        /// ID of an existing run to attach this sampler to. When set, the sampler is paired to the run and weight-syncs from its trainer, and base_model is inherited from the run. Omit to create a standalone sampler.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="maxSeqLength">
        /// Maximum prompt length (in tokens) the sampler must handle. Set this to the longest prompt you plan to send. Omit to use the default for the base model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="modelPath">
        /// Optional bt:// URI of an existing sampler-target checkpoint to load weights from on startup. Form: bt://loops:&lt;run_id&gt;/sampler_weights/&lt;checkpoint_name&gt;.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="reuseFromSessionId">
        /// Optional Loops session ID to reuse infrastructure from. Best-effort.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.CreateLoopsSamplerResponseV1> CreateLoopsSamplersAsync(
            string sessionId,
            string? baseModel = default,
            string? runId = default,
            int? maxSeqLength = default,
            string? modelPath = default,
            string? reuseFromSessionId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}