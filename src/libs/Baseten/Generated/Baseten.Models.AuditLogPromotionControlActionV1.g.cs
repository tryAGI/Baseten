
#nullable enable

namespace Baseten
{
    /// <summary>
    /// User-initiated promotion control signal recorded on a promotion-control event.
    /// </summary>
    public enum AuditLogPromotionControlActionV1
    {
        /// <summary>
        /// 
        /// </summary>
        ForceCancel,
        /// <summary>
        /// 
        /// </summary>
        ForceRollForward,
        /// <summary>
        /// 
        /// </summary>
        GracefulCancel,
        /// <summary>
        /// 
        /// </summary>
        Pause,
        /// <summary>
        /// 
        /// </summary>
        Resume,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogPromotionControlActionV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogPromotionControlActionV1 value)
        {
            return value switch
            {
                AuditLogPromotionControlActionV1.ForceCancel => "FORCE_CANCEL",
                AuditLogPromotionControlActionV1.ForceRollForward => "FORCE_ROLL_FORWARD",
                AuditLogPromotionControlActionV1.GracefulCancel => "GRACEFUL_CANCEL",
                AuditLogPromotionControlActionV1.Pause => "PAUSE",
                AuditLogPromotionControlActionV1.Resume => "RESUME",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogPromotionControlActionV1? ToEnum(string value)
        {
            return value switch
            {
                "FORCE_CANCEL" => AuditLogPromotionControlActionV1.ForceCancel,
                "FORCE_ROLL_FORWARD" => AuditLogPromotionControlActionV1.ForceRollForward,
                "GRACEFUL_CANCEL" => AuditLogPromotionControlActionV1.GracefulCancel,
                "PAUSE" => AuditLogPromotionControlActionV1.Pause,
                "RESUME" => AuditLogPromotionControlActionV1.Resume,
                _ => null,
            };
        }
    }
}