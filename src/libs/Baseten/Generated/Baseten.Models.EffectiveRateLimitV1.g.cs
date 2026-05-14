
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EffectiveRateLimitV1
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
        /// ID of the group in the hierarchy this limit is anchored to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceGroup { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectiveRateLimitV1" /> class.
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
        /// <param name="sourceGroup">
        /// ID of the group in the hierarchy this limit is anchored to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EffectiveRateLimitV1(
            global::Baseten.LimitTypeV1 type,
            global::Baseten.RateLimitUnitV1 unit,
            int threshold,
            string sourceGroup)
        {
            this.Type = type;
            this.Unit = unit;
            this.Threshold = threshold;
            this.SourceGroup = sourceGroup ?? throw new global::System.ArgumentNullException(nameof(sourceGroup));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectiveRateLimitV1" /> class.
        /// </summary>
        public EffectiveRateLimitV1()
        {
        }

    }
}