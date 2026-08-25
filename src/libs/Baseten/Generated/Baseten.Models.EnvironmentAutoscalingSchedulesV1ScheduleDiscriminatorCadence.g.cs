
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence
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
    public static class EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence value)
        {
            return value switch
            {
                EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence.Daily => "DAILY",
                EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence.Hourly => "HOURLY",
                EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence.OneTime => "ONE_TIME",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence? ToEnum(string value)
        {
            return value switch
            {
                "DAILY" => EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence.Daily,
                "HOURLY" => EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence.Hourly,
                "ONE_TIME" => EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence.OneTime,
                _ => null,
            };
        }
    }
}