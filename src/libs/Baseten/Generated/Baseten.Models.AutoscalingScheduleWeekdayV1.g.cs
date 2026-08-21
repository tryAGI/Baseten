
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutoscalingScheduleWeekdayV1
    {
        /// <summary>
        /// 
        /// </summary>
        Friday,
        /// <summary>
        /// 
        /// </summary>
        Monday,
        /// <summary>
        /// 
        /// </summary>
        Saturday,
        /// <summary>
        /// 
        /// </summary>
        Sunday,
        /// <summary>
        /// 
        /// </summary>
        Thursday,
        /// <summary>
        /// 
        /// </summary>
        Tuesday,
        /// <summary>
        /// 
        /// </summary>
        Wednesday,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutoscalingScheduleWeekdayV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoscalingScheduleWeekdayV1 value)
        {
            return value switch
            {
                AutoscalingScheduleWeekdayV1.Friday => "FRIDAY",
                AutoscalingScheduleWeekdayV1.Monday => "MONDAY",
                AutoscalingScheduleWeekdayV1.Saturday => "SATURDAY",
                AutoscalingScheduleWeekdayV1.Sunday => "SUNDAY",
                AutoscalingScheduleWeekdayV1.Thursday => "THURSDAY",
                AutoscalingScheduleWeekdayV1.Tuesday => "TUESDAY",
                AutoscalingScheduleWeekdayV1.Wednesday => "WEDNESDAY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoscalingScheduleWeekdayV1? ToEnum(string value)
        {
            return value switch
            {
                "FRIDAY" => AutoscalingScheduleWeekdayV1.Friday,
                "MONDAY" => AutoscalingScheduleWeekdayV1.Monday,
                "SATURDAY" => AutoscalingScheduleWeekdayV1.Saturday,
                "SUNDAY" => AutoscalingScheduleWeekdayV1.Sunday,
                "THURSDAY" => AutoscalingScheduleWeekdayV1.Thursday,
                "TUESDAY" => AutoscalingScheduleWeekdayV1.Tuesday,
                "WEDNESDAY" => AutoscalingScheduleWeekdayV1.Wednesday,
                _ => null,
            };
        }
    }
}