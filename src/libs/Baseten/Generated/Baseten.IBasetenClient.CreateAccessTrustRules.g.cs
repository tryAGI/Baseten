#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a trust rule<br/>
        /// Creates a rule that lets tokens from an identity provider act as a service account. Organization admins can create rules for any service account, team admins for their own team's. An organization API key manager key can't target organization accounts.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/access/trust_rules \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "models-main-deploy",<br/>
        ///   "identity_provider_id": "abcd1234",<br/>
        ///   "service_account_id": "wxyz5678",<br/>
        ///   "condition": "claims.repository_owner_id == '12345' &amp;&amp; claims.sub == 'repo:acme/models:ref:refs/heads/main'",<br/>
        ///   "audience": "https://api.baseten.co"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AccessTrustRuleV1> CreateAccessTrustRulesAsync(

            global::Baseten.CreateAccessTrustRuleRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a trust rule<br/>
        /// Creates a rule that lets tokens from an identity provider act as a service account. Organization admins can create rules for any service account, team admins for their own team's. An organization API key manager key can't target organization accounts.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/access/trust_rules \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "models-main-deploy",<br/>
        ///   "identity_provider_id": "abcd1234",<br/>
        ///   "service_account_id": "wxyz5678",<br/>
        ///   "condition": "claims.repository_owner_id == '12345' &amp;&amp; claims.sub == 'repo:acme/models:ref:refs/heads/main'",<br/>
        ///   "audience": "https://api.baseten.co"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.AccessTrustRuleV1>> CreateAccessTrustRulesAsResponseAsync(

            global::Baseten.CreateAccessTrustRuleRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a trust rule<br/>
        /// Creates a rule that lets tokens from an identity provider act as a service account. Organization admins can create rules for any service account, team admins for their own team's. An organization API key manager key can't target organization accounts.
        /// </summary>
        /// <param name="name">
        /// Name, unique in the organization. Can be changed later.
        /// </param>
        /// <param name="description">
        /// Optional description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="identityProviderId">
        /// Whose tokens the rule accepts. Can't be changed.
        /// </param>
        /// <param name="serviceAccountId">
        /// The service account its tokens act as. Can be changed later.
        /// </param>
        /// <param name="condition">
        /// A CEL expression over the token's `claims` that must evaluate to true. It must pin a specific `claims.sub` in a top-level `&amp;&amp;` clause, plus any provider-required checks. Up to 4,096 characters. Can be changed later.
        /// </param>
        /// <param name="audience">
        /// The token's `aud` must equal this, or contain it when `aud` is a list. Up to 1,024 characters. Can be changed later.
        /// </param>
        /// <param name="maxAccessTokenLifetimeSeconds">
        /// Longest lifetime of a token the rule issues, 60 to 3600 seconds. Can be changed later.<br/>
        /// Default Value: 3600
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AccessTrustRuleV1> CreateAccessTrustRulesAsync(
            string name,
            string identityProviderId,
            string serviceAccountId,
            string condition,
            string audience,
            string? description = default,
            int? maxAccessTokenLifetimeSeconds = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}