
#nullable enable

namespace Baseten
{
    /// <summary>
    /// How metric values are aggregated over the request.
    /// </summary>
    public enum MetricModeV1
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
    public static class MetricModeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetricModeV1 value)
        {
            return value switch
            {
                MetricModeV1.Current => "CURRENT",
                MetricModeV1.Series => "SERIES",
                MetricModeV1.Summary => "SUMMARY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetricModeV1? ToEnum(string value)
        {
            return value switch
            {
                "CURRENT" => MetricModeV1.Current,
                "SERIES" => MetricModeV1.Series,
                "SUMMARY" => MetricModeV1.Summary,
                _ => null,
            };
        }
    }
}