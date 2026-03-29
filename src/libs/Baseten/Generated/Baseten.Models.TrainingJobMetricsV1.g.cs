
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TrainingJobMetricsV1
    {
        /// <summary>
        /// A map of GPU rank to memory usage for the training job. For multinode jobs, this is the memory usage of the leader unless specified otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_memory_usage_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>> GpuMemoryUsageBytes { get; set; }

        /// <summary>
        /// A map of GPU rank to fractional GPU utilization. For multinode jobs, this is the GPU utilization of the leader unless specified otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_utilization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>> GpuUtilization { get; set; }

        /// <summary>
        /// The CPU usage measured in cores. For multinode jobs, this is the CPU usage of the leader unless specified otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> CpuUsage { get; set; }

        /// <summary>
        /// The CPU memory usage for the training job. For multinode jobs, this is the CPU memory usage of the leader unless specified otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_memory_usage_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> CpuMemoryUsageBytes { get; set; }

        /// <summary>
        /// The storage usage for the ephemeral storage. For multinode jobs, this is the ephemeral storage usage of the leader unless specified otherwise.
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
        /// Initializes a new instance of the <see cref="TrainingJobMetricsV1" /> class.
        /// </summary>
        /// <param name="gpuMemoryUsageBytes">
        /// A map of GPU rank to memory usage for the training job. For multinode jobs, this is the memory usage of the leader unless specified otherwise.
        /// </param>
        /// <param name="gpuUtilization">
        /// A map of GPU rank to fractional GPU utilization. For multinode jobs, this is the GPU utilization of the leader unless specified otherwise.
        /// </param>
        /// <param name="cpuUsage">
        /// The CPU usage measured in cores. For multinode jobs, this is the CPU usage of the leader unless specified otherwise.
        /// </param>
        /// <param name="cpuMemoryUsageBytes">
        /// The CPU memory usage for the training job. For multinode jobs, this is the CPU memory usage of the leader unless specified otherwise.
        /// </param>
        /// <param name="ephemeralStorage">
        /// The storage usage for the ephemeral storage. For multinode jobs, this is the ephemeral storage usage of the leader unless specified otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingJobMetricsV1(
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>> gpuMemoryUsageBytes,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>> gpuUtilization,
            global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> cpuUsage,
            global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> cpuMemoryUsageBytes,
            global::Baseten.StorageMetricsV1 ephemeralStorage)
        {
            this.GpuMemoryUsageBytes = gpuMemoryUsageBytes ?? throw new global::System.ArgumentNullException(nameof(gpuMemoryUsageBytes));
            this.GpuUtilization = gpuUtilization ?? throw new global::System.ArgumentNullException(nameof(gpuUtilization));
            this.CpuUsage = cpuUsage ?? throw new global::System.ArgumentNullException(nameof(cpuUsage));
            this.CpuMemoryUsageBytes = cpuMemoryUsageBytes ?? throw new global::System.ArgumentNullException(nameof(cpuMemoryUsageBytes));
            this.EphemeralStorage = ephemeralStorage ?? throw new global::System.ArgumentNullException(nameof(ephemeralStorage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingJobMetricsV1" /> class.
        /// </summary>
        public TrainingJobMetricsV1()
        {
        }
    }
}