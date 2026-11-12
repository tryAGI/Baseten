
#nullable enable

namespace Baseten
{
    /// <summary>
    /// What a service account may do: the workspace API key categories, plus Model APIs.<br/>
    /// Temporary: mirrors API key access until fine-grained access control is available, and may be removed.
    /// </summary>
    public enum ServiceAccountPresetTypeV1
    {
        /// <summary>
        ///
        /// </summary>
        WorkspaceExportMetrics,
        /// <summary>
        ///
        /// </summary>
        WorkspaceInvoke,
        /// <summary>
        ///
        /// </summary>
        WorkspaceInvokeModelApis,
        /// <summary>
        ///
        /// </summary>
        WorkspaceManageAll,
        /// <summary>
        ///
        /// </summary>
        WorkspaceManageApiKeys,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServiceAccountPresetTypeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServiceAccountPresetTypeV1 value)
        {
            return value switch
            {
                ServiceAccountPresetTypeV1.WorkspaceExportMetrics => "WORKSPACE_EXPORT_METRICS",
                ServiceAccountPresetTypeV1.WorkspaceInvoke => "WORKSPACE_INVOKE",
                ServiceAccountPresetTypeV1.WorkspaceInvokeModelApis => "WORKSPACE_INVOKE_MODEL_APIS",
                ServiceAccountPresetTypeV1.WorkspaceManageAll => "WORKSPACE_MANAGE_ALL",
                ServiceAccountPresetTypeV1.WorkspaceManageApiKeys => "WORKSPACE_MANAGE_API_KEYS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServiceAccountPresetTypeV1? ToEnum(string value)
        {
            return value switch
            {
                "WORKSPACE_EXPORT_METRICS" => ServiceAccountPresetTypeV1.WorkspaceExportMetrics,
                "WORKSPACE_INVOKE" => ServiceAccountPresetTypeV1.WorkspaceInvoke,
                "WORKSPACE_INVOKE_MODEL_APIS" => ServiceAccountPresetTypeV1.WorkspaceInvokeModelApis,
                "WORKSPACE_MANAGE_ALL" => ServiceAccountPresetTypeV1.WorkspaceManageAll,
                "WORKSPACE_MANAGE_API_KEYS" => ServiceAccountPresetTypeV1.WorkspaceManageApiKeys,
                _ => null,
            };
        }
    }
}