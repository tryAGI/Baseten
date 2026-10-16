
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Preview status, always uppercase.<br/>
    /// Included only in responses<br/>
    /// Example: DEPLOYED
    /// </summary>
    public enum SandboxPreviewStatusV1
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
        /// <summary>
        ///
        /// </summary>
        Terminated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxPreviewStatusV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxPreviewStatusV1 value)
        {
            return value switch
            {
                SandboxPreviewStatusV1.Deleting => "DELETING",
                SandboxPreviewStatusV1.Deployed => "DEPLOYED",
                SandboxPreviewStatusV1.Deploying => "DEPLOYING",
                SandboxPreviewStatusV1.Failed => "FAILED",
                SandboxPreviewStatusV1.Terminated => "TERMINATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxPreviewStatusV1? ToEnum(string value)
        {
            return value switch
            {
                "DELETING" => SandboxPreviewStatusV1.Deleting,
                "DEPLOYED" => SandboxPreviewStatusV1.Deployed,
                "DEPLOYING" => SandboxPreviewStatusV1.Deploying,
                "FAILED" => SandboxPreviewStatusV1.Failed,
                "TERMINATED" => SandboxPreviewStatusV1.Terminated,
                _ => null,
            };
        }
    }
}