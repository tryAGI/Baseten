
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum RouteUsageDimensionV1
    {
        /// <summary>
        ///
        /// </summary>
        Model,
        /// <summary>
        ///
        /// </summary>
        Provider,
        /// <summary>
        ///
        /// </summary>
        Team,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RouteUsageDimensionV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RouteUsageDimensionV1 value)
        {
            return value switch
            {
                RouteUsageDimensionV1.Model => "MODEL",
                RouteUsageDimensionV1.Provider => "PROVIDER",
                RouteUsageDimensionV1.Team => "TEAM",
                RouteUsageDimensionV1.User => "USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RouteUsageDimensionV1? ToEnum(string value)
        {
            return value switch
            {
                "MODEL" => RouteUsageDimensionV1.Model,
                "PROVIDER" => RouteUsageDimensionV1.Provider,
                "TEAM" => RouteUsageDimensionV1.Team,
                "USER" => RouteUsageDimensionV1.User,
                _ => null,
            };
        }
    }
}