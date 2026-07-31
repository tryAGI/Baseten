
#nullable enable

namespace Baseten
{
    /// <summary>
    /// What an autoscaling change did to one schedule, and the schedule on either side of it.<br/>
    /// `previous` is null on a create, `current` on a delete, and an unchanged schedule carries only<br/>
    /// `current`. Not itself a payload in the discriminated union.
    /// </summary>
    public sealed partial class AuditLogEventAutoscalingScheduleChangeV1
    {
        /// <summary>
        /// What an autoscaling change did to one schedule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AuditLogEventAutoscalingScheduleActionV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AuditLogEventAutoscalingScheduleActionV1 Action { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScheduleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous")]
        public global::Baseten.AuditLogEventAutoscalingScheduleSettingsV1? Previous { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current")]
        public global::Baseten.AuditLogEventAutoscalingScheduleSettingsV1? Current { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventAutoscalingScheduleChangeV1" /> class.
        /// </summary>
        /// <param name="action">
        /// What an autoscaling change did to one schedule.
        /// </param>
        /// <param name="scheduleId"></param>
        /// <param name="previous"></param>
        /// <param name="current"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventAutoscalingScheduleChangeV1(
            global::Baseten.AuditLogEventAutoscalingScheduleActionV1 action,
            string scheduleId,
            global::Baseten.AuditLogEventAutoscalingScheduleSettingsV1? previous,
            global::Baseten.AuditLogEventAutoscalingScheduleSettingsV1? current)
        {
            this.Action = action;
            this.ScheduleId = scheduleId ?? throw new global::System.ArgumentNullException(nameof(scheduleId));
            this.Previous = previous;
            this.Current = current;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventAutoscalingScheduleChangeV1" /> class.
        /// </summary>
        public AuditLogEventAutoscalingScheduleChangeV1()
        {
        }

    }
}