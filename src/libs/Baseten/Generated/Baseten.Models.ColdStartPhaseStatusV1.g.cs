
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Outcome of one phase, independent of the outcome of the whole cold start.
    /// </summary>
    public enum ColdStartPhaseStatusV1
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ColdStartPhaseStatusV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColdStartPhaseStatusV1 value)
        {
            return value switch
            {
                ColdStartPhaseStatusV1.Completed => "COMPLETED",
                ColdStartPhaseStatusV1.Failed => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColdStartPhaseStatusV1? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => ColdStartPhaseStatusV1.Completed,
                "FAILED" => ColdStartPhaseStatusV1.Failed,
                _ => null,
            };
        }
    }
}