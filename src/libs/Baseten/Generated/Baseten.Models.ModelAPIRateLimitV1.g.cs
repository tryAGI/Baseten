
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ModelAPIRateLimitV1
    {
        /// <summary>
        /// The type of the rate limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.LimitTypeV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.LimitTypeV1 Type { get; set; }

        /// <summary>
        /// The unit of the rate limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.RateLimitUnitV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.RateLimitUnitV1 Unit { get; set; }

        /// <summary>
        /// The threshold for the rate limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Threshold { get; set; }

        /// <summary>
        /// Whether this limit uses the organization-wide pool. The threshold is the effective limit, including any adaptive grant.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_pooled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPooled { get; set; }

        /// <summary>
        /// Service tier the rate limit applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.ModelAPIServiceTierV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.ModelAPIServiceTierV1 ServiceTier { get; set; }

        /// <summary>
        /// Configured baseline threshold for the rate limit, before any adaptive increase. Equal to `threshold` when no adaptive increase is in effect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BaselineThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAPIRateLimitV1" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the rate limit
        /// </param>
        /// <param name="unit">
        /// The unit of the rate limit
        /// </param>
        /// <param name="threshold">
        /// The threshold for the rate limit
        /// </param>
        /// <param name="isPooled">
        /// Whether this limit uses the organization-wide pool. The threshold is the effective limit, including any adaptive grant.
        /// </param>
        /// <param name="serviceTier">
        /// Service tier the rate limit applies to.
        /// </param>
        /// <param name="baselineThreshold">
        /// Configured baseline threshold for the rate limit, before any adaptive increase. Equal to `threshold` when no adaptive increase is in effect.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelAPIRateLimitV1(
            global::Baseten.LimitTypeV1 type,
            global::Baseten.RateLimitUnitV1 unit,
            int threshold,
            bool isPooled,
            global::Baseten.ModelAPIServiceTierV1 serviceTier,
            int baselineThreshold)
        {
            this.Type = type;
            this.Unit = unit;
            this.Threshold = threshold;
            this.IsPooled = isPooled;
            this.ServiceTier = serviceTier;
            this.BaselineThreshold = baselineThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAPIRateLimitV1" /> class.
        /// </summary>
        public ModelAPIRateLimitV1()
        {
        }

    }
}