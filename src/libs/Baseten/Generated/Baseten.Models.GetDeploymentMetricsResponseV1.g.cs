
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Deployment metrics over a time window, index-mapped: metric descriptors<br/>
    /// appear once in ``metric_descriptors``; each value set's ``values`` are aligned<br/>
    /// to that order.
    /// </summary>
    public sealed partial class GetDeploymentMetricsResponseV1
    {
        /// <summary>
        /// Start of the returned window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_epoch_millis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartEpochMillis { get; set; }

        /// <summary>
        /// End of the returned window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_epoch_millis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndEpochMillis { get; set; }

        /// <summary>
        /// The aggregation mode used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.DeploymentMetricModeV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentMetricModeV1 Mode { get; set; }

        /// <summary>
        /// Seconds per step; populated only in SERIES mode, null otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_seconds")]
        public int? StepSeconds { get; set; }

        /// <summary>
        /// Descriptors for each metric; position defines the values index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_descriptors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.DeploymentMetricDescriptorV1> MetricDescriptors { get; set; }

        /// <summary>
        /// Metric values per time step covering the window. In summary mode this always contains exactly one value set spanning the whole window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.DeploymentMetricValueSetV1> MetricValues { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeploymentMetricsResponseV1" /> class.
        /// </summary>
        /// <param name="startEpochMillis">
        /// Start of the returned window.
        /// </param>
        /// <param name="endEpochMillis">
        /// End of the returned window.
        /// </param>
        /// <param name="mode">
        /// The aggregation mode used.
        /// </param>
        /// <param name="metricDescriptors">
        /// Descriptors for each metric; position defines the values index.
        /// </param>
        /// <param name="metricValues">
        /// Metric values per time step covering the window. In summary mode this always contains exactly one value set spanning the whole window.
        /// </param>
        /// <param name="stepSeconds">
        /// Seconds per step; populated only in SERIES mode, null otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDeploymentMetricsResponseV1(
            int startEpochMillis,
            int endEpochMillis,
            global::Baseten.DeploymentMetricModeV1 mode,
            global::System.Collections.Generic.IList<global::Baseten.DeploymentMetricDescriptorV1> metricDescriptors,
            global::System.Collections.Generic.IList<global::Baseten.DeploymentMetricValueSetV1> metricValues,
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
        /// Initializes a new instance of the <see cref="GetDeploymentMetricsResponseV1" /> class.
        /// </summary>
        public GetDeploymentMetricsResponseV1()
        {
        }

    }
}