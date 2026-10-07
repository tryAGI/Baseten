
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxTTLMaxAgeExpirationPolicyV1Type
    {
        /// <summary>
        ///
        /// </summary>
        TtlMaxAge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxTTLMaxAgeExpirationPolicyV1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxTTLMaxAgeExpirationPolicyV1Type value)
        {
            return value switch
            {
                SandboxTTLMaxAgeExpirationPolicyV1Type.TtlMaxAge => "TTL_MAX_AGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxTTLMaxAgeExpirationPolicyV1Type? ToEnum(string value)
        {
            return value switch
            {
                "TTL_MAX_AGE" => SandboxTTLMaxAgeExpirationPolicyV1Type.TtlMaxAge,
                _ => null,
            };
        }
    }
}