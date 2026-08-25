
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A complete one-time schedule submitted for create or replacement.
    /// </summary>
    public sealed partial class OneTimeAutoscalingScheduleUpsertV1
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
        /// Complete raw autoscaling overrides for the schedule. Every field is required; nullable fields store no schedule override and follow the current environment value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AutoscalingScheduleSettingsRequestV1 AutoscalingSettings { get; set; }

        /// <summary>
        /// One-time schedule cadence
        /// </summary>
        /// <default>"ONE_TIME"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence")]
        public string Cadence { get; set; } = "ONE_TIME";

        /// <summary>
        /// Inclusive start of the schedule window in ISO 8601 format. New schedules must start in the future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartAt { get; set; }

        /// <summary>
        /// Exclusive end of the schedule window in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OneTimeAutoscalingScheduleUpsertV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the schedule
        /// </param>
        /// <param name="enabled">
        /// Whether the schedule is enabled
        /// </param>
        /// <param name="autoscalingSettings">
        /// Complete raw autoscaling overrides for the schedule. Every field is required; nullable fields store no schedule override and follow the current environment value.
        /// </param>
        /// <param name="startAt">
        /// Inclusive start of the schedule window in ISO 8601 format. New schedules must start in the future.
        /// </param>
        /// <param name="endAt">
        /// Exclusive end of the schedule window in ISO 8601 format
        /// </param>
        /// <param name="id">
        /// Stable schedule identifier. Omit this field to create a schedule.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cadence">
        /// One-time schedule cadence
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OneTimeAutoscalingScheduleUpsertV1(
            string name,
            bool enabled,
            global::Baseten.AutoscalingScheduleSettingsRequestV1 autoscalingSettings,
            global::System.DateTime startAt,
            global::System.DateTime endAt,
            string? id,
            string cadence = "ONE_TIME")
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Enabled = enabled;
            this.AutoscalingSettings = autoscalingSettings ?? throw new global::System.ArgumentNullException(nameof(autoscalingSettings));
            this.Cadence = cadence;
            this.StartAt = startAt;
            this.EndAt = endAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneTimeAutoscalingScheduleUpsertV1" /> class.
        /// </summary>
        public OneTimeAutoscalingScheduleUpsertV1()
        {
        }

    }
}