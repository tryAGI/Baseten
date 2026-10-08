
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxMetricsPointV1
    {
        /// <summary>
        /// Start of this interval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Request count. Zero without traffic; null for intervals entirely before creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public double? Requests { get; set; }

        /// <summary>
        /// Peak CPU usage in this interval, where 100 is one full CPU core. Null without a sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_percent")]
        public double? CpuPercent { get; set; }

        /// <summary>
        /// Memory usage in bytes, averaged per series then maximum across series. Null without a sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_bytes")]
        public double? MemoryBytes { get; set; }

        /// <summary>
        /// Fraction of requests returning 4xx or 5xx. Null when there are no requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_rate")]
        public double? ErrorRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxMetricsPointV1" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// Start of this interval.
        /// </param>
        /// <param name="requests">
        /// Request count. Zero without traffic; null for intervals entirely before creation.
        /// </param>
        /// <param name="cpuPercent">
        /// Peak CPU usage in this interval, where 100 is one full CPU core. Null without a sample.
        /// </param>
        /// <param name="memoryBytes">
        /// Memory usage in bytes, averaged per series then maximum across series. Null without a sample.
        /// </param>
        /// <param name="errorRate">
        /// Fraction of requests returning 4xx or 5xx. Null when there are no requests.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxMetricsPointV1(
            global::System.DateTime timestamp,
            double? requests,
            double? cpuPercent,
            double? memoryBytes,
            double? errorRate)
        {
            this.Timestamp = timestamp;
            this.Requests = requests;
            this.CpuPercent = cpuPercent;
            this.MemoryBytes = memoryBytes;
            this.ErrorRate = errorRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxMetricsPointV1" /> class.
        /// </summary>
        public SandboxMetricsPointV1()
        {
        }

    }
}