#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Adds an identity provider<br/>
        /// Adds an identity provider to the organization. For a provider with a per-customer issuer, the issuer must match the provider's format, and its signing keys are fetched before it's saved; a failure returns 422 with the reason. Each provider with a fixed issuer can be added once. Only organization admins can call this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/access/identity_providers \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "prod-eks",<br/>
        ///   "predefined": {<br/>
        ///     "kind": "AWS_EKS",<br/>
        ///     "issuer_url": "https://oidc.eks.us-west-2.amazonaws.com/id/EXAMPLED539D4633E53DE1B71EXAMPLE"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.IdentityProviderV1> CreateAccessIdentityProvidersAsync(

            global::Baseten.CreateIdentityProviderRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adds an identity provider<br/>
        /// Adds an identity provider to the organization. For a provider with a per-customer issuer, the issuer must match the provider's format, and its signing keys are fetched before it's saved; a failure returns 422 with the reason. Each provider with a fixed issuer can be added once. Only organization admins can call this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/access/identity_providers \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "prod-eks",<br/>
        ///   "predefined": {<br/>
        ///     "kind": "AWS_EKS",<br/>
        ///     "issuer_url": "https://oidc.eks.us-west-2.amazonaws.com/id/EXAMPLED539D4633E53DE1B71EXAMPLE"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.IdentityProviderV1>> CreateAccessIdentityProvidersAsResponseAsync(

            global::Baseten.CreateIdentityProviderRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Adds an identity provider<br/>
        /// Adds an identity provider to the organization. For a provider with a per-customer issuer, the issuer must match the provider's format, and its signing keys are fetched before it's saved; a failure returns 422 with the reason. Each provider with a fixed issuer can be added once. Only organization admins can call this endpoint.
        /// </summary>
        /// <param name="name">
        /// Name, unique in the organization. Defaults to the provider's display name, so pass one when adding a second issuer of the same provider.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Optional description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="predefined">
        /// The predefined provider to add
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.IdentityProviderV1> CreateAccessIdentityProvidersAsync(
            global::Baseten.CreatePredefinedIdentityProviderConfigV1 predefined,
            string? name = default,
            string? description = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}