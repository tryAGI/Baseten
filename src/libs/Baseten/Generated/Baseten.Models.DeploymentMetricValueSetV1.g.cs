
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The metric values for one time step. ``values`` is aligned by index to the<br/>
    /// response ``metric_descriptors`` list.
    /// </summary>
    public sealed partial class DeploymentMetricValueSetV1
    {
        /// <summary>
        /// Start of the step. The step spans until the next value set's start, or the window end for the last one; a summary has a single value set starting at the window start.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_epoch_millis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartEpochMillis { get; set; }

        /// <summary>
        /// Metric values aligned to the ``metric_descriptors`` index. Each entry is a list aligned to that descriptor's ``label_sets`` (a single-element list for a plain metric). A series with no data in this step is null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentMetricValueSetV1" /> class.
        /// </summary>
        /// <param name="startEpochMillis">
        /// Start of the step. The step spans until the next value set's start, or the window end for the last one; a summary has a single value set starting at the window start.
        /// </param>
        /// <param name="values">
        /// Metric values aligned to the ``metric_descriptors`` index. Each entry is a list aligned to that descriptor's ``label_sets`` (a single-element list for a plain metric). A series with no data in this step is null.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentMetricValueSetV1(
            int startEpochMillis,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>> values)
        {
            this.StartEpochMillis = startEpochMillis;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentMetricValueSetV1" /> class.
        /// </summary>
        public DeploymentMetricValueSetV1()
        {
        }

    }
}