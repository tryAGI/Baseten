
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Partial update of an environment's traffic routing rules.
    /// </summary>
    public sealed partial class UpdateTrafficRoutingSettingsV1
    {
        /// <summary>
        /// Complete rules to create or replace. Existing rules omitted here are unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::Baseten.TrafficRoutingRuleUpsertV1>? Rules { get; set; }

        /// <summary>
        /// IDs of rules to delete
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_rules")]
        public global::System.Collections.Generic.IList<string>? DeleteRules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTrafficRoutingSettingsV1" /> class.
        /// </summary>
        /// <param name="rules">
        /// Complete rules to create or replace. Existing rules omitted here are unchanged.
        /// </param>
        /// <param name="deleteRules">
        /// IDs of rules to delete
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateTrafficRoutingSettingsV1(
            global::System.Collections.Generic.IList<global::Baseten.TrafficRoutingRuleUpsertV1>? rules,
            global::System.Collections.Generic.IList<string>? deleteRules)
        {
            this.Rules = rules;
            this.DeleteRules = deleteRules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTrafficRoutingSettingsV1" /> class.
        /// </summary>
        public UpdateTrafficRoutingSettingsV1()
        {
        }

    }
}