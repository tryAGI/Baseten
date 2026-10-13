
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum RouteSpendBlockedByV1
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
    public static class RouteSpendBlockedByV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RouteSpendBlockedByV1 value)
        {
            return value switch
            {
                RouteSpendBlockedByV1.Member => "member",
                RouteSpendBlockedByV1.Team => "team",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RouteSpendBlockedByV1? ToEnum(string value)
        {
            return value switch
            {
                "member" => RouteSpendBlockedByV1.Member,
                "team" => RouteSpendBlockedByV1.Team,
                _ => null,
            };
        }
    }
}