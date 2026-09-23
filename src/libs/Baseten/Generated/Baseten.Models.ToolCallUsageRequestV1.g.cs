
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolCallUsageRequestV1
    {
        /// <summary>
        /// Inclusive UTC calendar day at the start of the query range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDate { get; set; }

        /// <summary>
        /// Exclusive UTC calendar day at the end of the query range. Defaults to the day after the current UTC date so current-day usage is included. The date range cannot exceed 90 days.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallUsageRequestV1" /> class.
        /// </summary>
        /// <param name="startDate">
        /// Inclusive UTC calendar day at the start of the query range.
        /// </param>
        /// <param name="endDate">
        /// Exclusive UTC calendar day at the end of the query range. Defaults to the day after the current UTC date so current-day usage is included. The date range cannot exceed 90 days.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallUsageRequestV1(
            global::System.DateTime startDate,
            global::System.DateTime? endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallUsageRequestV1" /> class.
        /// </summary>
        public ToolCallUsageRequestV1()
        {
        }

    }
}