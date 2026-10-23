
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Mutable preview configuration.
    /// </summary>
    public sealed partial class SandboxPreviewConfigurationV1
    {
        /// <summary>
        /// Whether the URL is reachable without a preview token. Defaults to false on creation; a PATCH without it keeps the current value.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// Headers added to every response served by the preview, for example CORS headers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? ResponseHeaders { get; set; }

        /// <summary>
        /// Headers added to every request forwarded to the sandbox, for example an Authorization header expected by the application. Responses return each name with the value "****", except a GET with show_secrets=true by a workspace administrator. Sending "****" back as a value returns 400. A PATCH replaces the whole set.<br/>
        /// Example: {"Authorization":"Bearer app-internal-token"}
        /// </summary>
        /// <example>{"Authorization":"Bearer app-internal-token"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? RequestHeaders { get; set; }

        /// <summary>
        /// Time at which the preview is deleted. Must be in the future.<br/>
        /// Example: 2026-10-19T12:00:00Z
        /// </summary>
        /// <example>2026-10-19T12:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPreviewConfigurationV1" /> class.
        /// </summary>
        /// <param name="public">
        /// Whether the URL is reachable without a preview token. Defaults to false on creation; a PATCH without it keeps the current value.<br/>
        /// Example: true
        /// </param>
        /// <param name="responseHeaders">
        /// Headers added to every response served by the preview, for example CORS headers.
        /// </param>
        /// <param name="requestHeaders">
        /// Headers added to every request forwarded to the sandbox, for example an Authorization header expected by the application. Responses return each name with the value "****", except a GET with show_secrets=true by a workspace administrator. Sending "****" back as a value returns 400. A PATCH replaces the whole set.<br/>
        /// Example: {"Authorization":"Bearer app-internal-token"}
        /// </param>
        /// <param name="expiresAt">
        /// Time at which the preview is deleted. Must be in the future.<br/>
        /// Example: 2026-10-19T12:00:00Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxPreviewConfigurationV1(
            bool? @public,
            global::System.Collections.Generic.Dictionary<string, string>? responseHeaders,
            global::System.Collections.Generic.Dictionary<string, string>? requestHeaders,
            global::System.DateTime? expiresAt)
        {
            this.Public = @public;
            this.ResponseHeaders = responseHeaders;
            this.RequestHeaders = requestHeaders;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxPreviewConfigurationV1" /> class.
        /// </summary>
        public SandboxPreviewConfigurationV1()
        {
        }

    }
}