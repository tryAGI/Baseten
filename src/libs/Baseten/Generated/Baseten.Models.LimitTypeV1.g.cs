
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum LimitTypeV1
    {
        /// <summary>
        /// 
        /// </summary>
        Request,
        /// <summary>
        /// 
        /// </summary>
        Token,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LimitTypeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LimitTypeV1 value)
        {
            return value switch
            {
                LimitTypeV1.Request => "REQUEST",
                LimitTypeV1.Token => "TOKEN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LimitTypeV1? ToEnum(string value)
        {
            return value switch
            {
                "REQUEST" => LimitTypeV1.Request,
                "TOKEN" => LimitTypeV1.Token,
                _ => null,
            };
        }
    }
}