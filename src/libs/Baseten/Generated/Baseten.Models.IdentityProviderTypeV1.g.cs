
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum IdentityProviderTypeV1
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Predefined,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IdentityProviderTypeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IdentityProviderTypeV1 value)
        {
            return value switch
            {
                IdentityProviderTypeV1.Custom => "CUSTOM",
                IdentityProviderTypeV1.Predefined => "PREDEFINED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IdentityProviderTypeV1? ToEnum(string value)
        {
            return value switch
            {
                "CUSTOM" => IdentityProviderTypeV1.Custom,
                "PREDEFINED" => IdentityProviderTypeV1.Predefined,
                _ => null,
            };
        }
    }
}