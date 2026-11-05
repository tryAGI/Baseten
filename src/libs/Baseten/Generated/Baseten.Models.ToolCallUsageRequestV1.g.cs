
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
        /// Return only usage for these teams, repeated once per team. Defaults to all teams you can manage. An unauthorized team ID causes a 403 response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_ids")]
        public global::System.Collections.Generic.IList<string>? TeamIds { get; set; }

        /// <summary>
        /// Pass TEAM to split daily rows by team. Defaults to aggregating across teams.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<global::Baseten.ToolCallUsageDimensionV1>? GroupBy { get; set; }

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
        /// <param name="teamIds">
        /// Return only usage for these teams, repeated once per team. Defaults to all teams you can manage. An unauthorized team ID causes a 403 response.
        /// </param>
        /// <param name="groupBy">
        /// Pass TEAM to split daily rows by team. Defaults to aggregating across teams.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallUsageRequestV1(
            global::System.DateTime startDate,
            global::System.DateTime? endDate,
            global::System.Collections.Generic.IList<string>? teamIds,
            global::System.Collections.Generic.IList<global::Baseten.ToolCallUsageDimensionV1>? groupBy)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.TeamIds = teamIds;
            this.GroupBy = groupBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallUsageRequestV1" /> class.
        /// </summary>
        public ToolCallUsageRequestV1()
        {
        }

    }
}