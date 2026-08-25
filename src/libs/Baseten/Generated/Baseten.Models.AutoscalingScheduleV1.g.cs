
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutoscalingScheduleV1
    {
        /// <summary>
        /// Stable unique identifier of the schedule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the schedule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether the schedule is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Raw autoscaling overrides applied during the schedule window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AutoscalingScheduleSettingsV1 AutoscalingSettings { get; set; }

        /// <summary>
        /// Cadence of the schedule. DAILY runs once per selected weekday; HOURLY repeats the minute window every hour on selected weekdays.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AutoscalingScheduleV1CadenceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AutoscalingScheduleV1Cadence Cadence { get; set; }

        /// <summary>
        /// Weekdays on which the schedule runs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weekdays")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AutoscalingScheduleWeekdayV1> Weekdays { get; set; }

        /// <summary>
        /// Start hour in the environment schedule timezone. Omitted for unrestricted HOURLY schedules.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_hour")]
        public int? StartHour { get; set; }

        /// <summary>
        /// Start minute of the schedule window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartMinute { get; set; }

        /// <summary>
        /// End hour in the environment schedule timezone. Omitted for unrestricted HOURLY schedules.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_hour")]
        public int? EndHour { get; set; }

        /// <summary>
        /// End minute of the schedule window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndMinute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoscalingScheduleV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Stable unique identifier of the schedule
        /// </param>
        /// <param name="name">
        /// Name of the schedule
        /// </param>
        /// <param name="enabled">
        /// Whether the schedule is enabled
        /// </param>
        /// <param name="autoscalingSettings">
        /// Raw autoscaling overrides applied during the schedule window
        /// </param>
        /// <param name="cadence">
        /// Cadence of the schedule. DAILY runs once per selected weekday; HOURLY repeats the minute window every hour on selected weekdays.
        /// </param>
        /// <param name="weekdays">
        /// Weekdays on which the schedule runs
        /// </param>
        /// <param name="startMinute">
        /// Start minute of the schedule window
        /// </param>
        /// <param name="endMinute">
        /// End minute of the schedule window
        /// </param>
        /// <param name="startHour">
        /// Start hour in the environment schedule timezone. Omitted for unrestricted HOURLY schedules.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endHour">
        /// End hour in the environment schedule timezone. Omitted for unrestricted HOURLY schedules.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoscalingScheduleV1(
            string id,
            string name,
            bool enabled,
            global::Baseten.AutoscalingScheduleSettingsV1 autoscalingSettings,
            global::Baseten.AutoscalingScheduleV1Cadence cadence,
            global::System.Collections.Generic.IList<global::Baseten.AutoscalingScheduleWeekdayV1> weekdays,
            int startMinute,
            int endMinute,
            int? startHour,
            int? endHour)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Enabled = enabled;
            this.AutoscalingSettings = autoscalingSettings ?? throw new global::System.ArgumentNullException(nameof(autoscalingSettings));
            this.Cadence = cadence;
            this.Weekdays = weekdays ?? throw new global::System.ArgumentNullException(nameof(weekdays));
            this.StartHour = startHour;
            this.StartMinute = startMinute;
            this.EndHour = endHour;
            this.EndMinute = endMinute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoscalingScheduleV1" /> class.
        /// </summary>
        public AutoscalingScheduleV1()
        {
        }

    }
}