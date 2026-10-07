
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxTTLIdleExpirationPolicyV1Action
    {
        /// <summary>
        ///
        /// </summary>
        Delete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxTTLIdleExpirationPolicyV1ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxTTLIdleExpirationPolicyV1Action value)
        {
            return value switch
            {
                SandboxTTLIdleExpirationPolicyV1Action.Delete => "DELETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxTTLIdleExpirationPolicyV1Action? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => SandboxTTLIdleExpirationPolicyV1Action.Delete,
                _ => null,
            };
        }
    }
}