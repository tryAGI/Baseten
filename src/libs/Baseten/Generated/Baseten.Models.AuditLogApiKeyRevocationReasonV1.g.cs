
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Reason an API key was revoked.
    /// </summary>
    public enum AuditLogApiKeyRevocationReasonV1
    {
        /// <summary>
        ///
        /// </summary>
        Inactivity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogApiKeyRevocationReasonV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogApiKeyRevocationReasonV1 value)
        {
            return value switch
            {
                AuditLogApiKeyRevocationReasonV1.Inactivity => "INACTIVITY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogApiKeyRevocationReasonV1? ToEnum(string value)
        {
            return value switch
            {
                "INACTIVITY" => AuditLogApiKeyRevocationReasonV1.Inactivity,
                _ => null,
            };
        }
    }
}