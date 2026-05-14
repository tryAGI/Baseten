
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageLimitV1
    {
        /// <summary>
        /// The type of the usage limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.LimitTypeV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.LimitTypeV1 Type { get; set; }

        /// <summary>
        /// The unit of the usage limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.UsageLimitUnitV1JsonConverter))]
        public global::Baseten.UsageLimitUnitV1 Unit { get; set; }

        /// <summary>
        /// The threshold for the usage limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Threshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimitV1" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the usage limit
        /// </param>
        /// <param name="threshold">
        /// The threshold for the usage limit
        /// </param>
        /// <param name="unit">
        /// The unit of the usage limit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageLimitV1(
            global::Baseten.LimitTypeV1 type,
            int threshold,
            global::Baseten.UsageLimitUnitV1 unit)
        {
            this.Type = type;
            this.Unit = unit;
            this.Threshold = threshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimitV1" /> class.
        /// </summary>
        public UsageLimitV1()
        {
        }

    }
}