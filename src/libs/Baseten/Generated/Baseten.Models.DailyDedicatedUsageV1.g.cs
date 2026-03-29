
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DailyDedicatedUsageV1
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
        /// Minutes used on this date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Minutes { get; set; }

        /// <summary>
        /// Number of inference requests on this date
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InferenceRequests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyDedicatedUsageV1" /> class.
        /// </summary>
        /// <param name="date">
        /// Date of the usage
        /// </param>
        /// <param name="subtotal">
        /// Subtotal cost incurred on this date in dollars
        /// </param>
        /// <param name="minutes">
        /// Minutes used on this date
        /// </param>
        /// <param name="inferenceRequests">
        /// Number of inference requests on this date
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DailyDedicatedUsageV1(
            global::System.DateTime date,
            global::Baseten.AnyOf<double?, string> subtotal,
            int minutes,
            int inferenceRequests)
        {
            this.Date = date;
            this.Subtotal = subtotal;
            this.Minutes = minutes;
            this.InferenceRequests = inferenceRequests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DailyDedicatedUsageV1" /> class.
        /// </summary>
        public DailyDedicatedUsageV1()
        {
        }
    }
}