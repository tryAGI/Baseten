
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A map of GPU rank to memory usage for the training job. For multinode jobs, this is the memory usage of the leader unless specified otherwise.
    /// </summary>
    public sealed partial class GetTrainingJobMetricsResponseV1GpuMemoryUsageBytes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}