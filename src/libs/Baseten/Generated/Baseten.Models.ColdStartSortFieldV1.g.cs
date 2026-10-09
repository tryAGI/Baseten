
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Field to sort cold start attempts by.
    /// </summary>
    public enum ColdStartSortFieldV1
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
    public static class ColdStartSortFieldV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColdStartSortFieldV1 value)
        {
            return value switch
            {
                ColdStartSortFieldV1.Duration => "DURATION",
                ColdStartSortFieldV1.Outcome => "OUTCOME",
                ColdStartSortFieldV1.ReadyAt => "READY_AT",
                ColdStartSortFieldV1.StartedAt => "STARTED_AT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColdStartSortFieldV1? ToEnum(string value)
        {
            return value switch
            {
                "DURATION" => ColdStartSortFieldV1.Duration,
                "OUTCOME" => ColdStartSortFieldV1.Outcome,
                "READY_AT" => ColdStartSortFieldV1.ReadyAt,
                "STARTED_AT" => ColdStartSortFieldV1.StartedAt,
                _ => null,
            };
        }
    }
}