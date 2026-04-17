#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Create a trainer server.<br/>
        /// Creates a TrainerServer and an associated SamplingServer for the given trainer session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/trainers/sessions/{session_id}/trainers \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "model": null,<br/>
        ///   "lora_rank": null,<br/>
        ///   "seed": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.CreateTrainerServerResponseV1> CreateTrainersSessionsBySessionIdTrainersAsync(
            string sessionId,

            global::Baseten.CreateTrainerServerRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a trainer server.<br/>
        /// Creates a TrainerServer and an associated SamplingServer for the given trainer session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="model">
        /// Base model ID (e.g. 'Qwen/Qwen3-8B').
        /// </param>
        /// <param name="loraRank">
        /// LoRA rank.<br/>
        /// Default Value: 16
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.CreateTrainerServerResponseV1> CreateTrainersSessionsBySessionIdTrainersAsync(
            string sessionId,
            string model,
            int? loraRank = default,
            int? seed = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}