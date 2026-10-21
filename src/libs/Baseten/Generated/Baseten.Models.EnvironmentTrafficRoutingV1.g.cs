
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnvironmentTrafficRoutingV1
    {
        /// <summary>
        /// The environment's active rules
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrafficRoutingRuleV1> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentTrafficRoutingV1" /> class.
        /// </summary>
        /// <param name="rules">
        /// The environment's active rules
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentTrafficRoutingV1(
            global::System.Collections.Generic.IList<global::Baseten.TrafficRoutingRuleV1> rules)
        {
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentTrafficRoutingV1" /> class.
        /// </summary>
        public EnvironmentTrafficRoutingV1()
        {
        }

    }
}