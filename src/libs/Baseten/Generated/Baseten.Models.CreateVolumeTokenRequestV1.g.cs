
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateVolumeTokenRequestV1
    {
        /// <summary>
        /// Capabilities the token grants, at least one. Requesting PUSH or TAG requires organization-level model management permission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.VolumeTokenScopeV1> Scopes { get; set; }

        /// <summary>
        /// Volume namespaces the token is limited to, lowercase ASCII, at least one. Pass only the namespaces the operation needs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Namespaces { get; set; }

        /// <summary>
        /// Volume names the token is limited to, lowercase ASCII, exact names only, at least one. The limit applies to every requested scope in every requested namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Volumes { get; set; }

        /// <summary>
        /// Optional client-chosen identifier, at most 128 printable ASCII characters. Echoed into server logs to link the issued token to a client operation.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("correlation_id")]
        public string? CorrelationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVolumeTokenRequestV1" /> class.
        /// </summary>
        /// <param name="scopes">
        /// Capabilities the token grants, at least one. Requesting PUSH or TAG requires organization-level model management permission.
        /// </param>
        /// <param name="namespaces">
        /// Volume namespaces the token is limited to, lowercase ASCII, at least one. Pass only the namespaces the operation needs.
        /// </param>
        /// <param name="volumes">
        /// Volume names the token is limited to, lowercase ASCII, exact names only, at least one. The limit applies to every requested scope in every requested namespace.
        /// </param>
        /// <param name="correlationId">
        /// Optional client-chosen identifier, at most 128 printable ASCII characters. Echoed into server logs to link the issued token to a client operation.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVolumeTokenRequestV1(
            global::System.Collections.Generic.IList<global::Baseten.VolumeTokenScopeV1> scopes,
            global::System.Collections.Generic.IList<string> namespaces,
            global::System.Collections.Generic.IList<string> volumes,
            string? correlationId)
        {
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.Namespaces = namespaces ?? throw new global::System.ArgumentNullException(nameof(namespaces));
            this.Volumes = volumes ?? throw new global::System.ArgumentNullException(nameof(volumes));
            this.CorrelationId = correlationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVolumeTokenRequestV1" /> class.
        /// </summary>
        public CreateVolumeTokenRequestV1()
        {
        }

    }
}