
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum RouteHarnessRole
    {
        /// <summary>
        ///
        /// </summary>
        Background,
        /// <summary>
        ///
        /// </summary>
        Primary,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RouteHarnessRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RouteHarnessRole value)
        {
            return value switch
            {
                RouteHarnessRole.Background => "background",
                RouteHarnessRole.Primary => "primary",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RouteHarnessRole? ToEnum(string value)
        {
            return value switch
            {
                "background" => RouteHarnessRole.Background,
                "primary" => RouteHarnessRole.Primary,
                _ => null,
            };
        }
    }
}