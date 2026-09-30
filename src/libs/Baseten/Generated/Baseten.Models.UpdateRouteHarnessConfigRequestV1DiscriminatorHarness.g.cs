
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum UpdateRouteHarnessConfigRequestV1DiscriminatorHarness
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
    public static class UpdateRouteHarnessConfigRequestV1DiscriminatorHarnessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRouteHarnessConfigRequestV1DiscriminatorHarness value)
        {
            return value switch
            {
                UpdateRouteHarnessConfigRequestV1DiscriminatorHarness.ClaudeCode => "claude-code",
                UpdateRouteHarnessConfigRequestV1DiscriminatorHarness.Codex => "codex",
                UpdateRouteHarnessConfigRequestV1DiscriminatorHarness.Opencode => "opencode",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRouteHarnessConfigRequestV1DiscriminatorHarness? ToEnum(string value)
        {
            return value switch
            {
                "claude-code" => UpdateRouteHarnessConfigRequestV1DiscriminatorHarness.ClaudeCode,
                "codex" => UpdateRouteHarnessConfigRequestV1DiscriminatorHarness.Codex,
                "opencode" => UpdateRouteHarnessConfigRequestV1DiscriminatorHarness.Opencode,
                _ => null,
            };
        }
    }
}