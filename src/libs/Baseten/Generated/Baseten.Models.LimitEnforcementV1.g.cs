
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum LimitEnforcementV1
    {
        /// <summary>
        /// 
        /// </summary>
        Cascading,
        /// <summary>
        /// 
        /// </summary>
        Independent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LimitEnforcementV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LimitEnforcementV1 value)
        {
            return value switch
            {
                LimitEnforcementV1.Cascading => "CASCADING",
                LimitEnforcementV1.Independent => "INDEPENDENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LimitEnforcementV1? ToEnum(string value)
        {
            return value switch
            {
                "CASCADING" => LimitEnforcementV1.Cascading,
                "INDEPENDENT" => LimitEnforcementV1.Independent,
                _ => null,
            };
        }
    }
}