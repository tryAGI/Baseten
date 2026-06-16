
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A log severity level.
    /// </summary>
    public enum LogLevelV1
    {
        /// <summary>
        /// 
        /// </summary>
        Debug,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LogLevelV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LogLevelV1 value)
        {
            return value switch
            {
                LogLevelV1.Debug => "DEBUG",
                LogLevelV1.Error => "ERROR",
                LogLevelV1.Info => "INFO",
                LogLevelV1.Warning => "WARNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LogLevelV1? ToEnum(string value)
        {
            return value switch
            {
                "DEBUG" => LogLevelV1.Debug,
                "ERROR" => LogLevelV1.Error,
                "INFO" => LogLevelV1.Info,
                "WARNING" => LogLevelV1.Warning,
                _ => null,
            };
        }
    }
}