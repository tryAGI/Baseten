
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Current execution state when available.<br/>
    /// Included only in responses<br/>
    /// Example: RUNNING
    /// </summary>
    public enum SandboxV1Variant2State
    {
        /// <summary>
        ///
        /// </summary>
        Running,
        /// <summary>
        ///
        /// </summary>
        Standby,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxV1Variant2StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxV1Variant2State value)
        {
            return value switch
            {
                SandboxV1Variant2State.Running => "RUNNING",
                SandboxV1Variant2State.Standby => "STANDBY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxV1Variant2State? ToEnum(string value)
        {
            return value switch
            {
                "RUNNING" => SandboxV1Variant2State.Running,
                "STANDBY" => SandboxV1Variant2State.Standby,
                _ => null,
            };
        }
    }
}