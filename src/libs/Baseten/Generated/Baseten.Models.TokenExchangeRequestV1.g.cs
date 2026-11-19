
#nullable enable

namespace Baseten
{
    /// <summary>
    /// An RFC 8693 token exchange request naming the trust rule to check as its audience.
    /// </summary>
    public sealed partial class TokenExchangeRequestV1
    {
        /// <summary>
        /// Always `urn:ietf:params:oauth:grant-type:token-exchange`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GrantType { get; set; }

        /// <summary>
        /// The identity provider's JWT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubjectToken { get; set; }

        /// <summary>
        /// `urn:ietf:params:oauth:token-type:jwt` or `urn:ietf:params:oauth:token-type:id_token`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_token_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SubjectTokenType { get; set; }

        /// <summary>
        /// ID of the trust rule to check the JWT against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Audience { get; set; }

        /// <summary>
        /// Optional; only `urn:ietf:params:oauth:token-type:access_token` is issued<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_token_type")]
        public string? RequestedTokenType { get; set; }

        /// <summary>
        /// Lifetime of the access token, in seconds. At most the rule's maximum.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token_lifetime_seconds")]
        public int? AccessTokenLifetimeSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenExchangeRequestV1" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenExchangeRequestV1(
            string grantType,
            string subjectToken,
            string subjectTokenType,
            string audience,
            string? requestedTokenType,
            int? accessTokenLifetimeSeconds)
        {
            this.GrantType = grantType ?? throw new global::System.ArgumentNullException(nameof(grantType));
            this.SubjectToken = subjectToken ?? throw new global::System.ArgumentNullException(nameof(subjectToken));
            this.SubjectTokenType = subjectTokenType ?? throw new global::System.ArgumentNullException(nameof(subjectTokenType));
            this.Audience = audience ?? throw new global::System.ArgumentNullException(nameof(audience));
            this.RequestedTokenType = requestedTokenType;
            this.AccessTokenLifetimeSeconds = accessTokenLifetimeSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenExchangeRequestV1" /> class.
        /// </summary>
        public TokenExchangeRequestV1()
        {
        }

    }
}