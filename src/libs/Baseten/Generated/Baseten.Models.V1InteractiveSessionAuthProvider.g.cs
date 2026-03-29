
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum V1InteractiveSessionAuthProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Github,
        /// <summary>
        /// 
        /// </summary>
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class V1InteractiveSessionAuthProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this V1InteractiveSessionAuthProvider value)
        {
            return value switch
            {
                V1InteractiveSessionAuthProvider.Github => "github",
                V1InteractiveSessionAuthProvider.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static V1InteractiveSessionAuthProvider? ToEnum(string value)
        {
            return value switch
            {
                "github" => V1InteractiveSessionAuthProvider.Github,
                "microsoft" => V1InteractiveSessionAuthProvider.Microsoft,
                _ => null,
            };
        }
    }
}