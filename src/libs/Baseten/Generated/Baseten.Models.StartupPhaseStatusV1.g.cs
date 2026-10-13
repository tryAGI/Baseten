
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Outcome of one phase, independent of the outcome of the whole startup.
    /// </summary>
    public enum StartupPhaseStatusV1
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
    public static class StartupPhaseStatusV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StartupPhaseStatusV1 value)
        {
            return value switch
            {
                StartupPhaseStatusV1.Completed => "COMPLETED",
                StartupPhaseStatusV1.Failed => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StartupPhaseStatusV1? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => StartupPhaseStatusV1.Completed,
                "FAILED" => StartupPhaseStatusV1.Failed,
                _ => null,
            };
        }
    }
}