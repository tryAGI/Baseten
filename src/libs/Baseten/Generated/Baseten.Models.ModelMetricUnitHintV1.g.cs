
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Advisory unit of a metric's values. Values are reported as scraped, so the<br/>
    /// hint describes the raw value (e.g. GPU memory is reported in mebibytes).<br/>
    /// - ``PER_SECOND``: a rate per second.<br/>
    /// - ``SECONDS``: a duration in seconds.<br/>
    /// - ``BYTES``: a size in bytes.<br/>
    /// - ``MEBIBYTES``: a size in mebibytes (MiB).<br/>
    /// - ``COUNT``: a dimensionless tally of discrete things.<br/>
    /// - ``RATIO``: a dimensionless ratio. Usually in ``[0, 1]`` but may exceed 1<br/>
    ///   (e.g. CPU usage in cores = cpu-seconds/second).
    /// </summary>
    public enum ModelMetricUnitHintV1
    {
        /// <summary>
        /// a size in bytes.
        /// </summary>
        Bytes,
        /// <summary>
        /// a dimensionless tally of discrete things.
        /// </summary>
        Count,
        /// <summary>
        /// a size in mebibytes (MiB).
        /// </summary>
        Mebibytes,
        /// <summary>
        /// a rate per second.
        /// </summary>
        PerSecond,
        /// <summary>
        /// a dimensionless ratio. Usually in ``[0, 1]`` but may exceed 1
        /// </summary>
        Ratio,
        /// <summary>
        /// a duration in seconds.
        /// </summary>
        Seconds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelMetricUnitHintV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelMetricUnitHintV1 value)
        {
            return value switch
            {
                ModelMetricUnitHintV1.Bytes => "BYTES",
                ModelMetricUnitHintV1.Count => "COUNT",
                ModelMetricUnitHintV1.Mebibytes => "MEBIBYTES",
                ModelMetricUnitHintV1.PerSecond => "PER_SECOND",
                ModelMetricUnitHintV1.Ratio => "RATIO",
                ModelMetricUnitHintV1.Seconds => "SECONDS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelMetricUnitHintV1? ToEnum(string value)
        {
            return value switch
            {
                "BYTES" => ModelMetricUnitHintV1.Bytes,
                "COUNT" => ModelMetricUnitHintV1.Count,
                "MEBIBYTES" => ModelMetricUnitHintV1.Mebibytes,
                "PER_SECOND" => ModelMetricUnitHintV1.PerSecond,
                "RATIO" => ModelMetricUnitHintV1.Ratio,
                "SECONDS" => ModelMetricUnitHintV1.Seconds,
                _ => null,
            };
        }
    }
}