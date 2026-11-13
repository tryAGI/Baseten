
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A trust rule was deleted.
    /// </summary>
    public sealed partial class AuditLogEventTrustRuleDeletedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"TRUST_RULE_DELETED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "TRUST_RULE_DELETED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trust_rule_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrustRuleId { get; set; }

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
        /// Initializes a new instance of the <see cref="AuditLogEventTrustRuleDeletedV1" /> class.
        /// </summary>
        /// <param name="trustRuleId"></param>
        /// <param name="name"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventTrustRuleDeletedV1(
            string trustRuleId,
            string name,
            string eventType = "TRUST_RULE_DELETED")
        {
            this.EventType = eventType;
            this.TrustRuleId = trustRuleId ?? throw new global::System.ArgumentNullException(nameof(trustRuleId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventTrustRuleDeletedV1" /> class.
        /// </summary>
        public AuditLogEventTrustRuleDeletedV1()
        {
        }

    }
}