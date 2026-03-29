
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DedicatedItemV1
    {
        /// <summary>
        /// The model deployment resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billable_resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.BillableResourceV1 BillableResource { get; set; }

        /// <summary>
        /// Subtotal cost in dollars for this billable resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtotal")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AnyOf<double?, string> Subtotal { get; set; }

        /// <summary>
        /// Total minutes used for this billable resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Minutes { get; set; }

        /// <summary>
        /// Total inference requests for this billable resource
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InferenceRequests { get; set; }

        /// <summary>
        /// Daily usage breakdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily")]
        public global::System.Collections.Generic.IList<global::Baseten.DailyDedicatedUsageV1>? Daily { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DedicatedItemV1" /> class.
        /// </summary>
        /// <param name="billableResource">
        /// The model deployment resource
        /// </param>
        /// <param name="subtotal">
        /// Subtotal cost in dollars for this billable resource
        /// </param>
        /// <param name="minutes">
        /// Total minutes used for this billable resource
        /// </param>
        /// <param name="inferenceRequests">
        /// Total inference requests for this billable resource
        /// </param>
        /// <param name="daily">
        /// Daily usage breakdown
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DedicatedItemV1(
            global::Baseten.BillableResourceV1 billableResource,
            global::Baseten.AnyOf<double?, string> subtotal,
            int minutes,
            int inferenceRequests,
            global::System.Collections.Generic.IList<global::Baseten.DailyDedicatedUsageV1>? daily)
        {
            this.BillableResource = billableResource ?? throw new global::System.ArgumentNullException(nameof(billableResource));
            this.Subtotal = subtotal;
            this.Minutes = minutes;
            this.InferenceRequests = inferenceRequests;
            this.Daily = daily;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DedicatedItemV1" /> class.
        /// </summary>
        public DedicatedItemV1()
        {
        }
    }
}