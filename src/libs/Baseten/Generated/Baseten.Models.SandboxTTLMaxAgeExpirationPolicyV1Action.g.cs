
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxTTLMaxAgeExpirationPolicyV1Action
    {
        /// <summary>
        ///
        /// </summary>
        Delete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxTTLMaxAgeExpirationPolicyV1ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxTTLMaxAgeExpirationPolicyV1Action value)
        {
            return value switch
            {
                SandboxTTLMaxAgeExpirationPolicyV1Action.Delete => "DELETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxTTLMaxAgeExpirationPolicyV1Action? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => SandboxTTLMaxAgeExpirationPolicyV1Action.Delete,
                _ => null,
            };
        }
    }
}