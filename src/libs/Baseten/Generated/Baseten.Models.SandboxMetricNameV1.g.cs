
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxMetricNameV1
    {
        /// <summary>
        ///
        /// </summary>
        BasetenSandboxCpuUsageCores,
        /// <summary>
        ///
        /// </summary>
        BasetenSandboxMemoryBytes,
        /// <summary>
        ///
        /// </summary>
        BasetenSandboxRequestsTotal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxMetricNameV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxMetricNameV1 value)
        {
            return value switch
            {
                SandboxMetricNameV1.BasetenSandboxCpuUsageCores => "baseten_sandbox_cpu_usage_cores",
                SandboxMetricNameV1.BasetenSandboxMemoryBytes => "baseten_sandbox_memory_bytes",
                SandboxMetricNameV1.BasetenSandboxRequestsTotal => "baseten_sandbox_requests_total",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxMetricNameV1? ToEnum(string value)
        {
            return value switch
            {
                "baseten_sandbox_cpu_usage_cores" => SandboxMetricNameV1.BasetenSandboxCpuUsageCores,
                "baseten_sandbox_memory_bytes" => SandboxMetricNameV1.BasetenSandboxMemoryBytes,
                "baseten_sandbox_requests_total" => SandboxMetricNameV1.BasetenSandboxRequestsTotal,
                _ => null,
            };
        }
    }
}