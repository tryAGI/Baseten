
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum InProgressPromotionStatusV1
    {
        /// <summary>
        /// 
        /// </summary>
        Canceled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Paused,
        /// <summary>
        /// 
        /// </summary>
        RampingDown,
        /// <summary>
        /// 
        /// </summary>
        RampingUp,
        /// <summary>
        /// 
        /// </summary>
        Releasing,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InProgressPromotionStatusV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InProgressPromotionStatusV1 value)
        {
            return value switch
            {
                InProgressPromotionStatusV1.Canceled => "CANCELED",
                InProgressPromotionStatusV1.Failed => "FAILED",
                InProgressPromotionStatusV1.Paused => "PAUSED",
                InProgressPromotionStatusV1.RampingDown => "RAMPING_DOWN",
                InProgressPromotionStatusV1.RampingUp => "RAMPING_UP",
                InProgressPromotionStatusV1.Releasing => "RELEASING",
                InProgressPromotionStatusV1.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InProgressPromotionStatusV1? ToEnum(string value)
        {
            return value switch
            {
                "CANCELED" => InProgressPromotionStatusV1.Canceled,
                "FAILED" => InProgressPromotionStatusV1.Failed,
                "PAUSED" => InProgressPromotionStatusV1.Paused,
                "RAMPING_DOWN" => InProgressPromotionStatusV1.RampingDown,
                "RAMPING_UP" => InProgressPromotionStatusV1.RampingUp,
                "RELEASING" => InProgressPromotionStatusV1.Releasing,
                "SUCCEEDED" => InProgressPromotionStatusV1.Succeeded,
                _ => null,
            };
        }
    }
}