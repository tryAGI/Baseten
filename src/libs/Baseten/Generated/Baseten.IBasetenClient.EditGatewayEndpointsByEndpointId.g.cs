#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Update a Gateway endpoint<br/>
        /// Updates the endpoint's provided mutable fields. If targets are provided, the full target list is replaced. Exactly one target is supported at this time.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/gateway/endpoints/{endpoint_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "slug": "baseten/mymodel-4",<br/>
        ///   "targets": [<br/>
        ///     {<br/>
        ///       "model_id": "3kZ9xqd",<br/>
        ///       "provider": "BASETEN",<br/>
        ///       "target_model": "custom/model-name"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.EndpointV1> EditGatewayEndpointsByEndpointIdAsync(
            string endpointId,

            global::Baseten.UpdateEndpointRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Gateway endpoint<br/>
        /// Updates the endpoint's provided mutable fields. If targets are provided, the full target list is replaced. Exactly one target is supported at this time.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/gateway/endpoints/{endpoint_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "slug": "baseten/mymodel-4",<br/>
        ///   "targets": [<br/>
        ///     {<br/>
        ///       "model_id": "3kZ9xqd",<br/>
        ///       "provider": "BASETEN",<br/>
        ///       "target_model": "custom/model-name"<br/>
        ///     }<br/>
        ///   ]<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.EndpointV1>> EditGatewayEndpointsByEndpointIdAsResponseAsync(
            string endpointId,

            global::Baseten.UpdateEndpointRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a Gateway endpoint<br/>
        /// Updates the endpoint's provided mutable fields. If targets are provided, the full target list is replaced. Exactly one target is supported at this time.
        /// </summary>
        /// <param name="endpointId"></param>
        /// <param name="slug">
        /// New globally-unique slug of the form '{org_prefix}/{name}'.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="targets">
        /// The endpoint's upstream targets. Exactly one target is supported at this time.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.EndpointV1> EditGatewayEndpointsByEndpointIdAsync(
            string endpointId,
            string? slug = default,
            global::System.Collections.Generic.IList<global::Baseten.EndpointTargetRequestV1>? targets = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}