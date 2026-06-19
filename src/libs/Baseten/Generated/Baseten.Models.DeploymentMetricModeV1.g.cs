
#nullable enable

namespace Baseten
{
    /// <summary>
    /// How metric values are aggregated over the request.
    /// </summary>
    public enum DeploymentMetricModeV1
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
    public static class DeploymentMetricModeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentMetricModeV1 value)
        {
            return value switch
            {
                DeploymentMetricModeV1.Current => "CURRENT",
                DeploymentMetricModeV1.Series => "SERIES",
                DeploymentMetricModeV1.Summary => "SUMMARY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentMetricModeV1? ToEnum(string value)
        {
            return value switch
            {
                "CURRENT" => DeploymentMetricModeV1.Current,
                "SERIES" => DeploymentMetricModeV1.Series,
                "SUMMARY" => DeploymentMetricModeV1.Summary,
                _ => null,
            };
        }
    }
}