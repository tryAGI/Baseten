
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A complete rule to create or replace.
    /// </summary>
    public sealed partial class TrafficRoutingRuleUpsertV1
    {
        /// <summary>
        /// Omit to create a rule, or pass an existing rule's ID to replace it. A replace can't change the target: delete the rule and create a new one instead.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Rule type. A shadow rule sends a copy of the environment's traffic to its target.
        /// </summary>
        /// <default>"SHADOW"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "SHADOW";

        /// <summary>
        /// Where the rule sends traffic. Exactly one target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrafficRoutingTargetUpsertV1> Targets { get; set; }

        /// <summary>
        /// Percentage of the environment's traffic to shadow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent_traffic")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PercentTraffic { get; set; }

        /// <summary>
        /// When the rule stops, in ISO 8601 format with a timezone, at most 7 days out
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
        /// Initializes a new instance of the <see cref="TrafficRoutingRuleUpsertV1" /> class.
        /// </summary>
        /// <param name="targets">
        /// Where the rule sends traffic. Exactly one target.
        /// </param>
        /// <param name="percentTraffic">
        /// Percentage of the environment's traffic to shadow
        /// </param>
        /// <param name="expiresAt">
        /// When the rule stops, in ISO 8601 format with a timezone, at most 7 days out
        /// </param>
        /// <param name="samplingMode">
        /// How requests are picked for shadowing
        /// </param>
        /// <param name="propagateClientCancellation">
        /// Whether a shadow request is cancelled when the original client disconnects
        /// </param>
        /// <param name="id">
        /// Omit to create a rule, or pass an existing rule's ID to replace it. A replace can't change the target: delete the rule and create a new one instead.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Rule type. A shadow rule sends a copy of the environment's traffic to its target.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrafficRoutingRuleUpsertV1(
            global::System.Collections.Generic.IList<global::Baseten.TrafficRoutingTargetUpsertV1> targets,
            int percentTraffic,
            global::System.DateTime expiresAt,
            global::Baseten.TrafficRoutingRuleShadowSamplingModeV1 samplingMode,
            bool propagateClientCancellation,
            string? id,
            string type = "SHADOW")
        {
            this.Id = id;
            this.Type = type;
            this.Targets = targets ?? throw new global::System.ArgumentNullException(nameof(targets));
            this.PercentTraffic = percentTraffic;
            this.ExpiresAt = expiresAt;
            this.SamplingMode = samplingMode;
            this.PropagateClientCancellation = propagateClientCancellation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficRoutingRuleUpsertV1" /> class.
        /// </summary>
        public TrafficRoutingRuleUpsertV1()
        {
        }

    }
}