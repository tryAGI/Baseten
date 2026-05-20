
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageSummaryRequestV1
    {
        /// <summary>
        /// Start date (ISO 8601, UTC). Earliest queryable: 2026-01-01.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDate { get; set; }

        /// <summary>
        /// End date in ISO 8601 format (UTC). Date range cannot exceed 31 days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSummaryRequestV1" /> class.
        /// </summary>
        /// <param name="startDate">
        /// Start date (ISO 8601, UTC). Earliest queryable: 2026-01-01.
        /// </param>
        /// <param name="endDate">
        /// End date in ISO 8601 format (UTC). Date range cannot exceed 31 days.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageSummaryRequestV1(
            global::System.DateTime startDate,
            global::System.DateTime endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSummaryRequestV1" /> class.
        /// </summary>
        public UsageSummaryRequestV1()
        {
        }

    }
}