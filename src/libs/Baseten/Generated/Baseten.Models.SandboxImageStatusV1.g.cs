
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Image processing status. Only BUILT images are ready to use.<br/>
    /// Included only in responses<br/>
    /// Example: BUILT
    /// </summary>
    public enum SandboxImageStatusV1
    {
        /// <summary>
        ///
        /// </summary>
        Building,
        /// <summary>
        ///
        /// </summary>
        Built,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        Uploading,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxImageStatusV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxImageStatusV1 value)
        {
            return value switch
            {
                SandboxImageStatusV1.Building => "BUILDING",
                SandboxImageStatusV1.Built => "BUILT",
                SandboxImageStatusV1.Failed => "FAILED",
                SandboxImageStatusV1.Uploading => "UPLOADING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxImageStatusV1? ToEnum(string value)
        {
            return value switch
            {
                "BUILDING" => SandboxImageStatusV1.Building,
                "BUILT" => SandboxImageStatusV1.Built,
                "FAILED" => SandboxImageStatusV1.Failed,
                "UPLOADING" => SandboxImageStatusV1.Uploading,
                _ => null,
            };
        }
    }
}