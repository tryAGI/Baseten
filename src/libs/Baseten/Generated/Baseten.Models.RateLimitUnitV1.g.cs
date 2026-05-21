
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum RateLimitUnitV1
    {
        /// <summary>
        /// 
        /// </summary>
        Minute,
        /// <summary>
        /// 
        /// </summary>
        Second,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RateLimitUnitV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RateLimitUnitV1 value)
        {
            return value switch
            {
                RateLimitUnitV1.Minute => "MINUTE",
                RateLimitUnitV1.Second => "SECOND",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RateLimitUnitV1? ToEnum(string value)
        {
            return value switch
            {
                "MINUTE" => RateLimitUnitV1.Minute,
                "SECOND" => RateLimitUnitV1.Second,
                _ => null,
            };
        }
    }
}