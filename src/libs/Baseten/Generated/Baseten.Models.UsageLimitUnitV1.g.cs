
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageLimitUnitV1
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageLimitUnitV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageLimitUnitV1 value)
        {
            return value switch
            {
                UsageLimitUnitV1.Day => "DAY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageLimitUnitV1? ToEnum(string value)
        {
            return value switch
            {
                "DAY" => UsageLimitUnitV1.Day,
                _ => null,
            };
        }
    }
}