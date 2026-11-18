
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum GridRouteAliasKindV1
    {
        /// <summary>
        ///
        /// </summary>
        Alias,
        /// <summary>
        ///
        /// </summary>
        ClaudeDesktop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GridRouteAliasKindV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GridRouteAliasKindV1 value)
        {
            return value switch
            {
                GridRouteAliasKindV1.Alias => "ALIAS",
                GridRouteAliasKindV1.ClaudeDesktop => "CLAUDE_DESKTOP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GridRouteAliasKindV1? ToEnum(string value)
        {
            return value switch
            {
                "ALIAS" => GridRouteAliasKindV1.Alias,
                "CLAUDE_DESKTOP" => GridRouteAliasKindV1.ClaudeDesktop,
                _ => null,
            };
        }
    }
}