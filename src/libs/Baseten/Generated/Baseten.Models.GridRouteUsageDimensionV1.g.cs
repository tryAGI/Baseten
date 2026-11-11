
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
        ApiKey,
        /// <summary>
        ///
        /// </summary>
        Harness,
        /// <summary>
        ///
        /// </summary>
        IntelligentRoute,
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
    public static class GridRouteUsageDimensionV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GridRouteUsageDimensionV1 value)
        {
            return value switch
            {
                GridRouteUsageDimensionV1.ApiKey => "API_KEY",
                GridRouteUsageDimensionV1.Harness => "HARNESS",
                GridRouteUsageDimensionV1.IntelligentRoute => "INTELLIGENT_ROUTE",
                GridRouteUsageDimensionV1.Model => "MODEL",
                GridRouteUsageDimensionV1.Provider => "PROVIDER",
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
                "API_KEY" => GridRouteUsageDimensionV1.ApiKey,
                "HARNESS" => GridRouteUsageDimensionV1.Harness,
                "INTELLIGENT_ROUTE" => GridRouteUsageDimensionV1.IntelligentRoute,
                "MODEL" => GridRouteUsageDimensionV1.Model,
                "PROVIDER" => GridRouteUsageDimensionV1.Provider,
                "TEAM" => GridRouteUsageDimensionV1.Team,
                "USER" => GridRouteUsageDimensionV1.User,
                _ => null,
            };
        }
    }
}