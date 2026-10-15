
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxMetricDescriptorV1Kind
    {
        /// <summary>
        ///
        /// </summary>
        Counter,
        /// <summary>
        ///
        /// </summary>
        Gauge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxMetricDescriptorV1KindExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxMetricDescriptorV1Kind value)
        {
            return value switch
            {
                SandboxMetricDescriptorV1Kind.Counter => "COUNTER",
                SandboxMetricDescriptorV1Kind.Gauge => "GAUGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxMetricDescriptorV1Kind? ToEnum(string value)
        {
            return value switch
            {
                "COUNTER" => SandboxMetricDescriptorV1Kind.Counter,
                "GAUGE" => SandboxMetricDescriptorV1Kind.Gauge,
                _ => null,
            };
        }
    }
}