
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Coarse grouping of event types, used to filter the audit log.
    /// </summary>
    public enum AuditLogEventTypeGroupV1
    {
        /// <summary>
        /// 
        /// </summary>
        ActivatedDeactivated,
        /// <summary>
        /// 
        /// </summary>
        ApiKeys,
        /// <summary>
        /// 
        /// </summary>
        AutoscalingSettings,
        /// <summary>
        /// 
        /// </summary>
        Deleted,
        /// <summary>
        /// 
        /// </summary>
        Deployed,
        /// <summary>
        /// 
        /// </summary>
        DirectoryGroupManagement,
        /// <summary>
        /// 
        /// </summary>
        EnvironmentSettings,
        /// <summary>
        /// 
        /// </summary>
        Gateway,
        /// <summary>
        /// 
        /// </summary>
        InstanceTypeChanged,
        /// <summary>
        /// 
        /// </summary>
        Promoted,
        /// <summary>
        /// 
        /// </summary>
        ReplicaTerminated,
        /// <summary>
        /// 
        /// </summary>
        Secrets,
        /// <summary>
        /// 
        /// </summary>
        Ssh,
        /// <summary>
        /// 
        /// </summary>
        UserManagement,
        /// <summary>
        /// 
        /// </summary>
        WebhookSigningSecrets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogEventTypeGroupV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogEventTypeGroupV1 value)
        {
            return value switch
            {
                AuditLogEventTypeGroupV1.ActivatedDeactivated => "ACTIVATED_DEACTIVATED",
                AuditLogEventTypeGroupV1.ApiKeys => "API_KEYS",
                AuditLogEventTypeGroupV1.AutoscalingSettings => "AUTOSCALING_SETTINGS",
                AuditLogEventTypeGroupV1.Deleted => "DELETED",
                AuditLogEventTypeGroupV1.Deployed => "DEPLOYED",
                AuditLogEventTypeGroupV1.DirectoryGroupManagement => "DIRECTORY_GROUP_MANAGEMENT",
                AuditLogEventTypeGroupV1.EnvironmentSettings => "ENVIRONMENT_SETTINGS",
                AuditLogEventTypeGroupV1.Gateway => "GATEWAY",
                AuditLogEventTypeGroupV1.InstanceTypeChanged => "INSTANCE_TYPE_CHANGED",
                AuditLogEventTypeGroupV1.Promoted => "PROMOTED",
                AuditLogEventTypeGroupV1.ReplicaTerminated => "REPLICA_TERMINATED",
                AuditLogEventTypeGroupV1.Secrets => "SECRETS",
                AuditLogEventTypeGroupV1.Ssh => "SSH",
                AuditLogEventTypeGroupV1.UserManagement => "USER_MANAGEMENT",
                AuditLogEventTypeGroupV1.WebhookSigningSecrets => "WEBHOOK_SIGNING_SECRETS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogEventTypeGroupV1? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVATED_DEACTIVATED" => AuditLogEventTypeGroupV1.ActivatedDeactivated,
                "API_KEYS" => AuditLogEventTypeGroupV1.ApiKeys,
                "AUTOSCALING_SETTINGS" => AuditLogEventTypeGroupV1.AutoscalingSettings,
                "DELETED" => AuditLogEventTypeGroupV1.Deleted,
                "DEPLOYED" => AuditLogEventTypeGroupV1.Deployed,
                "DIRECTORY_GROUP_MANAGEMENT" => AuditLogEventTypeGroupV1.DirectoryGroupManagement,
                "ENVIRONMENT_SETTINGS" => AuditLogEventTypeGroupV1.EnvironmentSettings,
                "GATEWAY" => AuditLogEventTypeGroupV1.Gateway,
                "INSTANCE_TYPE_CHANGED" => AuditLogEventTypeGroupV1.InstanceTypeChanged,
                "PROMOTED" => AuditLogEventTypeGroupV1.Promoted,
                "REPLICA_TERMINATED" => AuditLogEventTypeGroupV1.ReplicaTerminated,
                "SECRETS" => AuditLogEventTypeGroupV1.Secrets,
                "SSH" => AuditLogEventTypeGroupV1.Ssh,
                "USER_MANAGEMENT" => AuditLogEventTypeGroupV1.UserManagement,
                "WEBHOOK_SIGNING_SECRETS" => AuditLogEventTypeGroupV1.WebhookSigningSecrets,
                _ => null,
            };
        }
    }
}