
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Describes one metric. Its position in the response ``metric_descriptors``<br/>
    /// list is the index used to read that metric out of each value set's ``values``.<br/>
    /// A metric may break down into multiple labeled series (e.g. latency quantiles,<br/>
    /// or volume by status). ``label_sets`` enumerates those series in order; each<br/>
    /// value set's value for this metric is a list aligned to that order.
    /// </summary>
    public sealed partial class DeploymentMetricDescriptorV1
    {
        /// <summary>
        /// Canonical metric name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Advisory unit of the metric's values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_hint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.DeploymentMetricUnitHintV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentMetricUnitHintV1 UnitHint { get; set; }

        /// <summary>
        /// Semantic hint for how the metric behaves (GAUGE, COUNTER, HISTOGRAM).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.DeploymentMetricKindV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentMetricKindV1 Kind { get; set; }

        /// <summary>
        /// The metric's series, in order. Each entry is the set of labels identifying one series; the value at the same index in each value set's ``values`` is that series' value. A plain metric has a single entry with no labels (`{}`). A histogram has one entry per quantile plus an average, e.g. {'quantile': '0.5'} … {'quantile': '0.99'}, {'stat': 'avg'}. A by-status metric has one entry per status, e.g. {'status': '2xx'}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_sets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>> LabelSets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentMetricDescriptorV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Canonical metric name.
        /// </param>
        /// <param name="unitHint">
        /// Advisory unit of the metric's values.
        /// </param>
        /// <param name="kind">
        /// Semantic hint for how the metric behaves (GAUGE, COUNTER, HISTOGRAM).
        /// </param>
        /// <param name="labelSets">
        /// The metric's series, in order. Each entry is the set of labels identifying one series; the value at the same index in each value set's ``values`` is that series' value. A plain metric has a single entry with no labels (`{}`). A histogram has one entry per quantile plus an average, e.g. {'quantile': '0.5'} … {'quantile': '0.99'}, {'stat': 'avg'}. A by-status metric has one entry per status, e.g. {'status': '2xx'}.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentMetricDescriptorV1(
            string name,
            global::Baseten.DeploymentMetricUnitHintV1 unitHint,
            global::Baseten.DeploymentMetricKindV1 kind,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>> labelSets)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UnitHint = unitHint;
            this.Kind = kind;
            this.LabelSets = labelSets ?? throw new global::System.ArgumentNullException(nameof(labelSets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentMetricDescriptorV1" /> class.
        /// </summary>
        public DeploymentMetricDescriptorV1()
        {
        }

    }
}