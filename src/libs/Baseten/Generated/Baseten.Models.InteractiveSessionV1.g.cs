
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Representation of a training job interactive session.
    /// </summary>
    public sealed partial class InteractiveSessionV1
    {
        /// <summary>
        /// Unique identifier of the interactive session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// When the interactive session is created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Trigger { get; set; }

        /// <summary>
        /// Minutes before the session times out.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TimeoutMinutes { get; set; }

        /// <summary>
        /// The IDE client for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionProvider { get; set; }

        /// <summary>
        /// The authentication provider for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthProvider { get; set; }

        /// <summary>
        /// Pod name / node rank for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pod_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PodName { get; set; }

        /// <summary>
        /// When the session expires, in ISO 8601 format.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The tunnel name for the session.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tunnel_name")]
        public string? TunnelName { get; set; }

        /// <summary>
        /// The device authentication code.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_code")]
        public string? AuthCode { get; set; }

        /// <summary>
        /// URL where the user should enter the auth code.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_url")]
        public string? AuthUrl { get; set; }

        /// <summary>
        /// When the auth code was generated.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_code_generated_at")]
        public global::System.DateTime? AuthCodeGeneratedAt { get; set; }

        /// <summary>
        /// When the session was authenticated.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authenticated_at")]
        public global::System.DateTime? AuthenticatedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="InteractiveSessionV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the interactive session.
        /// </param>
        /// <param name="trigger">
        /// When the interactive session is created.
        /// </param>
        /// <param name="timeoutMinutes">
        /// Minutes before the session times out.
        /// </param>
        /// <param name="sessionProvider">
        /// The IDE client for the session.
        /// </param>
        /// <param name="authProvider">
        /// The authentication provider for the session.
        /// </param>
        /// <param name="podName">
        /// Pod name / node rank for the session.
        /// </param>
        /// <param name="expiresAt">
        /// When the session expires, in ISO 8601 format.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tunnelName">
        /// The tunnel name for the session.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="authCode">
        /// The device authentication code.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="authUrl">
        /// URL where the user should enter the auth code.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="authCodeGeneratedAt">
        /// When the auth code was generated.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="authenticatedAt">
        /// When the session was authenticated.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="workingDirectory">
        /// The working directory of the session.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InteractiveSessionV1(
            string id,
            string trigger,
            int timeoutMinutes,
            string sessionProvider,
            string authProvider,
            string podName,
            global::System.DateTime? expiresAt,
            string? tunnelName,
            string? authCode,
            string? authUrl,
            global::System.DateTime? authCodeGeneratedAt,
            global::System.DateTime? authenticatedAt,
            string? workingDirectory)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Trigger = trigger ?? throw new global::System.ArgumentNullException(nameof(trigger));
            this.TimeoutMinutes = timeoutMinutes;
            this.SessionProvider = sessionProvider ?? throw new global::System.ArgumentNullException(nameof(sessionProvider));
            this.AuthProvider = authProvider ?? throw new global::System.ArgumentNullException(nameof(authProvider));
            this.PodName = podName ?? throw new global::System.ArgumentNullException(nameof(podName));
            this.ExpiresAt = expiresAt;
            this.TunnelName = tunnelName;
            this.AuthCode = authCode;
            this.AuthUrl = authUrl;
            this.AuthCodeGeneratedAt = authCodeGeneratedAt;
            this.AuthenticatedAt = authenticatedAt;
            this.WorkingDirectory = workingDirectory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InteractiveSessionV1" /> class.
        /// </summary>
        public InteractiveSessionV1()
        {
        }
    }
}