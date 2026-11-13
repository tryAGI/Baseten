#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates an identity provider<br/>
        /// Updates the fields you send. The provider and issuer can't change. Only organization admins can call this endpoint.
        /// </summary>
        /// <param name="identityProviderId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/access/identity_providers/{identity_provider_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "prod-eks"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.IdentityProviderV1> EditAccessIdentityProvidersByIdentityProviderIdAsync(
            string identityProviderId,

            global::Baseten.UpdateIdentityProviderRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an identity provider<br/>
        /// Updates the fields you send. The provider and issuer can't change. Only organization admins can call this endpoint.
        /// </summary>
        /// <param name="identityProviderId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/access/identity_providers/{identity_provider_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "prod-eks"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.IdentityProviderV1>> EditAccessIdentityProvidersByIdentityProviderIdAsResponseAsync(
            string identityProviderId,

            global::Baseten.UpdateIdentityProviderRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates an identity provider<br/>
        /// Updates the fields you send. The provider and issuer can't change. Only organization admins can call this endpoint.
        /// </summary>
        /// <param name="identityProviderId"></param>
        /// <param name="name">
        /// Name, unique in the organization<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Description; null clears it<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.IdentityProviderV1> EditAccessIdentityProvidersByIdentityProviderIdAsync(
            string identityProviderId,
            string? name = default,
            string? description = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}