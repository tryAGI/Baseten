
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnvironmentAutoscalingSchedulesV1
    {
        /// <summary>
        /// IANA timezone shared by all schedules. Omitted when no schedules exist.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Autoscaling schedules ordered by creation time and stable identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.SchedulesItem> Schedules { get; set; }

        /// <summary>
        /// Autoscaling state on the current serving deployment, or null when no deployment exists
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applied_state")]
        public global::Baseten.AutoscalingScheduleStateV1? AppliedState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentAutoscalingSchedulesV1" /> class.
        /// </summary>
        /// <param name="schedules">
        /// Autoscaling schedules ordered by creation time and stable identifier
        /// </param>
        /// <param name="timezone">
        /// IANA timezone shared by all schedules. Omitted when no schedules exist.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="appliedState">
        /// Autoscaling state on the current serving deployment, or null when no deployment exists
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentAutoscalingSchedulesV1(
            global::System.Collections.Generic.IList<global::Baseten.SchedulesItem> schedules,
            string? timezone,
            global::Baseten.AutoscalingScheduleStateV1? appliedState)
        {
            this.Timezone = timezone;
            this.Schedules = schedules ?? throw new global::System.ArgumentNullException(nameof(schedules));
            this.AppliedState = appliedState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentAutoscalingSchedulesV1" /> class.
        /// </summary>
        public EnvironmentAutoscalingSchedulesV1()
        {
        }

    }
}