
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DedicatedUsageV1
    {
        /// <summary>
        /// Subtotal cost in dollars after applying credits used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtotal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AnyOf<double?, string> Subtotal { get; set; }

        /// <summary>
        /// Credits applied in dollars
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_used")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AnyOf<double?, string> CreditsUsed { get; set; }

        /// <summary>
        /// Total cost in dollars
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AnyOf<double?, string> Total { get; set; }

        /// <summary>
        /// Total minutes used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Minutes { get; set; }

        /// <summary>
        /// Per-deployment usage breakdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakdown")]
        public global::System.Collections.Generic.IList<global::Baseten.DedicatedItemV1>? Breakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DedicatedUsageV1" /> class.
        /// </summary>
        /// <param name="subtotal">
        /// Subtotal cost in dollars after applying credits used
        /// </param>
        /// <param name="creditsUsed">
        /// Credits applied in dollars
        /// </param>
        /// <param name="total">
        /// Total cost in dollars
        /// </param>
        /// <param name="minutes">
        /// Total minutes used
        /// </param>
        /// <param name="breakdown">
        /// Per-deployment usage breakdown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DedicatedUsageV1(
            global::Baseten.AnyOf<double?, string> subtotal,
            global::Baseten.AnyOf<double?, string> creditsUsed,
            global::Baseten.AnyOf<double?, string> total,
            int minutes,
            global::System.Collections.Generic.IList<global::Baseten.DedicatedItemV1>? breakdown)
        {
            this.Subtotal = subtotal;
            this.CreditsUsed = creditsUsed;
            this.Total = total;
            this.Minutes = minutes;
            this.Breakdown = breakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DedicatedUsageV1" /> class.
        /// </summary>
        public DedicatedUsageV1()
        {
        }
    }
}