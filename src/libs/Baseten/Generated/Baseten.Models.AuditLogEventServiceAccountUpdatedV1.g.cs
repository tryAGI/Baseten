
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A service account was updated. Disabling or enabling it is a change to `disabled`.
    /// </summary>
    public sealed partial class AuditLogEventServiceAccountUpdatedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"SERVICE_ACCOUNT_UPDATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "SERVICE_ACCOUNT_UPDATED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The fields the update changed, keyed by field name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Baseten.AuditFieldChangeV1> Changes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventServiceAccountUpdatedV1" /> class.
        /// </summary>
        /// <param name="serviceAccountId"></param>
        /// <param name="name"></param>
        /// <param name="changes">
        /// The fields the update changed, keyed by field name.
        /// </param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventServiceAccountUpdatedV1(
            string serviceAccountId,
            string name,
            global::System.Collections.Generic.Dictionary<string, global::Baseten.AuditFieldChangeV1> changes,
            string eventType = "SERVICE_ACCOUNT_UPDATED")
        {
            this.EventType = eventType;
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Changes = changes ?? throw new global::System.ArgumentNullException(nameof(changes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventServiceAccountUpdatedV1" /> class.
        /// </summary>
        public AuditLogEventServiceAccountUpdatedV1()
        {
        }

    }
}