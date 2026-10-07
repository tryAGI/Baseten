
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxDateExpirationPolicyV1Type
    {
        /// <summary>
        ///
        /// </summary>
        Date,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxDateExpirationPolicyV1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxDateExpirationPolicyV1Type value)
        {
            return value switch
            {
                SandboxDateExpirationPolicyV1Type.Date => "DATE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxDateExpirationPolicyV1Type? ToEnum(string value)
        {
            return value switch
            {
                "DATE" => SandboxDateExpirationPolicyV1Type.Date,
                _ => null,
            };
        }
    }
}