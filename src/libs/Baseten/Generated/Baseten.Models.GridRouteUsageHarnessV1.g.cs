
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum GridRouteUsageHarnessV1
    {
        /// <summary>
        ///
        /// </summary>
        ClaudeCode,
        /// <summary>
        ///
        /// </summary>
        Codex,
        /// <summary>
        ///
        /// </summary>
        Opencode,
        /// <summary>
        ///
        /// </summary>
        Pi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GridRouteUsageHarnessV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GridRouteUsageHarnessV1 value)
        {
            return value switch
            {
                GridRouteUsageHarnessV1.ClaudeCode => "CLAUDE_CODE",
                GridRouteUsageHarnessV1.Codex => "CODEX",
                GridRouteUsageHarnessV1.Opencode => "OPENCODE",
                GridRouteUsageHarnessV1.Pi => "PI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GridRouteUsageHarnessV1? ToEnum(string value)
        {
            return value switch
            {
                "CLAUDE_CODE" => GridRouteUsageHarnessV1.ClaudeCode,
                "CODEX" => GridRouteUsageHarnessV1.Codex,
                "OPENCODE" => GridRouteUsageHarnessV1.Opencode,
                "PI" => GridRouteUsageHarnessV1.Pi,
                _ => null,
            };
        }
    }
}