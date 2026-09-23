
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Server-side tool call usage for one day, provider, charge unit, and model.
    /// </summary>
    public sealed partial class ToolCallUsageBucketV1
    {
        /// <summary>
        /// UTC day the usage was recorded on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// Tool provider, such as exa or parallel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// Charge unit, as `&lt;provider&gt;/&lt;unit&gt;`. The unit is what the provider reported, or the tool name when it reported none. Its meaning varies by provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sku")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sku { get; set; }

        /// <summary>
        /// Model that made the tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Number of tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Calls { get; set; }

        /// <summary>
        /// Billable quantity in the provider's sku unit, summed over the calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Quantity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallUsageBucketV1" /> class.
        /// </summary>
        /// <param name="date">
        /// UTC day the usage was recorded on.
        /// </param>
        /// <param name="provider">
        /// Tool provider, such as exa or parallel.
        /// </param>
        /// <param name="sku">
        /// Charge unit, as `&lt;provider&gt;/&lt;unit&gt;`. The unit is what the provider reported, or the tool name when it reported none. Its meaning varies by provider.
        /// </param>
        /// <param name="model">
        /// Model that made the tool calls.
        /// </param>
        /// <param name="calls">
        /// Number of tool calls.
        /// </param>
        /// <param name="quantity">
        /// Billable quantity in the provider's sku unit, summed over the calls.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallUsageBucketV1(
            global::System.DateTime date,
            string provider,
            string sku,
            string model,
            int calls,
            double quantity)
        {
            this.Date = date;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Sku = sku ?? throw new global::System.ArgumentNullException(nameof(sku));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Calls = calls;
            this.Quantity = quantity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallUsageBucketV1" /> class.
        /// </summary>
        public ToolCallUsageBucketV1()
        {
        }

    }
}