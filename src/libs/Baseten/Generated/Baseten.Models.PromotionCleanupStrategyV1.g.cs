
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The promotion cleanup strategy.
    /// </summary>
    public enum PromotionCleanupStrategyV1
    {
        /// <summary>
        /// 
        /// </summary>
        Deactivate,
        /// <summary>
        /// 
        /// </summary>
        Keep,
        /// <summary>
        /// 
        /// </summary>
        ScaleToZero,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromotionCleanupStrategyV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromotionCleanupStrategyV1 value)
        {
            return value switch
            {
                PromotionCleanupStrategyV1.Deactivate => "DEACTIVATE",
                PromotionCleanupStrategyV1.Keep => "KEEP",
                PromotionCleanupStrategyV1.ScaleToZero => "SCALE_TO_ZERO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromotionCleanupStrategyV1? ToEnum(string value)
        {
            return value switch
            {
                "DEACTIVATE" => PromotionCleanupStrategyV1.Deactivate,
                "KEEP" => PromotionCleanupStrategyV1.Keep,
                "SCALE_TO_ZERO" => PromotionCleanupStrategyV1.ScaleToZero,
                _ => null,
            };
        }
    }
}