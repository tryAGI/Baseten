
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxTTLIdleExpirationPolicyV1Type
    {
        /// <summary>
        ///
        /// </summary>
        TtlIdle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxTTLIdleExpirationPolicyV1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxTTLIdleExpirationPolicyV1Type value)
        {
            return value switch
            {
                SandboxTTLIdleExpirationPolicyV1Type.TtlIdle => "TTL_IDLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxTTLIdleExpirationPolicyV1Type? ToEnum(string value)
        {
            return value switch
            {
                "TTL_IDLE" => SandboxTTLIdleExpirationPolicyV1Type.TtlIdle,
                _ => null,
            };
        }
    }
}