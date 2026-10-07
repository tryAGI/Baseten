
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The protocol of the port<br/>
    /// Example: HTTP
    /// </summary>
    public enum SandboxPortV1Protocol
    {
        /// <summary>
        ///
        /// </summary>
        Http,
        /// <summary>
        ///
        /// </summary>
        Tcp,
        /// <summary>
        ///
        /// </summary>
        Tls,
        /// <summary>
        ///
        /// </summary>
        Udp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxPortV1ProtocolExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxPortV1Protocol value)
        {
            return value switch
            {
                SandboxPortV1Protocol.Http => "HTTP",
                SandboxPortV1Protocol.Tcp => "TCP",
                SandboxPortV1Protocol.Tls => "TLS",
                SandboxPortV1Protocol.Udp => "UDP",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxPortV1Protocol? ToEnum(string value)
        {
            return value switch
            {
                "HTTP" => SandboxPortV1Protocol.Http,
                "TCP" => SandboxPortV1Protocol.Tcp,
                "TLS" => SandboxPortV1Protocol.Tls,
                "UDP" => SandboxPortV1Protocol.Udp,
                _ => null,
            };
        }
    }
}