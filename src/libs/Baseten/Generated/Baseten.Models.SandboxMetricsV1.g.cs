
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxMetricsV1
    {
        /// <summary>
        /// Returned window start, snapped outward in SERIES. Equal to end for CURRENT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_epoch_millis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long StartEpochMillis { get; set; }

        /// <summary>
        /// Returned exclusive window end, snapped outward in SERIES. Snapshot timestamp for CURRENT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_epoch_millis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long EndEpochMillis { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SandboxMetricModeV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.SandboxMetricModeV1 Mode { get; set; }

        /// <summary>
        /// Seconds per SERIES interval; null in CURRENT and SUMMARY.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_seconds")]
        public int? StepSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_descriptors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.SandboxMetricDescriptorV1> MetricDescriptors { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.SandboxMetricValueSetV1> MetricValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxMetricsV1" /> class.
        /// </summary>
        /// <param name="startEpochMillis">
        /// Returned window start, snapped outward in SERIES. Equal to end for CURRENT.
        /// </param>
        /// <param name="endEpochMillis">
        /// Returned exclusive window end, snapped outward in SERIES. Snapshot timestamp for CURRENT.
        /// </param>
        /// <param name="mode"></param>
        /// <param name="metricDescriptors"></param>
        /// <param name="metricValues"></param>
        /// <param name="stepSeconds">
        /// Seconds per SERIES interval; null in CURRENT and SUMMARY.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxMetricsV1(
            long startEpochMillis,
            long endEpochMillis,
            global::Baseten.SandboxMetricModeV1 mode,
            global::System.Collections.Generic.IList<global::Baseten.SandboxMetricDescriptorV1> metricDescriptors,
            global::System.Collections.Generic.IList<global::Baseten.SandboxMetricValueSetV1> metricValues,
            int? stepSeconds)
        {
            this.StartEpochMillis = startEpochMillis;
            this.EndEpochMillis = endEpochMillis;
            this.Mode = mode;
            this.StepSeconds = stepSeconds;
            this.MetricDescriptors = metricDescriptors ?? throw new global::System.ArgumentNullException(nameof(metricDescriptors));
            this.MetricValues = metricValues ?? throw new global::System.ArgumentNullException(nameof(metricValues));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxMetricsV1" /> class.
        /// </summary>
        public SandboxMetricsV1()
        {
        }

    }
}