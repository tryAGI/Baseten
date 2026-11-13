
#nullable enable

namespace Baseten
{
    /// <summary>
    /// An identity provider was deleted.
    /// </summary>
    public sealed partial class AuditLogEventIdentityProviderDeletedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"IDENTITY_PROVIDER_DELETED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "IDENTITY_PROVIDER_DELETED";

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventIdentityProviderDeletedV1" /> class.
        /// </summary>
        /// <param name="identityProviderId"></param>
        /// <param name="name"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventIdentityProviderDeletedV1(
            string identityProviderId,
            string name,
            string eventType = "IDENTITY_PROVIDER_DELETED")
        {
            this.EventType = eventType;
            this.IdentityProviderId = identityProviderId ?? throw new global::System.ArgumentNullException(nameof(identityProviderId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventIdentityProviderDeletedV1" /> class.
        /// </summary>
        public AuditLogEventIdentityProviderDeletedV1()
        {
        }

    }
}