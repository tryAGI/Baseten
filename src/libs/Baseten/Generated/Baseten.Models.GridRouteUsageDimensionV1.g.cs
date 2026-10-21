
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum GridRouteUsageDimensionV1
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
        Router,
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
    public static class GridRouteUsageDimensionV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GridRouteUsageDimensionV1 value)
        {
            return value switch
            {
                GridRouteUsageDimensionV1.Model => "MODEL",
                GridRouteUsageDimensionV1.Provider => "PROVIDER",
                GridRouteUsageDimensionV1.Router => "ROUTER",
                GridRouteUsageDimensionV1.Team => "TEAM",
                GridRouteUsageDimensionV1.User => "USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GridRouteUsageDimensionV1? ToEnum(string value)
        {
            return value switch
            {
                "MODEL" => GridRouteUsageDimensionV1.Model,
                "PROVIDER" => GridRouteUsageDimensionV1.Provider,
                "ROUTER" => GridRouteUsageDimensionV1.Router,
                "TEAM" => GridRouteUsageDimensionV1.Team,
                "USER" => GridRouteUsageDimensionV1.User,
                _ => null,
            };
        }
    }
}