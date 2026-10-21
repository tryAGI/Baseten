
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A traffic routing rule on an environment.
    /// </summary>
    public sealed partial class TrafficRoutingRuleV1
    {
        /// <summary>
        /// Unique identifier of the rule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Rule type. A shadow rule sends a copy of the environment's traffic to its target.
        /// </summary>
        /// <default>"SHADOW"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "SHADOW";

        /// <summary>
        /// Where the rule sends traffic. Empty if the target has been deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrafficRoutingTargetV1> Targets { get; set; }

        /// <summary>
        /// Percentage of the environment's traffic shadowed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent_traffic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PercentTraffic { get; set; }

        /// <summary>
        /// When the rule stops, in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// How requests are picked for shadowing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.TrafficRoutingRuleShadowSamplingModeV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.TrafficRoutingRuleShadowSamplingModeV1 SamplingMode { get; set; }

        /// <summary>
        /// Whether a shadow request is cancelled when the original client disconnects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("propagate_client_cancellation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PropagateClientCancellation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficRoutingRuleV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the rule
        /// </param>
        /// <param name="targets">
        /// Where the rule sends traffic. Empty if the target has been deleted.
        /// </param>
        /// <param name="percentTraffic">
        /// Percentage of the environment's traffic shadowed
        /// </param>
        /// <param name="expiresAt">
        /// When the rule stops, in ISO 8601 format
        /// </param>
        /// <param name="samplingMode">
        /// How requests are picked for shadowing
        /// </param>
        /// <param name="propagateClientCancellation">
        /// Whether a shadow request is cancelled when the original client disconnects
        /// </param>
        /// <param name="type">
        /// Rule type. A shadow rule sends a copy of the environment's traffic to its target.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficRoutingRuleV1(
            string id,
            global::System.Collections.Generic.IList<global::Baseten.TrafficRoutingTargetV1> targets,
            int percentTraffic,
            global::System.DateTime expiresAt,
            global::Baseten.TrafficRoutingRuleShadowSamplingModeV1 samplingMode,
            bool propagateClientCancellation,
            string type = "SHADOW")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
            this.PercentTraffic = percentTraffic;
            this.ExpiresAt = expiresAt;
            this.SamplingMode = samplingMode;
            this.PropagateClientCancellation = propagateClientCancellation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficRoutingRuleV1" /> class.
        /// </summary>
        public TrafficRoutingRuleV1()
        {
        }

    }
}