
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Recurring schedule cadence
    /// </summary>
    public enum AutoscalingScheduleUpsertV1Cadence
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
    public static class AutoscalingScheduleUpsertV1CadenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoscalingScheduleUpsertV1Cadence value)
        {
            return value switch
            {
                AutoscalingScheduleUpsertV1Cadence.Daily => "DAILY",
                AutoscalingScheduleUpsertV1Cadence.Hourly => "HOURLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoscalingScheduleUpsertV1Cadence? ToEnum(string value)
        {
            return value switch
            {
                "DAILY" => AutoscalingScheduleUpsertV1Cadence.Daily,
                "HOURLY" => AutoscalingScheduleUpsertV1Cadence.Hourly,
                _ => null,
            };
        }
    }
}