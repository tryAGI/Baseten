
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Surface that issued the audited action.
    /// </summary>
    public enum AuditLogSourceV1
    {
        /// <summary>
        /// 
        /// </summary>
        Api,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        Other,
        /// <summary>
        /// 
        /// </summary>
        Ui,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogSourceV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogSourceV1 value)
        {
            return value switch
            {
                AuditLogSourceV1.Api => "API",
                AuditLogSourceV1.Mcp => "MCP",
                AuditLogSourceV1.Other => "OTHER",
                AuditLogSourceV1.Ui => "UI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogSourceV1? ToEnum(string value)
        {
            return value switch
            {
                "API" => AuditLogSourceV1.Api,
                "MCP" => AuditLogSourceV1.Mcp,
                "OTHER" => AuditLogSourceV1.Other,
                "UI" => AuditLogSourceV1.Ui,
                _ => null,
            };
        }
    }
}