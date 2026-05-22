
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Metrics for a trainer (Loops) deployment.<br/>
    /// Service-level fields summarize HTTP traffic into the trainer pods (the<br/>
    /// Knative queue-proxy is the source). Compute fields are the leader-pod<br/>
    /// aggregate; ``per_node_metrics`` carries the full multinode breakdown.
    /// </summary>
    public sealed partial class LoopsDeploymentMetricsV1
    {
        /// <summary>
        /// Number of inference requests per unit time (requests per second).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_volume")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> InferenceVolume { get; set; }

        /// <summary>
        /// Number of in-progress concurrent inference requests. Source: the queue-proxy ``revision_queue_depth`` gauge on ``http-usermetric``.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrent_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> ConcurrentRequests { get; set; }

        /// <summary>
        /// Percentiles of the response time distribution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_time_stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ResponseTimeDatapointV1> ResponseTimeStats { get; set; }

        /// <summary>
        /// Request rate split by response code class.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_volume_by_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.InferenceVolumeByStatusDatapointV1> InferenceVolumeByStatus { get; set; }

        /// <summary>
        /// Leader-pod GPU memory bytes per GPU rank.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_memory_usage_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>> GpuMemoryUsageBytes { get; set; }

        /// <summary>
        /// Leader-pod fractional GPU utilization per GPU rank.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_utilization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>> GpuUtilization { get; set; }

        /// <summary>
        /// Leader-pod CPU usage in cores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> CpuUsage { get; set; }

        /// <summary>
        /// Leader-pod CPU memory usage bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_memory_usage_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> CpuMemoryUsageBytes { get; set; }

        /// <summary>
        /// Leader-pod ephemeral storage usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ephemeral_storage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.StorageMetricsV1 EphemeralStorage { get; set; }

        /// <summary>
        /// Per-node compute breakdown for multinode trainer deployments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_node_metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.LoopsDeploymentNodeMetricsV1> PerNodeMetrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsDeploymentMetricsV1" /> class.
        /// </summary>
        /// <param name="inferenceVolume">
        /// Number of inference requests per unit time (requests per second).
        /// </param>
        /// <param name="concurrentRequests">
        /// Number of in-progress concurrent inference requests. Source: the queue-proxy ``revision_queue_depth`` gauge on ``http-usermetric``.
        /// </param>
        /// <param name="responseTimeStats">
        /// Percentiles of the response time distribution.
        /// </param>
        /// <param name="inferenceVolumeByStatus">
        /// Request rate split by response code class.
        /// </param>
        /// <param name="gpuMemoryUsageBytes">
        /// Leader-pod GPU memory bytes per GPU rank.
        /// </param>
        /// <param name="gpuUtilization">
        /// Leader-pod fractional GPU utilization per GPU rank.
        /// </param>
        /// <param name="cpuUsage">
        /// Leader-pod CPU usage in cores.
        /// </param>
        /// <param name="cpuMemoryUsageBytes">
        /// Leader-pod CPU memory usage bytes.
        /// </param>
        /// <param name="ephemeralStorage">
        /// Leader-pod ephemeral storage usage.
        /// </param>
        /// <param name="perNodeMetrics">
        /// Per-node compute breakdown for multinode trainer deployments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsDeploymentMetricsV1(
            global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> inferenceVolume,
            global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> concurrentRequests,
            global::System.Collections.Generic.IList<global::Baseten.ResponseTimeDatapointV1> responseTimeStats,
            global::System.Collections.Generic.IList<global::Baseten.InferenceVolumeByStatusDatapointV1> inferenceVolumeByStatus,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>> gpuMemoryUsageBytes,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>> gpuUtilization,
            global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> cpuUsage,
            global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1> cpuMemoryUsageBytes,
            global::Baseten.StorageMetricsV1 ephemeralStorage,
            global::System.Collections.Generic.IList<global::Baseten.LoopsDeploymentNodeMetricsV1> perNodeMetrics)
        {
            this.InferenceVolume = inferenceVolume ?? throw new global::System.ArgumentNullException(nameof(inferenceVolume));
            this.ConcurrentRequests = concurrentRequests ?? throw new global::System.ArgumentNullException(nameof(concurrentRequests));
            this.ResponseTimeStats = responseTimeStats ?? throw new global::System.ArgumentNullException(nameof(responseTimeStats));
            this.InferenceVolumeByStatus = inferenceVolumeByStatus ?? throw new global::System.ArgumentNullException(nameof(inferenceVolumeByStatus));
            this.GpuMemoryUsageBytes = gpuMemoryUsageBytes ?? throw new global::System.ArgumentNullException(nameof(gpuMemoryUsageBytes));
            this.GpuUtilization = gpuUtilization ?? throw new global::System.ArgumentNullException(nameof(gpuUtilization));
            this.CpuUsage = cpuUsage ?? throw new global::System.ArgumentNullException(nameof(cpuUsage));
            this.CpuMemoryUsageBytes = cpuMemoryUsageBytes ?? throw new global::System.ArgumentNullException(nameof(cpuMemoryUsageBytes));
            this.EphemeralStorage = ephemeralStorage ?? throw new global::System.ArgumentNullException(nameof(ephemeralStorage));
            this.PerNodeMetrics = perNodeMetrics ?? throw new global::System.ArgumentNullException(nameof(perNodeMetrics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsDeploymentMetricsV1" /> class.
        /// </summary>
        public LoopsDeploymentMetricsV1()
        {
        }

    }
}