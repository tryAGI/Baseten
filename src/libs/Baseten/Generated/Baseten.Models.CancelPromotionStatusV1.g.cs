
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The status of a request to cancel a promotion.
    /// </summary>
    public enum CancelPromotionStatusV1
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        RampingDown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CancelPromotionStatusV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CancelPromotionStatusV1 value)
        {
            return value switch
            {
                CancelPromotionStatusV1.Canceled => "CANCELED",
                CancelPromotionStatusV1.RampingDown => "RAMPING_DOWN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CancelPromotionStatusV1? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => CancelPromotionStatusV1.Canceled,
                "RAMPING_DOWN" => CancelPromotionStatusV1.RampingDown,
                _ => null,
            };
        }
    }
}