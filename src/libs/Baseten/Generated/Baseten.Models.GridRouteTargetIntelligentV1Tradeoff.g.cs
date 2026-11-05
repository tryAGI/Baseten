
#nullable enable

namespace Baseten
{
    /// <summary>
    /// How the classifier weighs cost against quality.
    /// </summary>
    public enum GridRouteTargetIntelligentV1Tradeoff
    {
        /// <summary>
        ///
        /// </summary>
        Balanced,
        /// <summary>
        ///
        /// </summary>
        Cost,
        /// <summary>
        ///
        /// </summary>
        Intelligence,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GridRouteTargetIntelligentV1TradeoffExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GridRouteTargetIntelligentV1Tradeoff value)
        {
            return value switch
            {
                GridRouteTargetIntelligentV1Tradeoff.Balanced => "balanced",
                GridRouteTargetIntelligentV1Tradeoff.Cost => "cost",
                GridRouteTargetIntelligentV1Tradeoff.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GridRouteTargetIntelligentV1Tradeoff? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => GridRouteTargetIntelligentV1Tradeoff.Balanced,
                "cost" => GridRouteTargetIntelligentV1Tradeoff.Cost,
                "intelligence" => GridRouteTargetIntelligentV1Tradeoff.Intelligence,
                _ => null,
            };
        }
    }
}