
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Where the custom identity provider's signing keys are.
    /// </summary>
    public sealed partial class RequestIdentityProviderJwksV1
    {
        /// <summary>
        /// `DISCOVERY` reads the issuer's `/.well-known/openid-configuration` and follows its `jwks_uri`, re-reading it as keys are refreshed. `EXPLICIT_URL` fetches `url`. `INLINE` uses `keys`, for an issuer Baseten can't reach; update them when they rotate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.IdentityProviderJwksTypeV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.IdentityProviderJwksTypeV1 Type { get; set; }

        /// <summary>
        /// The JWK Set URL, for `EXPLICIT_URL` only: https on port 443, without a query, returning `application/json` or `application/jwk-set+json`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Public RSA or EC keys as JWKs, each with a different string `kid`, for `INLINE` only. Up to 10.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        public global::System.Collections.Generic.IList<object>? Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestIdentityProviderJwksV1" /> class.
        /// </summary>
        /// <param name="type">
        /// `DISCOVERY` reads the issuer's `/.well-known/openid-configuration` and follows its `jwks_uri`, re-reading it as keys are refreshed. `EXPLICIT_URL` fetches `url`. `INLINE` uses `keys`, for an issuer Baseten can't reach; update them when they rotate.
        /// </param>
        /// <param name="url">
        /// The JWK Set URL, for `EXPLICIT_URL` only: https on port 443, without a query, returning `application/json` or `application/jwk-set+json`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="keys">
        /// Public RSA or EC keys as JWKs, each with a different string `kid`, for `INLINE` only. Up to 10.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestIdentityProviderJwksV1(
            global::Baseten.IdentityProviderJwksTypeV1 type,
            string? url,
            global::System.Collections.Generic.IList<object>? keys)
        {
            this.Type = type;
            this.Url = url;
            this.Keys = keys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestIdentityProviderJwksV1" /> class.
        /// </summary>
        public RequestIdentityProviderJwksV1()
        {
        }

    }
}