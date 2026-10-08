
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Sandbox deployment status, always uppercase. This tracks provisioning and differs from the execution API state, whose values such as running are lowercase.<br/>
    /// Included only in responses<br/>
    /// Example: DEPLOYED
    /// </summary>
    public enum SandboxStatusV1
    {
        /// <summary>
        ///
        /// </summary>
        Archived,
        /// <summary>
        ///
        /// </summary>
        Archiving,
        /// <summary>
        ///
        /// </summary>
        Building,
        /// <summary>
        ///
        /// </summary>
        Deactivated,
        /// <summary>
        ///
        /// </summary>
        Deactivating,
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
        /// <summary>
        ///
        /// </summary>
        Unarchiving,
        /// <summary>
        ///
        /// </summary>
        Uploading,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxStatusV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxStatusV1 value)
        {
            return value switch
            {
                SandboxStatusV1.Archived => "ARCHIVED",
                SandboxStatusV1.Archiving => "ARCHIVING",
                SandboxStatusV1.Building => "BUILDING",
                SandboxStatusV1.Deactivated => "DEACTIVATED",
                SandboxStatusV1.Deactivating => "DEACTIVATING",
                SandboxStatusV1.Deleting => "DELETING",
                SandboxStatusV1.Deployed => "DEPLOYED",
                SandboxStatusV1.Deploying => "DEPLOYING",
                SandboxStatusV1.Failed => "FAILED",
                SandboxStatusV1.Terminated => "TERMINATED",
                SandboxStatusV1.Unarchiving => "UNARCHIVING",
                SandboxStatusV1.Uploading => "UPLOADING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxStatusV1? ToEnum(string value)
        {
            return value switch
            {
                "ARCHIVED" => SandboxStatusV1.Archived,
                "ARCHIVING" => SandboxStatusV1.Archiving,
                "BUILDING" => SandboxStatusV1.Building,
                "DEACTIVATED" => SandboxStatusV1.Deactivated,
                "DEACTIVATING" => SandboxStatusV1.Deactivating,
                "DELETING" => SandboxStatusV1.Deleting,
                "DEPLOYED" => SandboxStatusV1.Deployed,
                "DEPLOYING" => SandboxStatusV1.Deploying,
                "FAILED" => SandboxStatusV1.Failed,
                "TERMINATED" => SandboxStatusV1.Terminated,
                "UNARCHIVING" => SandboxStatusV1.Unarchiving,
                "UPLOADING" => SandboxStatusV1.Uploading,
                _ => null,
            };
        }
    }
}