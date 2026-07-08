
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Semantic hint for how a metric behaves, to aid client rendering and<br/>
    /// aggregation. It does not describe the value's shape (that is carried by the<br/>
    /// descriptor's ``label_sets``; a metric may break down into multiple series).<br/>
    /// - ``GAUGE``: an instantaneous value (e.g. queue size, running requests).<br/>
    /// - ``COUNTER``: a cumulative total over the step (e.g. tokens, restarts).<br/>
    /// - ``HISTOGRAM``: a distribution, exposed as quantile/average series.
    /// </summary>
    public enum ModelMetricKindV1
    {
        /// <summary>
        /// a cumulative total over the step (e.g. tokens, restarts).
        /// </summary>
        Counter,
        /// <summary>
        /// an instantaneous value (e.g. queue size, running requests).
        /// </summary>
        Gauge,
        /// <summary>
        /// a distribution, exposed as quantile/average series.
        /// </summary>
        Histogram,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelMetricKindV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelMetricKindV1 value)
        {
            return value switch
            {
                ModelMetricKindV1.Counter => "COUNTER",
                ModelMetricKindV1.Gauge => "GAUGE",
                ModelMetricKindV1.Histogram => "HISTOGRAM",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelMetricKindV1? ToEnum(string value)
        {
            return value switch
            {
                "COUNTER" => ModelMetricKindV1.Counter,
                "GAUGE" => ModelMetricKindV1.Gauge,
                "HISTOGRAM" => ModelMetricKindV1.Histogram,
                _ => null,
            };
        }
    }
}