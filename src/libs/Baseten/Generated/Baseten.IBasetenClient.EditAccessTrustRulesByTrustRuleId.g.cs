#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a trust rule<br/>
        /// Updates the fields you send. Changes apply to new exchanges only. The identity provider can't change.
        /// </summary>
        /// <param name="trustRuleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/access/trust_rules/{trust_rule_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "models-release-deploy"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AccessTrustRuleV1> EditAccessTrustRulesByTrustRuleIdAsync(
            string trustRuleId,

            global::Baseten.UpdateAccessTrustRuleRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a trust rule<br/>
        /// Updates the fields you send. Changes apply to new exchanges only. The identity provider can't change.
        /// </summary>
        /// <param name="trustRuleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/access/trust_rules/{trust_rule_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "models-release-deploy"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.AccessTrustRuleV1>> EditAccessTrustRulesByTrustRuleIdAsResponseAsync(
            string trustRuleId,

            global::Baseten.UpdateAccessTrustRuleRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a trust rule<br/>
        /// Updates the fields you send. Changes apply to new exchanges only. The identity provider can't change.
        /// </summary>
        /// <param name="trustRuleId"></param>
        /// <param name="name">
        /// Name, unique in the organization<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Description; null clears it<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="condition">
        /// A CEL expression over the token's `claims` that must evaluate to true. It must pin a specific `claims.sub` in a top-level `&amp;&amp;` clause, plus any provider-required checks. Up to 4,096 characters.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="audience">
        /// The token's `aud` must equal this, or contain it when `aud` is a list. Up to 1,024 characters.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="maxAccessTokenLifetimeSeconds">
        /// Longest lifetime of a token the rule issues, 60 to 3600 seconds. Tokens already issued keep their lifetime.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="serviceAccountId">
        /// Moves the rule to another service account. Tokens already issued keep the old account until they expire.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AccessTrustRuleV1> EditAccessTrustRulesByTrustRuleIdAsync(
            string trustRuleId,
            string? name = default,
            string? description = default,
            string? condition = default,
            string? audience = default,
            int? maxAccessTokenLifetimeSeconds = default,
            string? serviceAccountId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}