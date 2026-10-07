
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxExpirationPolicyV1DiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Date,
        /// <summary>
        ///
        /// </summary>
        TtlIdle,
        /// <summary>
        ///
        /// </summary>
        TtlMaxAge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxExpirationPolicyV1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxExpirationPolicyV1DiscriminatorType value)
        {
            return value switch
            {
                SandboxExpirationPolicyV1DiscriminatorType.Date => "DATE",
                SandboxExpirationPolicyV1DiscriminatorType.TtlIdle => "TTL_IDLE",
                SandboxExpirationPolicyV1DiscriminatorType.TtlMaxAge => "TTL_MAX_AGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxExpirationPolicyV1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "DATE" => SandboxExpirationPolicyV1DiscriminatorType.Date,
                "TTL_IDLE" => SandboxExpirationPolicyV1DiscriminatorType.TtlIdle,
                "TTL_MAX_AGE" => SandboxExpirationPolicyV1DiscriminatorType.TtlMaxAge,
                _ => null,
            };
        }
    }
}