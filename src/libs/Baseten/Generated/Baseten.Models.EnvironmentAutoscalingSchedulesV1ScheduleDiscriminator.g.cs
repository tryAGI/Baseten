
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class EnvironmentAutoscalingSchedulesV1ScheduleDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadenceJsonConverter))]
        public global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence? Cadence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentAutoscalingSchedulesV1ScheduleDiscriminator" /> class.
        /// </summary>
        /// <param name="cadence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentAutoscalingSchedulesV1ScheduleDiscriminator(
            global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence? cadence)
        {
            this.Cadence = cadence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentAutoscalingSchedulesV1ScheduleDiscriminator" /> class.
        /// </summary>
        public EnvironmentAutoscalingSchedulesV1ScheduleDiscriminator()
        {
        }

    }
}