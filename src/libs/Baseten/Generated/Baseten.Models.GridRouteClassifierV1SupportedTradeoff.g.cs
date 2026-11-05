
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public enum GridRouteClassifierV1SupportedTradeoff
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
    public static class GridRouteClassifierV1SupportedTradeoffExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GridRouteClassifierV1SupportedTradeoff value)
        {
            return value switch
            {
                GridRouteClassifierV1SupportedTradeoff.Balanced => "balanced",
                GridRouteClassifierV1SupportedTradeoff.Cost => "cost",
                GridRouteClassifierV1SupportedTradeoff.Intelligence => "intelligence",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GridRouteClassifierV1SupportedTradeoff? ToEnum(string value)
        {
            return value switch
            {
                "balanced" => GridRouteClassifierV1SupportedTradeoff.Balanced,
                "cost" => GridRouteClassifierV1SupportedTradeoff.Cost,
                "intelligence" => GridRouteClassifierV1SupportedTradeoff.Intelligence,
                _ => null,
            };
        }
    }
}