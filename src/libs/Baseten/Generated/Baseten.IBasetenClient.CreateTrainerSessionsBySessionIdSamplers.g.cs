#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Create a sampling server.<br/>
        /// Creates a standalone SamplingServer (not linked to a TrainerServer).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/trainer_sessions/{session_id}/samplers \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "model": null,<br/>
        ///   "max_seq_length": null,<br/>
        ///   "checkpoint_path": "bt://trainers:k4q95w5/sampler_weights/step-100"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.CreateSamplingServerResponseV1> CreateTrainerSessionsBySessionIdSamplersAsync(
            string sessionId,

            global::Baseten.CreateSamplingServerRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a sampling server.<br/>
        /// Creates a standalone SamplingServer (not linked to a TrainerServer).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/trainer_sessions/{session_id}/samplers \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "model": null,<br/>
        ///   "max_seq_length": null,<br/>
        ///   "checkpoint_path": "bt://trainers:k4q95w5/sampler_weights/step-100"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.CreateSamplingServerResponseV1>> CreateTrainerSessionsBySessionIdSamplersAsResponseAsync(
            string sessionId,

            global::Baseten.CreateSamplingServerRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a sampling server.<br/>
        /// Creates a standalone SamplingServer (not linked to a TrainerServer).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="model">
        /// Model to use for standalone samplers (eg, for baselines).
        /// </param>
        /// <param name="maxSeqLength">
        /// Minimum max-sequence-length the sampler must support. If set, only instance-type entries whose configured max_seq_length is &gt;= this value are considered. Omit to accept any entry.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="checkpointPath">
        /// Optional bt:// URI of an existing sampler-target checkpoint to load weights from on startup. Form: bt://trainers:&lt;trainer_id&gt;/sampler_weights/&lt;checkpoint_name&gt;.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.CreateSamplingServerResponseV1> CreateTrainerSessionsBySessionIdSamplersAsync(
            string sessionId,
            string model,
            int? maxSeqLength = default,
            string? checkpointPath = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}