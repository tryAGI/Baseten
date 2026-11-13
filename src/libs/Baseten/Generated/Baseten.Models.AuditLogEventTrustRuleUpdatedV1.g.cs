
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A trust rule was updated.
    /// </summary>
    public sealed partial class AuditLogEventTrustRuleUpdatedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"TRUST_RULE_UPDATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "TRUST_RULE_UPDATED";

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
        /// Initializes a new instance of the <see cref="AuditLogEventTrustRuleUpdatedV1" /> class.
        /// </summary>
        /// <param name="trustRuleId"></param>
        /// <param name="name"></param>
        /// <param name="changes">
        /// The fields the update changed, keyed by field name.
        /// </param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventTrustRuleUpdatedV1(
            string trustRuleId,
            string name,
            global::System.Collections.Generic.Dictionary<string, global::Baseten.AuditFieldChangeV1> changes,
            string eventType = "TRUST_RULE_UPDATED")
        {
            this.EventType = eventType;
            this.TrustRuleId = trustRuleId ?? throw new global::System.ArgumentNullException(nameof(trustRuleId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Changes = changes ?? throw new global::System.ArgumentNullException(nameof(changes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventTrustRuleUpdatedV1" /> class.
        /// </summary>
        public AuditLogEventTrustRuleUpdatedV1()
        {
        }

    }
}