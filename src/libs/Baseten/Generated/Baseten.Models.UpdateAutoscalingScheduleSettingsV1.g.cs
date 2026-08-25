
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Partial mutation of an environment's autoscaling schedule collection.
    /// </summary>
    public sealed partial class UpdateAutoscalingScheduleSettingsV1
    {
        /// <summary>
        /// IANA timezone shared by the resulting collection. Omission preserves the current timezone; null is allowed only when deleting every schedule.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Complete schedules to create or replace. Existing schedules omitted from this list are unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedules")]
        public global::System.Collections.Generic.IList<global::Baseten.SchedulesItem2>? Schedules { get; set; }

        /// <summary>
        /// Stable identifiers of schedules to delete. To clear all schedules, include every existing schedule identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_schedules")]
        public global::System.Collections.Generic.IList<string>? DeleteSchedules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAutoscalingScheduleSettingsV1" /> class.
        /// </summary>
        /// <param name="timezone">
        /// IANA timezone shared by the resulting collection. Omission preserves the current timezone; null is allowed only when deleting every schedule.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="schedules">
        /// Complete schedules to create or replace. Existing schedules omitted from this list are unchanged.
        /// </param>
        /// <param name="deleteSchedules">
        /// Stable identifiers of schedules to delete. To clear all schedules, include every existing schedule identifier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAutoscalingScheduleSettingsV1(
            string? timezone,
            global::System.Collections.Generic.IList<global::Baseten.SchedulesItem2>? schedules,
            global::System.Collections.Generic.IList<string>? deleteSchedules)
        {
            this.Timezone = timezone;
            this.Schedules = schedules;
            this.DeleteSchedules = deleteSchedules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAutoscalingScheduleSettingsV1" /> class.
        /// </summary>
        public UpdateAutoscalingScheduleSettingsV1()
        {
        }

    }
}