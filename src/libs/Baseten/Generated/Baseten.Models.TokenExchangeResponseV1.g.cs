
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TokenExchangeResponseV1
    {
        /// <summary>
        /// Send as `Authorization: Bearer`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccessToken { get; set; }

        /// <summary>
        /// Always `urn:ietf:params:oauth:token-type:access_token`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issued_token_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuedTokenType { get; set; }

        /// <summary>
        /// Always `Bearer`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TokenType { get; set; }

        /// <summary>
        /// Seconds until the access token expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpiresIn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenExchangeResponseV1" /> class.
        /// </summary>
        /// <param name="accessToken">
        /// Send as `Authorization: Bearer`
        /// </param>
        /// <param name="issuedTokenType">
        /// Always `urn:ietf:params:oauth:token-type:access_token`
        /// </param>
        /// <param name="tokenType">
        /// Always `Bearer`
        /// </param>
        /// <param name="expiresIn">
        /// Seconds until the access token expires
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenExchangeResponseV1(
            string accessToken,
            string issuedTokenType,
            string tokenType,
            int expiresIn)
        {
            this.AccessToken = accessToken ?? throw new global::System.ArgumentNullException(nameof(accessToken));
            this.IssuedTokenType = issuedTokenType ?? throw new global::System.ArgumentNullException(nameof(issuedTokenType));
            this.TokenType = tokenType ?? throw new global::System.ArgumentNullException(nameof(tokenType));
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenExchangeResponseV1" /> class.
        /// </summary>
        public TokenExchangeResponseV1()
        {
        }

    }
}