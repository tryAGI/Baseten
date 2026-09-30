
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum SetRouteHarnessConfigRequestV1DiscriminatorHarness
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
    public static class SetRouteHarnessConfigRequestV1DiscriminatorHarnessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SetRouteHarnessConfigRequestV1DiscriminatorHarness value)
        {
            return value switch
            {
                SetRouteHarnessConfigRequestV1DiscriminatorHarness.ClaudeCode => "claude-code",
                SetRouteHarnessConfigRequestV1DiscriminatorHarness.Codex => "codex",
                SetRouteHarnessConfigRequestV1DiscriminatorHarness.Opencode => "opencode",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SetRouteHarnessConfigRequestV1DiscriminatorHarness? ToEnum(string value)
        {
            return value switch
            {
                "claude-code" => SetRouteHarnessConfigRequestV1DiscriminatorHarness.ClaudeCode,
                "codex" => SetRouteHarnessConfigRequestV1DiscriminatorHarness.Codex,
                "opencode" => SetRouteHarnessConfigRequestV1DiscriminatorHarness.Opencode,
                _ => null,
            };
        }
    }
}