
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LoopsUsageV1
    {
        /// <summary>
        /// Cost in dollars before credits
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
        /// Per-base-model usage breakdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("breakdown")]
        public global::System.Collections.Generic.IList<global::Baseten.LoopsBaseModelItemV1>? Breakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsUsageV1" /> class.
        /// </summary>
        /// <param name="subtotal">
        /// Cost in dollars before credits
        /// </param>
        /// <param name="creditsUsed">
        /// Credits applied in dollars
        /// </param>
        /// <param name="total">
        /// Total cost in dollars
        /// </param>
        /// <param name="breakdown">
        /// Per-base-model usage breakdown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsUsageV1(
            global::Baseten.AnyOf<double?, string> subtotal,
            global::Baseten.AnyOf<double?, string> creditsUsed,
            global::Baseten.AnyOf<double?, string> total,
            global::System.Collections.Generic.IList<global::Baseten.LoopsBaseModelItemV1>? breakdown)
        {
            this.Subtotal = subtotal;
            this.CreditsUsed = creditsUsed;
            this.Total = total;
            this.Breakdown = breakdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsUsageV1" /> class.
        /// </summary>
        public LoopsUsageV1()
        {
        }

    }
}