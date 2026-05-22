
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Per-node compute metrics for a multinode trainer deployment.
    /// </summary>
    public sealed partial class LoopsDeploymentNodeMetricsV1
    {
        /// <summary>
        /// Identifier for the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// GPU memory usage bytes per GPU rank.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_memory_usage_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>> GpuMemoryUsageBytes { get; set; }

        /// <summary>
        /// Fractional GPU utilization per GPU rank.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_utilization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>> GpuUtilization { get; set; }

        /// <summary>
        /// CPU usage in cores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> CpuUsage { get; set; }

        /// <summary>
        /// CPU memory usage bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_memory_usage_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> CpuMemoryUsageBytes { get; set; }

        /// <summary>
        /// Ephemeral storage usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ephemeral_storage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.StorageMetricsV1 EphemeralStorage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsDeploymentNodeMetricsV1" /> class.
        /// </summary>
        /// <param name="nodeId">
        /// Identifier for the node.
        /// </param>
        /// <param name="gpuMemoryUsageBytes">
        /// GPU memory usage bytes per GPU rank.
        /// </param>
        /// <param name="gpuUtilization">
        /// Fractional GPU utilization per GPU rank.
        /// </param>
        /// <param name="cpuUsage">
        /// CPU usage in cores.
        /// </param>
        /// <param name="cpuMemoryUsageBytes">
        /// CPU memory usage bytes.
        /// </param>
        /// <param name="ephemeralStorage">
        /// Ephemeral storage usage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsDeploymentNodeMetricsV1(
            string nodeId,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>> gpuMemoryUsageBytes,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>> gpuUtilization,
            global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> cpuUsage,
            global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> cpuMemoryUsageBytes,
            global::Baseten.StorageMetricsV1 ephemeralStorage)
        {
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.GpuMemoryUsageBytes = gpuMemoryUsageBytes ?? throw new global::System.ArgumentNullException(nameof(gpuMemoryUsageBytes));
            this.GpuUtilization = gpuUtilization ?? throw new global::System.ArgumentNullException(nameof(gpuUtilization));
            this.CpuUsage = cpuUsage ?? throw new global::System.ArgumentNullException(nameof(cpuUsage));
            this.CpuMemoryUsageBytes = cpuMemoryUsageBytes ?? throw new global::System.ArgumentNullException(nameof(cpuMemoryUsageBytes));
            this.EphemeralStorage = ephemeralStorage ?? throw new global::System.ArgumentNullException(nameof(ephemeralStorage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsDeploymentNodeMetricsV1" /> class.
        /// </summary>
        public LoopsDeploymentNodeMetricsV1()
        {
        }

    }
}