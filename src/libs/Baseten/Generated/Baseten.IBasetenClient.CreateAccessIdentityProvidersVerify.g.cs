#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Checks an identity provider before adding it<br/>
        /// Runs the checks that adding the identity provider runs, without adding it: the issuer's format, that the organization doesn't have it yet, and, for a provider with a per-customer issuer, that its signing keys can be fetched. A failed check returns 200 with `valid` false and the reason. Only organization admins can call this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/access/identity_providers/verify \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "predefined": {<br/>
        ///     "kind": "AWS_EKS",<br/>
        ///     "issuer_url": "https://oidc.eks.us-west-2.amazonaws.com/id/EXAMPLED539D4633E53DE1B71EXAMPLE"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.VerificationV1> CreateAccessIdentityProvidersVerifyAsync(

            global::Baseten.VerifyIdentityProviderRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Checks an identity provider before adding it<br/>
        /// Runs the checks that adding the identity provider runs, without adding it: the issuer's format, that the organization doesn't have it yet, and, for a provider with a per-customer issuer, that its signing keys can be fetched. A failed check returns 200 with `valid` false and the reason. Only organization admins can call this endpoint.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/access/identity_providers/verify \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "predefined": {<br/>
        ///     "kind": "AWS_EKS",<br/>
        ///     "issuer_url": "https://oidc.eks.us-west-2.amazonaws.com/id/EXAMPLED539D4633E53DE1B71EXAMPLE"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.VerificationV1>> CreateAccessIdentityProvidersVerifyAsResponseAsync(

            global::Baseten.VerifyIdentityProviderRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Checks an identity provider before adding it<br/>
        /// Runs the checks that adding the identity provider runs, without adding it: the issuer's format, that the organization doesn't have it yet, and, for a provider with a per-customer issuer, that its signing keys can be fetched. A failed check returns 200 with `valid` false and the reason. Only organization admins can call this endpoint.
        /// </summary>
        /// <param name="predefined">
        /// The predefined provider to check, as you'd pass it when adding it
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.VerificationV1> CreateAccessIdentityProvidersVerifyAsync(
            global::Baseten.VerifyPredefinedIdentityProviderConfigV1 predefined,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}