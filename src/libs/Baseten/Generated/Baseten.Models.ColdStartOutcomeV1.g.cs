
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Outcome of a whole cold start attempt.
    /// </summary>
    public enum ColdStartOutcomeV1
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Stalled,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ColdStartOutcomeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ColdStartOutcomeV1 value)
        {
            return value switch
            {
                ColdStartOutcomeV1.Failed => "FAILED",
                ColdStartOutcomeV1.Stalled => "STALLED",
                ColdStartOutcomeV1.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ColdStartOutcomeV1? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => ColdStartOutcomeV1.Failed,
                "STALLED" => ColdStartOutcomeV1.Stalled,
                "SUCCESS" => ColdStartOutcomeV1.Success,
                _ => null,
            };
        }
    }
}