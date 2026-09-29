
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuditLogEventProviderConnectionDeletedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"PROVIDER_CONNECTION_DELETED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "PROVIDER_CONNECTION_DELETED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_connection_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderConnectionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventProviderConnectionDeletedV1" /> class.
        /// </summary>
        /// <param name="providerConnectionId"></param>
        /// <param name="provider"></param>
        /// <param name="secretName"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventProviderConnectionDeletedV1(
            string providerConnectionId,
            string provider,
            string secretName,
            string eventType = "PROVIDER_CONNECTION_DELETED")
        {
            this.EventType = eventType;
            this.ProviderConnectionId = providerConnectionId ?? throw new global::System.ArgumentNullException(nameof(providerConnectionId));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventProviderConnectionDeletedV1" /> class.
        /// </summary>
        public AuditLogEventProviderConnectionDeletedV1()
        {
        }

    }
}