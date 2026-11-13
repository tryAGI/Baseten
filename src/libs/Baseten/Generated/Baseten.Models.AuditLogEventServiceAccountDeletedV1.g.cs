
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A service account was deleted.
    /// </summary>
    public sealed partial class AuditLogEventServiceAccountDeletedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"SERVICE_ACCOUNT_DELETED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "SERVICE_ACCOUNT_DELETED";

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventServiceAccountDeletedV1" /> class.
        /// </summary>
        /// <param name="serviceAccountId"></param>
        /// <param name="name"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventServiceAccountDeletedV1(
            string serviceAccountId,
            string name,
            string eventType = "SERVICE_ACCOUNT_DELETED")
        {
            this.EventType = eventType;
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventServiceAccountDeletedV1" /> class.
        /// </summary>
        public AuditLogEventServiceAccountDeletedV1()
        {
        }

    }
}