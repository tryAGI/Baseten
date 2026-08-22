
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A complete autoscaling schedule submitted for create or replacement.
    /// </summary>
    public sealed partial class AutoscalingScheduleUpsertV1
    {
        /// <summary>
        /// Stable schedule identifier. Omit this field to create a schedule.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        /// Cadence of the schedule
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AutoscalingScheduleCadenceV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AutoscalingScheduleCadenceV1 Cadence { get; set; }

        /// <summary>
        /// Weekdays on which the schedule runs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weekdays")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.AutoscalingScheduleWeekdayV1> Weekdays { get; set; }

        /// <summary>
        /// Start hour in the environment schedule timezone. Omit for unrestricted HOURLY schedules.<br/>
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
        /// End hour in the environment schedule timezone. Omit for unrestricted HOURLY schedules.<br/>
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
        /// Complete raw autoscaling overrides for the schedule. Every field is required; nullable fields store no schedule override and follow the current environment value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AutoscalingScheduleSettingsRequestV1 AutoscalingSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoscalingScheduleUpsertV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the schedule
        /// </param>
        /// <param name="enabled">
        /// Whether the schedule is enabled
        /// </param>
        /// <param name="cadence">
        /// Cadence of the schedule
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
        /// <param name="autoscalingSettings">
        /// Complete raw autoscaling overrides for the schedule. Every field is required; nullable fields store no schedule override and follow the current environment value.
        /// </param>
        /// <param name="id">
        /// Stable schedule identifier. Omit this field to create a schedule.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="startHour">
        /// Start hour in the environment schedule timezone. Omit for unrestricted HOURLY schedules.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="endHour">
        /// End hour in the environment schedule timezone. Omit for unrestricted HOURLY schedules.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoscalingScheduleUpsertV1(
            string name,
            bool enabled,
            global::Baseten.AutoscalingScheduleCadenceV1 cadence,
            global::System.Collections.Generic.IList<global::Baseten.AutoscalingScheduleWeekdayV1> weekdays,
            int startMinute,
            int endMinute,
            global::Baseten.AutoscalingScheduleSettingsRequestV1 autoscalingSettings,
            string? id,
            int? startHour,
            int? endHour)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Enabled = enabled;
            this.Cadence = cadence;
            this.Weekdays = weekdays ?? throw new global::System.ArgumentNullException(nameof(weekdays));
            this.StartHour = startHour;
            this.StartMinute = startMinute;
            this.EndHour = endHour;
            this.EndMinute = endMinute;
            this.AutoscalingSettings = autoscalingSettings ?? throw new global::System.ArgumentNullException(nameof(autoscalingSettings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoscalingScheduleUpsertV1" /> class.
        /// </summary>
        public AutoscalingScheduleUpsertV1()
        {
        }

    }
}