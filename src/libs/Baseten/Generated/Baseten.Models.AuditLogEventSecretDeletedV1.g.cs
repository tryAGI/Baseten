
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A secret was deleted.
    /// </summary>
    public sealed partial class AuditLogEventSecretDeletedV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"SECRET_DELETED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "SECRET_DELETED";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SecretId { get; set; }

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
        /// Initializes a new instance of the <see cref="AuditLogEventSecretDeletedV1" /> class.
        /// </summary>
        /// <param name="secretId"></param>
        /// <param name="secretName"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventSecretDeletedV1(
            string secretId,
            string secretName,
            string eventType = "SECRET_DELETED")
        {
            this.EventType = eventType;
            this.SecretId = secretId ?? throw new global::System.ArgumentNullException(nameof(secretId));
            this.SecretName = secretName ?? throw new global::System.ArgumentNullException(nameof(secretName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventSecretDeletedV1" /> class.
        /// </summary>
        public AuditLogEventSecretDeletedV1()
        {
        }

    }
}