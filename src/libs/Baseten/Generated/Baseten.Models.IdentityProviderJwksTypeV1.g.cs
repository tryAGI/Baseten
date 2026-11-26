
#nullable enable

namespace Baseten
{
    /// <summary>
    /// How Baseten finds a custom identity provider's signing keys.
    /// </summary>
    public enum IdentityProviderJwksTypeV1
    {
        /// <summary>
        ///
        /// </summary>
        Discovery,
        /// <summary>
        ///
        /// </summary>
        ExplicitUrl,
        /// <summary>
        ///
        /// </summary>
        Inline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdentityProviderJwksTypeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentityProviderJwksTypeV1 value)
        {
            return value switch
            {
                IdentityProviderJwksTypeV1.Discovery => "DISCOVERY",
                IdentityProviderJwksTypeV1.ExplicitUrl => "EXPLICIT_URL",
                IdentityProviderJwksTypeV1.Inline => "INLINE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentityProviderJwksTypeV1? ToEnum(string value)
        {
            return value switch
            {
                "DISCOVERY" => IdentityProviderJwksTypeV1.Discovery,
                "EXPLICIT_URL" => IdentityProviderJwksTypeV1.ExplicitUrl,
                "INLINE" => IdentityProviderJwksTypeV1.Inline,
                _ => null,
            };
        }
    }
}