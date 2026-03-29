
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Enum representing the category of an API key.
    /// </summary>
    public enum APIKeyCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Personal,
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
        WorkspaceManageAll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class APIKeyCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this APIKeyCategory value)
        {
            return value switch
            {
                APIKeyCategory.Personal => "PERSONAL",
                APIKeyCategory.WorkspaceExportMetrics => "WORKSPACE_EXPORT_METRICS",
                APIKeyCategory.WorkspaceInvoke => "WORKSPACE_INVOKE",
                APIKeyCategory.WorkspaceManageAll => "WORKSPACE_MANAGE_ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static APIKeyCategory? ToEnum(string value)
        {
            return value switch
            {
                "PERSONAL" => APIKeyCategory.Personal,
                "WORKSPACE_EXPORT_METRICS" => APIKeyCategory.WorkspaceExportMetrics,
                "WORKSPACE_INVOKE" => APIKeyCategory.WorkspaceInvoke,
                "WORKSPACE_MANAGE_ALL" => APIKeyCategory.WorkspaceManageAll,
                _ => null,
            };
        }
    }
}