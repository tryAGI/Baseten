#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a model by ID<br/>
        /// Updates the mutable fields of a model and returns the updated model. Renaming does not change the model ID, endpoints, or deployments. Pushes that still use the old model_name create another model or target a model that now uses that name, so update config.yaml after renaming.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "my-model"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ModelV1> EditModelsByModelIdAsync(
            string modelId,

            global::Baseten.UpdateModelRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a model by ID<br/>
        /// Updates the mutable fields of a model and returns the updated model. Renaming does not change the model ID, endpoints, or deployments. Pushes that still use the old model_name create another model or target a model that now uses that name, so update config.yaml after renaming.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "my-model"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ModelV1>> EditModelsByModelIdAsResponseAsync(
            string modelId,

            global::Baseten.UpdateModelRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a model by ID<br/>
        /// Updates the mutable fields of a model and returns the updated model. Renaming does not change the model ID, endpoints, or deployments. Pushes that still use the old model_name create another model or target a model that now uses that name, so update config.yaml after renaming.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="name">
        /// New name for the model, unique within its team. Renaming does not change the model ID, endpoints, or deployments. Pushes that still use the old model_name create another model or target a model that now uses that name, so update config.yaml after renaming.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.ModelV1> EditModelsByModelIdAsync(
            string modelId,
            string? name = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}