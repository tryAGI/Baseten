
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A map of GPU rank to the share of time the GPU's streaming multiprocessors have work assigned, from 0 to 1. This counts any GPU work, not only tensor core math; see gpu_tensor_core_utilization for that. At the top level of a multinode job this is the leader node; under per_node_metrics it is that node.
    /// </summary>
    public sealed partial class TrainingJobMetricsV1GpuUtilization
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}