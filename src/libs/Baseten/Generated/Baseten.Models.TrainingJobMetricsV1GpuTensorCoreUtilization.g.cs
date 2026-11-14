
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A map of GPU rank to the share of time the GPU tensor cores are active, from 0 to 1. At the top level of a multinode job this is the leader node; under per_node_metrics it is that node.
    /// </summary>
    public sealed partial class TrainingJobMetricsV1GpuTensorCoreUtilization
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}