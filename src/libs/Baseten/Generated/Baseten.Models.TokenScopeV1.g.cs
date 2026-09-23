
#nullable enable

namespace Baseten
{
    /// <summary>
    /// What a token minted by POST /v1/token grants access to.
    /// </summary>
    public enum TokenScopeV1
    {
        /// <summary>
        ///
        /// </summary>
        Sandboxes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenScopeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenScopeV1 value)
        {
            return value switch
            {
                TokenScopeV1.Sandboxes => "sandboxes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenScopeV1? ToEnum(string value)
        {
            return value switch
            {
                "sandboxes" => TokenScopeV1.Sandboxes,
                _ => null,
            };
        }
    }
}