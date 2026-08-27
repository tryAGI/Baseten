
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Cadence of the schedule. DAILY runs once per selected weekday; HOURLY repeats the minute window every hour on selected weekdays.
    /// </summary>
    public enum AutoscalingScheduleV1Cadence
    {
        /// <summary>
        ///
        /// </summary>
        Daily,
        /// <summary>
        ///
        /// </summary>
        Hourly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoscalingScheduleV1CadenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoscalingScheduleV1Cadence value)
        {
            return value switch
            {
                AutoscalingScheduleV1Cadence.Daily => "DAILY",
                AutoscalingScheduleV1Cadence.Hourly => "HOURLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoscalingScheduleV1Cadence? ToEnum(string value)
        {
            return value switch
            {
                "DAILY" => AutoscalingScheduleV1Cadence.Daily,
                "HOURLY" => AutoscalingScheduleV1Cadence.Hourly,
                _ => null,
            };
        }
    }
}