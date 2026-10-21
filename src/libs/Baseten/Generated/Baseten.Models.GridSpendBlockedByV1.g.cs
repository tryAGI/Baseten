
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum GridSpendBlockedByV1
    {
        /// <summary>
        ///
        /// </summary>
        Member,
        /// <summary>
        ///
        /// </summary>
        Team,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GridSpendBlockedByV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GridSpendBlockedByV1 value)
        {
            return value switch
            {
                GridSpendBlockedByV1.Member => "member",
                GridSpendBlockedByV1.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GridSpendBlockedByV1? ToEnum(string value)
        {
            return value switch
            {
                "member" => GridSpendBlockedByV1.Member,
                "team" => GridSpendBlockedByV1.Team,
                _ => null,
            };
        }
    }
}