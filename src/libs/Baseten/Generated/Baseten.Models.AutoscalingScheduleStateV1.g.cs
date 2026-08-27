
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AutoscalingScheduleStateV1
    {
        /// <summary>
        /// Stable schedule identifier, or null when the baseline settings apply
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
        public string? ScheduleId { get; set; }

        /// <summary>
        /// Autoscaling settings on the current serving deployment. In a PATCH response, this snapshot can precede asynchronous schedule reconciliation; poll the GET endpoint for the applied state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AutoscalingSettingsV1 AutoscalingSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoscalingScheduleStateV1" /> class.
        /// </summary>
        /// <param name="autoscalingSettings">
        /// Autoscaling settings on the current serving deployment. In a PATCH response, this snapshot can precede asynchronous schedule reconciliation; poll the GET endpoint for the applied state.
        /// </param>
        /// <param name="scheduleId">
        /// Stable schedule identifier, or null when the baseline settings apply
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AutoscalingScheduleStateV1(
            global::Baseten.AutoscalingSettingsV1 autoscalingSettings,
            string? scheduleId)
        {
            this.ScheduleId = scheduleId;
            this.AutoscalingSettings = autoscalingSettings ?? throw new global::System.ArgumentNullException(nameof(autoscalingSettings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoscalingScheduleStateV1" /> class.
        /// </summary>
        public AutoscalingScheduleStateV1()
        {
        }

    }
}