
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A set of metrics for a training job node.
    /// </summary>
    public sealed partial class TrainingJobNodeMetricsV1
    {
        /// <summary>
        /// The name of the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// The metrics for the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.TrainingJobMetricsV1 Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingJobNodeMetricsV1" /> class.
        /// </summary>
        /// <param name="nodeId">
        /// The name of the node.
        /// </param>
        /// <param name="metrics">
        /// The metrics for the node.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingJobNodeMetricsV1(
            string nodeId,
            global::Baseten.TrainingJobMetricsV1 metrics)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingJobNodeMetricsV1" /> class.
        /// </summary>
        public TrainingJobNodeMetricsV1()
        {
        }
    }
}