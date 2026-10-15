
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Requests use COUNT, CPU uses CORES (1 means one fully used core), and memory uses BYTES.
    /// </summary>
    public enum SandboxMetricDescriptorV1UnitHint
    {
        /// <summary>
        ///
        /// </summary>
        Bytes,
        /// <summary>
        ///
        /// </summary>
        Cores,
        /// <summary>
        ///
        /// </summary>
        Count,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxMetricDescriptorV1UnitHintExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxMetricDescriptorV1UnitHint value)
        {
            return value switch
            {
                SandboxMetricDescriptorV1UnitHint.Bytes => "BYTES",
                SandboxMetricDescriptorV1UnitHint.Cores => "CORES",
                SandboxMetricDescriptorV1UnitHint.Count => "COUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxMetricDescriptorV1UnitHint? ToEnum(string value)
        {
            return value switch
            {
                "BYTES" => SandboxMetricDescriptorV1UnitHint.Bytes,
                "CORES" => SandboxMetricDescriptorV1UnitHint.Cores,
                "COUNT" => SandboxMetricDescriptorV1UnitHint.Count,
                _ => null,
            };
        }
    }
}