
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum SandboxDateExpirationPolicyV1Action
    {
        /// <summary>
        ///
        /// </summary>
        Delete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxDateExpirationPolicyV1ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxDateExpirationPolicyV1Action value)
        {
            return value switch
            {
                SandboxDateExpirationPolicyV1Action.Delete => "DELETE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxDateExpirationPolicyV1Action? ToEnum(string value)
        {
            return value switch
            {
                "DELETE" => SandboxDateExpirationPolicyV1Action.Delete,
                _ => null,
            };
        }
    }
}