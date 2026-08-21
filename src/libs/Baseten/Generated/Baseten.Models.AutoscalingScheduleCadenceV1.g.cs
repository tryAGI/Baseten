
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutoscalingScheduleCadenceV1
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
    public static class AutoscalingScheduleCadenceV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutoscalingScheduleCadenceV1 value)
        {
            return value switch
            {
                AutoscalingScheduleCadenceV1.Daily => "DAILY",
                AutoscalingScheduleCadenceV1.Hourly => "HOURLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutoscalingScheduleCadenceV1? ToEnum(string value)
        {
            return value switch
            {
                "DAILY" => AutoscalingScheduleCadenceV1.Daily,
                "HOURLY" => AutoscalingScheduleCadenceV1.Hourly,
                _ => null,
            };
        }
    }
}