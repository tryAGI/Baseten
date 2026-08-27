
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence
    {
        /// <summary>
        ///
        /// </summary>
        Daily,
        /// <summary>
        ///
        /// </summary>
        Hourly,
        /// <summary>
        ///
        /// </summary>
        OneTime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence value)
        {
            return value switch
            {
                UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence.Daily => "DAILY",
                UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence.Hourly => "HOURLY",
                UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence.OneTime => "ONE_TIME",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence? ToEnum(string value)
        {
            return value switch
            {
                "DAILY" => UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence.Daily,
                "HOURLY" => UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence.Hourly,
                "ONE_TIME" => UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence.OneTime,
                _ => null,
            };
        }
    }
}