#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Create a Gateway endpoint<br/>
        /// Provisions an endpoint for the given slug and its upstream target. Exactly one target is supported at this time. The slug's prefix must be one your organization owns.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/gateway/endpoints \<br/>
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
        global::System.Threading.Tasks.Task<global::Baseten.EndpointV1> CreateGatewayEndpointsAsync(

            global::Baseten.CreateEndpointRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Gateway endpoint<br/>
        /// Provisions an endpoint for the given slug and its upstream target. Exactly one target is supported at this time. The slug's prefix must be one your organization owns.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/gateway/endpoints \<br/>
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
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.EndpointV1>> CreateGatewayEndpointsAsResponseAsync(

            global::Baseten.CreateEndpointRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Gateway endpoint<br/>
        /// Provisions an endpoint for the given slug and its upstream target. Exactly one target is supported at this time. The slug's prefix must be one your organization owns.
        /// </summary>
        /// <param name="slug">
        /// Globally-unique slug of the form '{org_prefix}/{name}'.
        /// </param>
        /// <param name="targets">
        /// The endpoint's upstream targets. Exactly one target is supported at this time.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.EndpointV1> CreateGatewayEndpointsAsync(
            string slug,
            global::System.Collections.Generic.IList<global::Baseten.EndpointTargetRequestV1> targets,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}