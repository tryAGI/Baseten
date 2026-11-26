#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Exchanges an identity provider's JWT for an access token<br/>
        /// Exchanges a JWT from your identity provider for a short-lived Baseten access token, as described in RFC 8693. Send no API key: the JWT is the credential. Name the trust rule to check the JWT against as the `audience`, and send the access token as `Authorization: Bearer` on later requests. Errors follow RFC 6749 section 5.2: a 400 response with an `error` of `invalid_request`, `unsupported_grant_type`, or `invalid_grant`. A well-formed request that fails a check always returns `invalid_grant`, whatever the check. Exchanges are rate limited per trust rule, per organization and per client IP. Over a limit, the response is a 429 with an `error` of `slow_down` and a `Retry-After` header.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.TokenExchangeResponseV1> CreateAuthTokenAsync(

            global::Baseten.TokenExchangeRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Exchanges an identity provider's JWT for an access token<br/>
        /// Exchanges a JWT from your identity provider for a short-lived Baseten access token, as described in RFC 8693. Send no API key: the JWT is the credential. Name the trust rule to check the JWT against as the `audience`, and send the access token as `Authorization: Bearer` on later requests. Errors follow RFC 6749 section 5.2: a 400 response with an `error` of `invalid_request`, `unsupported_grant_type`, or `invalid_grant`. A well-formed request that fails a check always returns `invalid_grant`, whatever the check. Exchanges are rate limited per trust rule, per organization and per client IP. Over a limit, the response is a 429 with an `error` of `slow_down` and a `Retry-After` header.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.TokenExchangeResponseV1>> CreateAuthTokenAsResponseAsync(

            global::Baseten.TokenExchangeRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Exchanges an identity provider's JWT for an access token<br/>
        /// Exchanges a JWT from your identity provider for a short-lived Baseten access token, as described in RFC 8693. Send no API key: the JWT is the credential. Name the trust rule to check the JWT against as the `audience`, and send the access token as `Authorization: Bearer` on later requests. Errors follow RFC 6749 section 5.2: a 400 response with an `error` of `invalid_request`, `unsupported_grant_type`, or `invalid_grant`. A well-formed request that fails a check always returns `invalid_grant`, whatever the check. Exchanges are rate limited per trust rule, per organization and per client IP. Over a limit, the response is a 429 with an `error` of `slow_down` and a `Retry-After` header.
        /// </summary>
        /// <param name="grantType">
        /// Always `urn:ietf:params:oauth:grant-type:token-exchange`
        /// </param>
        /// <param name="subjectToken">
        /// The identity provider's JWT
        /// </param>
        /// <param name="subjectTokenType">
        /// `urn:ietf:params:oauth:token-type:jwt` or `urn:ietf:params:oauth:token-type:id_token`
        /// </param>
        /// <param name="audience">
        /// ID of the trust rule to check the JWT against
        /// </param>
        /// <param name="requestedTokenType">
        /// Optional; only `urn:ietf:params:oauth:token-type:access_token` is issued<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="accessTokenLifetimeSeconds">
        /// Lifetime of the access token, in seconds. At most the rule's maximum.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.TokenExchangeResponseV1> CreateAuthTokenAsync(
            string grantType,
            string subjectToken,
            string subjectTokenType,
            string audience,
            string? requestedTokenType = default,
            int? accessTokenLifetimeSeconds = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}