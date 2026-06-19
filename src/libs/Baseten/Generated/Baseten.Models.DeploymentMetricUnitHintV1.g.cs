
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
    public enum DeploymentMetricUnitHintV1
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
    public static class DeploymentMetricUnitHintV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeploymentMetricUnitHintV1 value)
        {
            return value switch
            {
                DeploymentMetricUnitHintV1.Bytes => "BYTES",
                DeploymentMetricUnitHintV1.Count => "COUNT",
                DeploymentMetricUnitHintV1.Mebibytes => "MEBIBYTES",
                DeploymentMetricUnitHintV1.PerSecond => "PER_SECOND",
                DeploymentMetricUnitHintV1.Ratio => "RATIO",
                DeploymentMetricUnitHintV1.Seconds => "SECONDS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeploymentMetricUnitHintV1? ToEnum(string value)
        {
            return value switch
            {
                "BYTES" => DeploymentMetricUnitHintV1.Bytes,
                "COUNT" => DeploymentMetricUnitHintV1.Count,
                "MEBIBYTES" => DeploymentMetricUnitHintV1.Mebibytes,
                "PER_SECOND" => DeploymentMetricUnitHintV1.PerSecond,
                "RATIO" => DeploymentMetricUnitHintV1.Ratio,
                "SECONDS" => DeploymentMetricUnitHintV1.Seconds,
                _ => null,
            };
        }
    }
}