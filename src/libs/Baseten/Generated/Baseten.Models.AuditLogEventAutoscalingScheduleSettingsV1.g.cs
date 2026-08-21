
#nullable enable

namespace Baseten
{
    /// <summary>
    /// One autoscaling schedule's timing and autoscaling settings. Not itself a union payload.
    /// </summary>
    public sealed partial class AuditLogEventAutoscalingScheduleSettingsV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_replica")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MinReplica { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_replica")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxReplica { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency_target")]
        public int? ConcurrencyTarget { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_window")]
        public int? AutoscalingWindow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_down_delay")]
        public int? ScaleDownDelay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_utilization_percentage")]
        public int? TargetUtilizationPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_in_flight_tokens")]
        public int? TargetInFlightTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_scale_down_rate")]
        public double? MaxScaleDownRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScheduleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cadence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weekdays")]
        public global::System.Collections.Generic.IList<string>? Weekdays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_hour")]
        public int? StartHour { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_minute")]
        public int? StartMinute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_hour")]
        public int? EndHour { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_minute")]
        public int? EndMinute { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_at")]
        public string? StartAt { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_at")]
        public string? EndAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventAutoscalingScheduleSettingsV1" /> class.
        /// </summary>
        /// <param name="minReplica"></param>
        /// <param name="maxReplica"></param>
        /// <param name="scheduleName"></param>
        /// <param name="enabled"></param>
        /// <param name="cadence"></param>
        /// <param name="timezone"></param>
        /// <param name="concurrencyTarget"></param>
        /// <param name="autoscalingWindow"></param>
        /// <param name="scaleDownDelay"></param>
        /// <param name="targetUtilizationPercentage"></param>
        /// <param name="targetInFlightTokens"></param>
        /// <param name="maxScaleDownRate"></param>
        /// <param name="weekdays"></param>
        /// <param name="startHour"></param>
        /// <param name="startMinute"></param>
        /// <param name="endHour"></param>
        /// <param name="endMinute"></param>
        /// <param name="startAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endAt">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventAutoscalingScheduleSettingsV1(
            int minReplica,
            int maxReplica,
            string scheduleName,
            bool enabled,
            string cadence,
            string timezone,
            int? concurrencyTarget,
            int? autoscalingWindow,
            int? scaleDownDelay,
            int? targetUtilizationPercentage,
            int? targetInFlightTokens,
            double? maxScaleDownRate,
            global::System.Collections.Generic.IList<string>? weekdays,
            int? startHour,
            int? startMinute,
            int? endHour,
            int? endMinute,
            string? startAt,
            string? endAt)
        {
            this.MinReplica = minReplica;
            this.MaxReplica = maxReplica;
            this.ConcurrencyTarget = concurrencyTarget;
            this.AutoscalingWindow = autoscalingWindow;
            this.ScaleDownDelay = scaleDownDelay;
            this.TargetUtilizationPercentage = targetUtilizationPercentage;
            this.TargetInFlightTokens = targetInFlightTokens;
            this.MaxScaleDownRate = maxScaleDownRate;
            this.ScheduleName = scheduleName ?? throw new global::System.ArgumentNullException(nameof(scheduleName));
            this.Enabled = enabled;
            this.Cadence = cadence ?? throw new global::System.ArgumentNullException(nameof(cadence));
            this.Timezone = timezone ?? throw new global::System.ArgumentNullException(nameof(timezone));
            this.Weekdays = weekdays;
            this.StartHour = startHour;
            this.StartMinute = startMinute;
            this.EndHour = endHour;
            this.EndMinute = endMinute;
            this.StartAt = startAt;
            this.EndAt = endAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventAutoscalingScheduleSettingsV1" /> class.
        /// </summary>
        public AuditLogEventAutoscalingScheduleSettingsV1()
        {
        }

    }
}