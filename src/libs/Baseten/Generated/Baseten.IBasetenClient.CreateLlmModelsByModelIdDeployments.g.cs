#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a new BIS LLM deployment version
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/llm_models/{model_id}/deployments \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "resources": null,<br/>
        ///   "llm_version": null,<br/>
        ///   "llm_config": null,<br/>
        ///   "environment_variables": null,<br/>
        ///   "model_metadata": null,<br/>
        ///   "autoscaling_settings": {<br/>
        ///     "autoscaling_window": 600,<br/>
        ///     "concurrency_target": null,<br/>
        ///     "max_replica": 5,<br/>
        ///     "min_replica": 1,<br/>
        ///     "scale_down_delay": 300,<br/>
        ///     "target_in_flight_tokens": null,<br/>
        ///     "target_utilization_percentage": null<br/>
        ///   },<br/>
        ///   "additional_autoscaling_config": {<br/>
        ///     "metrics": [<br/>
        ///       {<br/>
        ///         "name": "in_flight_tokens",<br/>
        ///         "target": 40000<br/>
        ///       }<br/>
        ///     ]<br/>
        ///   },<br/>
        ///   "metadata": {<br/>
        ///     "environment": "production",<br/>
        ///     "git_sha": "abc123"<br/>
        ///   },<br/>
        ///   "weights": [<br/>
        ///     {<br/>
        ///       "mount_location": "/models/base",<br/>
        ///       "source": "hf://meta-llama/Llama-3-8B"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.LLMModelHandleV1> CreateLlmModelsByModelIdDeploymentsAsync(
            string modelId,

            global::Baseten.CreateLLMModelVersionRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new BIS LLM deployment version
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="resources">
        /// Resources allocated to the model
        /// </param>
        /// <param name="llmVersion">
        /// Version of the helm chart to use<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="llmConfig">
        /// Configuration specific to the LLM model
        /// </param>
        /// <param name="environmentVariables">
        /// Environment variables for the model
        /// </param>
        /// <param name="modelMetadata">
        /// Model metadata persisted into model_config<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="autoscalingSettings">
        /// Autoscaling settings for the model<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="additionalAutoscalingConfig">
        /// Additional autoscaling configuration (e.g. target in-flight tokens)<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadata">
        /// User-defined metadata for the deployment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="weights">
        /// Weight configurations for BDN model weight distribution<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.LLMModelHandleV1> CreateLlmModelsByModelIdDeploymentsAsync(
            string modelId,
            object resources,
            string? llmVersion = default,
            object? llmConfig = default,
            object? environmentVariables = default,
            object? modelMetadata = default,
            global::Baseten.UpdateAutoscalingSettingsV1? autoscalingSettings = default,
            object? additionalAutoscalingConfig = default,
            object? metadata = default,
            global::System.Collections.Generic.IList<object>? weights = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}