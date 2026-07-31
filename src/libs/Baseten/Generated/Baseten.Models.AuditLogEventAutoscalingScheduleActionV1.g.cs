
#nullable enable

namespace Baseten
{
    /// <summary>
    /// What an autoscaling change did to one schedule.
    /// </summary>
    public enum AuditLogEventAutoscalingScheduleActionV1
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Unchanged,
        /// <summary>
        /// 
        /// </summary>
        Updated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogEventAutoscalingScheduleActionV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogEventAutoscalingScheduleActionV1 value)
        {
            return value switch
            {
                AuditLogEventAutoscalingScheduleActionV1.Created => "CREATED",
                AuditLogEventAutoscalingScheduleActionV1.Deleted => "DELETED",
                AuditLogEventAutoscalingScheduleActionV1.Unchanged => "UNCHANGED",
                AuditLogEventAutoscalingScheduleActionV1.Updated => "UPDATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogEventAutoscalingScheduleActionV1? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => AuditLogEventAutoscalingScheduleActionV1.Created,
                "DELETED" => AuditLogEventAutoscalingScheduleActionV1.Deleted,
                "UNCHANGED" => AuditLogEventAutoscalingScheduleActionV1.Unchanged,
                "UPDATED" => AuditLogEventAutoscalingScheduleActionV1.Updated,
                _ => null,
            };
        }
    }
}