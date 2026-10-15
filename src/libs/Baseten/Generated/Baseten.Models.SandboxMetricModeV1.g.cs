
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxMetricModeV1
    {
        /// <summary>
        ///
        /// </summary>
        Current,
        /// <summary>
        ///
        /// </summary>
        Series,
        /// <summary>
        ///
        /// </summary>
        Summary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxMetricModeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxMetricModeV1 value)
        {
            return value switch
            {
                SandboxMetricModeV1.Current => "CURRENT",
                SandboxMetricModeV1.Series => "SERIES",
                SandboxMetricModeV1.Summary => "SUMMARY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxMetricModeV1? ToEnum(string value)
        {
            return value switch
            {
                "CURRENT" => SandboxMetricModeV1.Current,
                "SERIES" => SandboxMetricModeV1.Series,
                "SUMMARY" => SandboxMetricModeV1.Summary,
                _ => null,
            };
        }
    }
}