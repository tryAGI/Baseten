#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Checks a trust rule's condition and audience<br/>
        /// Runs the checks that creating or updating a trust rule runs on its condition and audience, without saving anything: that the condition compiles and pins the claims the identity provider requires. A failed check returns 200 with `valid` false and the reason.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/access/trust_rules/verify \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "identity_provider_id": "abcd1234",<br/>
        ///   "condition": "claims.repository_owner_id == '12345' &amp;&amp; claims.sub == 'repo:acme/models:ref:refs/heads/main'",<br/>
        ///   "audience": "https://api.baseten.co"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.VerificationV1> CreateAccessTrustRulesVerifyAsync(

            global::Baseten.VerifyAccessTrustRuleRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Checks a trust rule's condition and audience<br/>
        /// Runs the checks that creating or updating a trust rule runs on its condition and audience, without saving anything: that the condition compiles and pins the claims the identity provider requires. A failed check returns 200 with `valid` false and the reason.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/access/trust_rules/verify \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "identity_provider_id": "abcd1234",<br/>
        ///   "condition": "claims.repository_owner_id == '12345' &amp;&amp; claims.sub == 'repo:acme/models:ref:refs/heads/main'",<br/>
        ///   "audience": "https://api.baseten.co"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.VerificationV1>> CreateAccessTrustRulesVerifyAsResponseAsync(

            global::Baseten.VerifyAccessTrustRuleRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Checks a trust rule's condition and audience<br/>
        /// Runs the checks that creating or updating a trust rule runs on its condition and audience, without saving anything: that the condition compiles and pins the claims the identity provider requires. A failed check returns 200 with `valid` false and the reason.
        /// </summary>
        /// <param name="identityProviderId">
        /// The identity provider the rule is for, which decides the claims it must pin
        /// </param>
        /// <param name="condition">
        /// A CEL expression over the token's `claims` that must evaluate to true. It must pin a specific `claims.sub` in a top-level `&amp;&amp;` clause, plus any provider-required checks. Up to 4,096 characters.
        /// </param>
        /// <param name="audience">
        /// The token's `aud` must equal this, or contain it when `aud` is a list. Up to 1,024 characters.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.VerificationV1> CreateAccessTrustRulesVerifyAsync(
            string identityProviderId,
            string condition,
            string audience,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}