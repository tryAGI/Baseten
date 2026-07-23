
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Type of API key recorded on an API-key event.
    /// </summary>
    public enum AuditLogApiKeyTypeV1
    {
        /// <summary>
        /// 
        /// </summary>
        CreatorServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        ExportMetricsAllowedModelsServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        ExportMetricsAllModelsServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        InvokeAllowedModelsServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        InvokeAllowedSharedEndpointsServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        InvokeAllModelsServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        InvokeAllSharedEndpointsServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        InvokeScopedEnvsAndModelsServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        ManageApiKeysServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        Personal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogApiKeyTypeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogApiKeyTypeV1 value)
        {
            return value switch
            {
                AuditLogApiKeyTypeV1.CreatorServiceAccount => "CREATOR_SERVICE_ACCOUNT",
                AuditLogApiKeyTypeV1.ExportMetricsAllowedModelsServiceAccount => "EXPORT_METRICS_ALLOWED_MODELS_SERVICE_ACCOUNT",
                AuditLogApiKeyTypeV1.ExportMetricsAllModelsServiceAccount => "EXPORT_METRICS_ALL_MODELS_SERVICE_ACCOUNT",
                AuditLogApiKeyTypeV1.InvokeAllowedModelsServiceAccount => "INVOKE_ALLOWED_MODELS_SERVICE_ACCOUNT",
                AuditLogApiKeyTypeV1.InvokeAllowedSharedEndpointsServiceAccount => "INVOKE_ALLOWED_SHARED_ENDPOINTS_SERVICE_ACCOUNT",
                AuditLogApiKeyTypeV1.InvokeAllModelsServiceAccount => "INVOKE_ALL_MODELS_SERVICE_ACCOUNT",
                AuditLogApiKeyTypeV1.InvokeAllSharedEndpointsServiceAccount => "INVOKE_ALL_SHARED_ENDPOINTS_SERVICE_ACCOUNT",
                AuditLogApiKeyTypeV1.InvokeScopedEnvsAndModelsServiceAccount => "INVOKE_SCOPED_ENVS_AND_MODELS_SERVICE_ACCOUNT",
                AuditLogApiKeyTypeV1.ManageApiKeysServiceAccount => "MANAGE_API_KEYS_SERVICE_ACCOUNT",
                AuditLogApiKeyTypeV1.Personal => "PERSONAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogApiKeyTypeV1? ToEnum(string value)
        {
            return value switch
            {
                "CREATOR_SERVICE_ACCOUNT" => AuditLogApiKeyTypeV1.CreatorServiceAccount,
                "EXPORT_METRICS_ALLOWED_MODELS_SERVICE_ACCOUNT" => AuditLogApiKeyTypeV1.ExportMetricsAllowedModelsServiceAccount,
                "EXPORT_METRICS_ALL_MODELS_SERVICE_ACCOUNT" => AuditLogApiKeyTypeV1.ExportMetricsAllModelsServiceAccount,
                "INVOKE_ALLOWED_MODELS_SERVICE_ACCOUNT" => AuditLogApiKeyTypeV1.InvokeAllowedModelsServiceAccount,
                "INVOKE_ALLOWED_SHARED_ENDPOINTS_SERVICE_ACCOUNT" => AuditLogApiKeyTypeV1.InvokeAllowedSharedEndpointsServiceAccount,
                "INVOKE_ALL_MODELS_SERVICE_ACCOUNT" => AuditLogApiKeyTypeV1.InvokeAllModelsServiceAccount,
                "INVOKE_ALL_SHARED_ENDPOINTS_SERVICE_ACCOUNT" => AuditLogApiKeyTypeV1.InvokeAllSharedEndpointsServiceAccount,
                "INVOKE_SCOPED_ENVS_AND_MODELS_SERVICE_ACCOUNT" => AuditLogApiKeyTypeV1.InvokeScopedEnvsAndModelsServiceAccount,
                "MANAGE_API_KEYS_SERVICE_ACCOUNT" => AuditLogApiKeyTypeV1.ManageApiKeysServiceAccount,
                "PERSONAL" => AuditLogApiKeyTypeV1.Personal,
                _ => null,
            };
        }
    }
}