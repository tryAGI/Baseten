
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Kind of actor that performed an audited action.
    /// </summary>
    public enum AuditLogActorTypeV1
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        BasetenSystem,
        /// <summary>
        /// 
        /// </summary>
        BasetenUser,
        /// <summary>
        /// 
        /// </summary>
        TombstoneUser,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogActorTypeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogActorTypeV1 value)
        {
            return value switch
            {
                AuditLogActorTypeV1.ApiKey => "API_KEY",
                AuditLogActorTypeV1.BasetenSystem => "BASETEN_SYSTEM",
                AuditLogActorTypeV1.BasetenUser => "BASETEN_USER",
                AuditLogActorTypeV1.TombstoneUser => "TOMBSTONE_USER",
                AuditLogActorTypeV1.User => "USER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogActorTypeV1? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => AuditLogActorTypeV1.ApiKey,
                "BASETEN_SYSTEM" => AuditLogActorTypeV1.BasetenSystem,
                "BASETEN_USER" => AuditLogActorTypeV1.BasetenUser,
                "TOMBSTONE_USER" => AuditLogActorTypeV1.TombstoneUser,
                "USER" => AuditLogActorTypeV1.User,
                _ => null,
            };
        }
    }
}