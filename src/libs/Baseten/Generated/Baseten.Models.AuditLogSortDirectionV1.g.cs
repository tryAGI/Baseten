
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Sort order of returned entries, by creation time.
    /// </summary>
    public enum AuditLogSortDirectionV1
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogSortDirectionV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogSortDirectionV1 value)
        {
            return value switch
            {
                AuditLogSortDirectionV1.Asc => "ASC",
                AuditLogSortDirectionV1.Desc => "DESC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogSortDirectionV1? ToEnum(string value)
        {
            return value switch
            {
                "ASC" => AuditLogSortDirectionV1.Asc,
                "DESC" => AuditLogSortDirectionV1.Desc,
                _ => null,
            };
        }
    }
}