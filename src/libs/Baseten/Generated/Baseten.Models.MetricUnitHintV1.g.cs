
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
    ///   (e.g. CPU usage in cores = cpu-seconds/second).<br/>
    /// - ``CELSIUS``: a temperature in degrees Celsius.<br/>
    /// - ``WATTS``: power draw in watts.
    /// </summary>
    public enum MetricUnitHintV1
    {
        /// <summary>
        /// a size in bytes.
        /// </summary>
        Bytes,
        /// <summary>
        /// a temperature in degrees Celsius.
        /// </summary>
        Celsius,
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
        /// <summary>
        /// power draw in watts.
        /// </summary>
        Watts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetricUnitHintV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetricUnitHintV1 value)
        {
            return value switch
            {
                MetricUnitHintV1.Bytes => "BYTES",
                MetricUnitHintV1.Celsius => "CELSIUS",
                MetricUnitHintV1.Count => "COUNT",
                MetricUnitHintV1.Mebibytes => "MEBIBYTES",
                MetricUnitHintV1.PerSecond => "PER_SECOND",
                MetricUnitHintV1.Ratio => "RATIO",
                MetricUnitHintV1.Seconds => "SECONDS",
                MetricUnitHintV1.Watts => "WATTS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetricUnitHintV1? ToEnum(string value)
        {
            return value switch
            {
                "BYTES" => MetricUnitHintV1.Bytes,
                "CELSIUS" => MetricUnitHintV1.Celsius,
                "COUNT" => MetricUnitHintV1.Count,
                "MEBIBYTES" => MetricUnitHintV1.Mebibytes,
                "PER_SECOND" => MetricUnitHintV1.PerSecond,
                "RATIO" => MetricUnitHintV1.Ratio,
                "SECONDS" => MetricUnitHintV1.Seconds,
                "WATTS" => MetricUnitHintV1.Watts,
                _ => null,
            };
        }
    }
}