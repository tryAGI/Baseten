
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Authentication code for a training job interactive session node.
    /// </summary>
    public sealed partial class AuthCodeV1
    {
        /// <summary>
        /// Unique identifier of the interactive session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Replica identifier in gXXrY format (e.g., 'g00r0' for group 0, replica 0).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReplicaId { get; set; }

        /// <summary>
        /// The device authentication code (e.g., '4F64-C0D9').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthCode { get; set; }

        /// <summary>
        /// URL where the user should enter the auth code (e.g., 'https://github.com/login/device').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthUrl { get; set; }

        /// <summary>
        /// When the auth code was generated, in ISO 8601 format.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_at")]
        public global::System.DateTime? GeneratedAt { get; set; }

        /// <summary>
        /// The name of the tunnel node.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tunnel_name")]
        public string? TunnelName { get; set; }

        /// <summary>
        /// When the session expires, in ISO 8601 format.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The working directory of the session.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("working_directory")]
        public string? WorkingDirectory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthCodeV1" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Unique identifier of the interactive session.
        /// </param>
        /// <param name="replicaId">
        /// Replica identifier in gXXrY format (e.g., 'g00r0' for group 0, replica 0).
        /// </param>
        /// <param name="authCode">
        /// The device authentication code (e.g., '4F64-C0D9').
        /// </param>
        /// <param name="authUrl">
        /// URL where the user should enter the auth code (e.g., 'https://github.com/login/device').
        /// </param>
        /// <param name="generatedAt">
        /// When the auth code was generated, in ISO 8601 format.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tunnelName">
        /// The name of the tunnel node.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="expiresAt">
        /// When the session expires, in ISO 8601 format.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="workingDirectory">
        /// The working directory of the session.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthCodeV1(
            string sessionId,
            string replicaId,
            string authCode,
            string authUrl,
            global::System.DateTime? generatedAt,
            string? tunnelName,
            global::System.DateTime? expiresAt,
            string? workingDirectory)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.ReplicaId = replicaId ?? throw new global::System.ArgumentNullException(nameof(replicaId));
            this.AuthCode = authCode ?? throw new global::System.ArgumentNullException(nameof(authCode));
            this.AuthUrl = authUrl ?? throw new global::System.ArgumentNullException(nameof(authUrl));
            this.GeneratedAt = generatedAt;
            this.TunnelName = tunnelName;
            this.ExpiresAt = expiresAt;
            this.WorkingDirectory = workingDirectory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthCodeV1" /> class.
        /// </summary>
        public AuthCodeV1()
        {
        }
    }
}