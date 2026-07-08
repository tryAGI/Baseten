
#nullable enable

namespace Baseten
{
    /// <summary>
    /// How metric values are aggregated over the request.
    /// </summary>
    public enum ModelMetricModeV1
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
    public static class ModelMetricModeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelMetricModeV1 value)
        {
            return value switch
            {
                ModelMetricModeV1.Current => "CURRENT",
                ModelMetricModeV1.Series => "SERIES",
                ModelMetricModeV1.Summary => "SUMMARY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelMetricModeV1? ToEnum(string value)
        {
            return value switch
            {
                "CURRENT" => ModelMetricModeV1.Current,
                "SERIES" => ModelMetricModeV1.Series,
                "SUMMARY" => ModelMetricModeV1.Summary,
                _ => null,
            };
        }
    }
}