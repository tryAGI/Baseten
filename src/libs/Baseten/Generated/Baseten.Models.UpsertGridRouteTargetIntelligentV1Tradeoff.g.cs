
#nullable enable

namespace Baseten
{
    /// <summary>
    /// How the classifier weighs cost against quality. Must be one of the classifier's supported tradeoffs.
    /// </summary>
    public enum UpsertGridRouteTargetIntelligentV1Tradeoff
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
    public static class UpsertGridRouteTargetIntelligentV1TradeoffExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpsertGridRouteTargetIntelligentV1Tradeoff value)
        {
            return value switch
            {
                UpsertGridRouteTargetIntelligentV1Tradeoff.Balanced => "balanced",
                UpsertGridRouteTargetIntelligentV1Tradeoff.Cost => "cost",
                UpsertGridRouteTargetIntelligentV1Tradeoff.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpsertGridRouteTargetIntelligentV1Tradeoff? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => UpsertGridRouteTargetIntelligentV1Tradeoff.Balanced,
                "cost" => UpsertGridRouteTargetIntelligentV1Tradeoff.Cost,
                "intelligence" => UpsertGridRouteTargetIntelligentV1Tradeoff.Intelligence,
                _ => null,
            };
        }
    }
}