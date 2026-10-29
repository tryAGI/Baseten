
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Volume status, always uppercase.<br/>
    /// Example: DEPLOYED
    /// </summary>
    public enum SandboxVolumeStatusV1
    {
        /// <summary>
        ///
        /// </summary>
        Deleting,
        /// <summary>
        ///
        /// </summary>
        Deployed,
        /// <summary>
        ///
        /// </summary>
        Deploying,
        /// <summary>
        ///
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxVolumeStatusV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxVolumeStatusV1 value)
        {
            return value switch
            {
                SandboxVolumeStatusV1.Deleting => "DELETING",
                SandboxVolumeStatusV1.Deployed => "DEPLOYED",
                SandboxVolumeStatusV1.Deploying => "DEPLOYING",
                SandboxVolumeStatusV1.Failed => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxVolumeStatusV1? ToEnum(string value)
        {
            return value switch
            {
                "DELETING" => SandboxVolumeStatusV1.Deleting,
                "DEPLOYED" => SandboxVolumeStatusV1.Deployed,
                "DEPLOYING" => SandboxVolumeStatusV1.Deploying,
                "FAILED" => SandboxVolumeStatusV1.Failed,
                _ => null,
            };
        }
    }
}