
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Outcome of a whole startup attempt.
    /// </summary>
    public enum StartupOutcomeV1
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
    public static class StartupOutcomeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartupOutcomeV1 value)
        {
            return value switch
            {
                StartupOutcomeV1.Failed => "FAILED",
                StartupOutcomeV1.Stalled => "STALLED",
                StartupOutcomeV1.Success => "SUCCESS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartupOutcomeV1? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => StartupOutcomeV1.Failed,
                "STALLED" => StartupOutcomeV1.Stalled,
                "SUCCESS" => StartupOutcomeV1.Success,
                _ => null,
            };
        }
    }
}