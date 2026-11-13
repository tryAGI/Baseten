
#nullable enable

namespace Baseten
{
    /// <summary>
    /// An identity provider was added.
    /// </summary>
    public sealed partial class AuditLogEventIdentityProviderCreatedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"IDENTITY_PROVIDER_CREATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "IDENTITY_PROVIDER_CREATED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity_provider_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IdentityProviderId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Null when the provider was added without one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The provider's settings, as the identity provider resource returns them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predefined")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AuditLogEventPredefinedIdentityProviderConfigV1 Predefined { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventIdentityProviderCreatedV1" /> class.
        /// </summary>
        /// <param name="identityProviderId"></param>
        /// <param name="name"></param>
        /// <param name="predefined">
        /// The provider's settings, as the identity provider resource returns them.
        /// </param>
        /// <param name="description">
        /// Null when the provider was added without one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventIdentityProviderCreatedV1(
            string identityProviderId,
            string name,
            global::Baseten.AuditLogEventPredefinedIdentityProviderConfigV1 predefined,
            string? description,
            string eventType = "IDENTITY_PROVIDER_CREATED")
        {
            this.EventType = eventType;
            this.IdentityProviderId = identityProviderId ?? throw new global::System.ArgumentNullException(nameof(identityProviderId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Predefined = predefined ?? throw new global::System.ArgumentNullException(nameof(predefined));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventIdentityProviderCreatedV1" /> class.
        /// </summary>
        public AuditLogEventIdentityProviderCreatedV1()
        {
        }

    }
}