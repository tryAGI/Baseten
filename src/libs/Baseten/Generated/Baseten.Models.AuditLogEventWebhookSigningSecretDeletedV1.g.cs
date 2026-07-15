
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A webhook signing secret was deleted.
    /// </summary>
    public sealed partial class AuditLogEventWebhookSigningSecretDeletedV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"WEBHOOK_SIGNING_SECRET_DELETED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "WEBHOOK_SIGNING_SECRET_DELETED";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_signing_secret_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookSigningSecretId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventWebhookSigningSecretDeletedV1" /> class.
        /// </summary>
        /// <param name="webhookSigningSecretId"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventWebhookSigningSecretDeletedV1(
            string webhookSigningSecretId,
            string eventType = "WEBHOOK_SIGNING_SECRET_DELETED")
        {
            this.EventType = eventType;
            this.WebhookSigningSecretId = webhookSigningSecretId ?? throw new global::System.ArgumentNullException(nameof(webhookSigningSecretId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventWebhookSigningSecretDeletedV1" /> class.
        /// </summary>
        public AuditLogEventWebhookSigningSecretDeletedV1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AuditLogEventWebhookSigningSecretDeletedV1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AuditLogEventWebhookSigningSecretDeletedV1 FromWebhookSigningSecretId(string webhookSigningSecretId)
        {
            return new AuditLogEventWebhookSigningSecretDeletedV1
            {
                WebhookSigningSecretId = webhookSigningSecretId,
            };
        }

    }
}