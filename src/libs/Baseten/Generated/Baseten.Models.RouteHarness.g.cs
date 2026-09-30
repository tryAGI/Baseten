
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum RouteHarness
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RouteHarnessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RouteHarness value)
        {
            return value switch
            {
                RouteHarness.ClaudeCode => "claude-code",
                RouteHarness.Codex => "codex",
                RouteHarness.Opencode => "opencode",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RouteHarness? ToEnum(string value)
        {
            return value switch
            {
                "claude-code" => RouteHarness.ClaudeCode,
                "codex" => RouteHarness.Codex,
                "opencode" => RouteHarness.Opencode,
                _ => null,
            };
        }
    }
}