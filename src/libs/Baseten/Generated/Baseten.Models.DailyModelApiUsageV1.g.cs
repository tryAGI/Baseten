
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DailyModelApiUsageV1
    {
        /// <summary>
        /// Date of the usage
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// Subtotal cost incurred on this date in dollars
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtotal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AnyOf<double?, string> Subtotal { get; set; }

        /// <summary>
        /// Number of input tokens on this date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// Number of output tokens on this date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Number of cached input tokens on this date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyModelApiUsageV1" /> class.
        /// </summary>
        /// <param name="date">
        /// Date of the usage
        /// </param>
        /// <param name="subtotal">
        /// Subtotal cost incurred on this date in dollars
        /// </param>
        /// <param name="inputTokens">
        /// Number of input tokens on this date
        /// </param>
        /// <param name="outputTokens">
        /// Number of output tokens on this date
        /// </param>
        /// <param name="cachedInputTokens">
        /// Number of cached input tokens on this date
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailyModelApiUsageV1(
            global::System.DateTime date,
            global::Baseten.AnyOf<double?, string> subtotal,
            int inputTokens,
            int outputTokens,
            int cachedInputTokens)
        {
            this.Date = date;
            this.Subtotal = subtotal;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CachedInputTokens = cachedInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyModelApiUsageV1" /> class.
        /// </summary>
        public DailyModelApiUsageV1()
        {
        }
    }
}