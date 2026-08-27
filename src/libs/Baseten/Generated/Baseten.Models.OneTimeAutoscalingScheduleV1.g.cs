
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OneTimeAutoscalingScheduleV1
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
        /// One-time schedule cadence
        /// </summary>
        /// <default>"ONE_TIME"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence")]
        public string Cadence { get; set; } = "ONE_TIME";

        /// <summary>
        /// Inclusive start of the schedule window
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartAt { get; set; }

        /// <summary>
        /// Exclusive end of the schedule window
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
        /// Initializes a new instance of the <see cref="OneTimeAutoscalingScheduleV1" /> class.
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
        /// <param name="startAt">
        /// Inclusive start of the schedule window
        /// </param>
        /// <param name="endAt">
        /// Exclusive end of the schedule window
        /// </param>
        /// <param name="cadence">
        /// One-time schedule cadence
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OneTimeAutoscalingScheduleV1(
            string id,
            string name,
            bool enabled,
            global::Baseten.AutoscalingScheduleSettingsV1 autoscalingSettings,
            global::System.DateTime startAt,
            global::System.DateTime endAt,
            string cadence = "ONE_TIME")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Enabled = enabled;
            this.AutoscalingSettings = autoscalingSettings ?? throw new global::System.ArgumentNullException(nameof(autoscalingSettings));
            this.Cadence = cadence;
            this.StartAt = startAt;
            this.EndAt = endAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneTimeAutoscalingScheduleV1" /> class.
        /// </summary>
        public OneTimeAutoscalingScheduleV1()
        {
        }

    }
}