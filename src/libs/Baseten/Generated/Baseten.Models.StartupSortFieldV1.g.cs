
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Field to sort startup attempts by.
    /// </summary>
    public enum StartupSortFieldV1
    {
        /// <summary>
        ///
        /// </summary>
        Duration,
        /// <summary>
        ///
        /// </summary>
        Outcome,
        /// <summary>
        ///
        /// </summary>
        ReadyAt,
        /// <summary>
        ///
        /// </summary>
        StartedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StartupSortFieldV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartupSortFieldV1 value)
        {
            return value switch
            {
                StartupSortFieldV1.Duration => "DURATION",
                StartupSortFieldV1.Outcome => "OUTCOME",
                StartupSortFieldV1.ReadyAt => "READY_AT",
                StartupSortFieldV1.StartedAt => "STARTED_AT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartupSortFieldV1? ToEnum(string value)
        {
            return value switch
            {
                "DURATION" => StartupSortFieldV1.Duration,
                "OUTCOME" => StartupSortFieldV1.Outcome,
                "READY_AT" => StartupSortFieldV1.ReadyAt,
                "STARTED_AT" => StartupSortFieldV1.StartedAt,
                _ => null,
            };
        }
    }
}