
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVolumeTokenResponseV1
    {
        /// <summary>
        /// Volume access token. Pass as a bearer token to the volume APIs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Token expiry in ISO 8601 format. Tokens cannot be renewed; exchange again for a fresh token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Effective capabilities granted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.VolumeTokenScopeV1> Scopes { get; set; }

        /// <summary>
        /// Effective namespaces granted, in canonical lowercase form.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Namespaces { get; set; }

        /// <summary>
        /// Effective volume names granted, in canonical lowercase form.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Volumes { get; set; }

        /// <summary>
        /// Base URL of the volume API this token authenticates against. Null when the environment does not expose a public volume API yet.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bdn_endpoint")]
        public string? BdnEndpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVolumeTokenResponseV1" /> class.
        /// </summary>
        /// <param name="token">
        /// Volume access token. Pass as a bearer token to the volume APIs.
        /// </param>
        /// <param name="expiresAt">
        /// Token expiry in ISO 8601 format. Tokens cannot be renewed; exchange again for a fresh token.
        /// </param>
        /// <param name="scopes">
        /// Effective capabilities granted.
        /// </param>
        /// <param name="namespaces">
        /// Effective namespaces granted, in canonical lowercase form.
        /// </param>
        /// <param name="volumes">
        /// Effective volume names granted, in canonical lowercase form.
        /// </param>
        /// <param name="bdnEndpoint">
        /// Base URL of the volume API this token authenticates against. Null when the environment does not expose a public volume API yet.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVolumeTokenResponseV1(
            string token,
            global::System.DateTime expiresAt,
            global::System.Collections.Generic.IList<global::Baseten.VolumeTokenScopeV1> scopes,
            global::System.Collections.Generic.IList<string> namespaces,
            global::System.Collections.Generic.IList<string> volumes,
            string? bdnEndpoint)
        {
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.ExpiresAt = expiresAt;
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.Namespaces = namespaces ?? throw new global::System.ArgumentNullException(nameof(namespaces));
            this.Volumes = volumes ?? throw new global::System.ArgumentNullException(nameof(volumes));
            this.BdnEndpoint = bdnEndpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVolumeTokenResponseV1" /> class.
        /// </summary>
        public CreateVolumeTokenResponseV1()
        {
        }

    }
}