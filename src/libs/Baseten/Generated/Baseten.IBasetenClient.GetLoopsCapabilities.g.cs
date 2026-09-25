#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets Loops server capabilities<br/>
        /// Returns the list of models supported by the Loops server, including each model's maximum context length and whether it supports vision-language inputs. Each entry carries an 'enabled' flag saying whether this workspace can run it now, and 'enablement_details' explaining why when it cannot; filter on 'enabled' for the usable set. Capacity is resolved when the run is created, not here. Pass ?model= to ask about one model — an empty list means Baseten does not support it. Pass ?use_case=sft for a run that needs no sampler, and ?max_seq_len= to check a specific sequence length.
        /// </summary>
        /// <param name="model">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="useCase">
        /// What the caller intends to run.<br/>
        /// Reinforcement learning runs a trainer and a sampler; supervised<br/>
        /// fine-tuning runs a trainer alone. A model can therefore be enabled for one<br/>
        /// and not the other, and the same model can support a longer sequence length<br/>
        /// for SFT than for RL.<br/>
        /// Default Value: rl
        /// </param>
        /// <param name="maxSeqLen">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/loops/capabilities \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetLoopsCapabilitiesResponseV1> GetLoopsCapabilitiesAsync(
            string? model = default,
            global::Baseten.LoopsUseCaseV1? useCase = default,
            int? maxSeqLen = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Gets Loops server capabilities<br/>
        /// Returns the list of models supported by the Loops server, including each model's maximum context length and whether it supports vision-language inputs. Each entry carries an 'enabled' flag saying whether this workspace can run it now, and 'enablement_details' explaining why when it cannot; filter on 'enabled' for the usable set. Capacity is resolved when the run is created, not here. Pass ?model= to ask about one model — an empty list means Baseten does not support it. Pass ?use_case=sft for a run that needs no sampler, and ?max_seq_len= to check a specific sequence length.
        /// </summary>
        /// <param name="model">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="useCase">
        /// What the caller intends to run.<br/>
        /// Reinforcement learning runs a trainer and a sampler; supervised<br/>
        /// fine-tuning runs a trainer alone. A model can therefore be enabled for one<br/>
        /// and not the other, and the same model can support a longer sequence length<br/>
        /// for SFT than for RL.<br/>
        /// Default Value: rl
        /// </param>
        /// <param name="maxSeqLen">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/loops/capabilities \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.GetLoopsCapabilitiesResponseV1>> GetLoopsCapabilitiesAsResponseAsync(
            string? model = default,
            global::Baseten.LoopsUseCaseV1? useCase = default,
            int? maxSeqLen = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}