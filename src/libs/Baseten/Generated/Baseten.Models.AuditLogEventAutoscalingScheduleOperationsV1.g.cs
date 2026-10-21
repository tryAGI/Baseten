
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The autoscaling schedule changes a request asked for. Not itself a union payload.
    /// </summary>
    public sealed partial class AuditLogEventAutoscalingScheduleOperationsV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AuditLogEventAutoscalingScheduleUpsertV1> Schedules { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_schedule_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DeleteScheduleIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventAutoscalingScheduleOperationsV1" /> class.
        /// </summary>
        /// <param name="schedules"></param>
        /// <param name="deleteScheduleIds"></param>
        /// <param name="timezone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventAutoscalingScheduleOperationsV1(
            global::System.Collections.Generic.IList<global::Baseten.AuditLogEventAutoscalingScheduleUpsertV1> schedules,
            global::System.Collections.Generic.IList<string> deleteScheduleIds,
            string? timezone)
        {
            this.Timezone = timezone;
            this.Schedules = schedules ?? throw new global::System.ArgumentNullException(nameof(schedules));
            this.DeleteScheduleIds = deleteScheduleIds ?? throw new global::System.ArgumentNullException(nameof(deleteScheduleIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventAutoscalingScheduleOperationsV1" /> class.
        /// </summary>
        public AuditLogEventAutoscalingScheduleOperationsV1()
        {
        }

    }
}