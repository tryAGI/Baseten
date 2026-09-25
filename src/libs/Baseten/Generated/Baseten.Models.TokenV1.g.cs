
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TokenV1
    {
        /// <summary>
        /// Short-lived bearer token for the sandbox API. Send it as Authorization: Bearer &lt;token&gt;.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Token expiry in ISO 8601 format. Tokens cannot be renewed; request a new one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenV1" /> class.
        /// </summary>
        /// <param name="token">
        /// Short-lived bearer token for the sandbox API. Send it as Authorization: Bearer &lt;token&gt;.
        /// </param>
        /// <param name="expiresAt">
        /// Token expiry in ISO 8601 format. Tokens cannot be renewed; request a new one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TokenV1(
            string token,
            global::System.DateTime expiresAt)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenV1" /> class.
        /// </summary>
        public TokenV1()
        {
        }

    }
}