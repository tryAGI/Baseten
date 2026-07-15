
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A webhook signing secret was rotated.
    /// </summary>
    public sealed partial class AuditLogEventWebhookSigningSecretRotatedV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"WEBHOOK_SIGNING_SECRET_ROTATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "WEBHOOK_SIGNING_SECRET_ROTATED";

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
        /// Initializes a new instance of the <see cref="AuditLogEventWebhookSigningSecretRotatedV1" /> class.
        /// </summary>
        /// <param name="webhookSigningSecretId"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventWebhookSigningSecretRotatedV1(
            string webhookSigningSecretId,
            string eventType = "WEBHOOK_SIGNING_SECRET_ROTATED")
        {
            this.EventType = eventType;
            this.WebhookSigningSecretId = webhookSigningSecretId ?? throw new global::System.ArgumentNullException(nameof(webhookSigningSecretId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventWebhookSigningSecretRotatedV1" /> class.
        /// </summary>
        public AuditLogEventWebhookSigningSecretRotatedV1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AuditLogEventWebhookSigningSecretRotatedV1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AuditLogEventWebhookSigningSecretRotatedV1 FromWebhookSigningSecretId(string webhookSigningSecretId)
        {
            return new AuditLogEventWebhookSigningSecretRotatedV1
            {
                WebhookSigningSecretId = webhookSigningSecretId,
            };
        }

    }
}