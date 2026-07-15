
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Type of action recorded by an audit-log entry.
    /// </summary>
    public enum AuditLogEventTypeV1
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKeyCreated,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyDeleted,
        /// <summary>
        /// 
        /// </summary>
        ChainletAutoscalingSettingsChanged,
        /// <summary>
        /// 
        /// </summary>
        ChainletInstanceTypeChanged,
        /// <summary>
        /// 
        /// </summary>
        ChainDeleted,
        /// <summary>
        /// 
        /// </summary>
        ChainDeployed,
        /// <summary>
        /// 
        /// </summary>
        ChainDeploymentActivated,
        /// <summary>
        /// 
        /// </summary>
        ChainDeploymentDeactivated,
        /// <summary>
        /// 
        /// </summary>
        ChainDeploymentDeleted,
        /// <summary>
        /// 
        /// </summary>
        ChainDeploymentPromoted,
        /// <summary>
        /// 
        /// </summary>
        ChainEnvironmentCreated,
        /// <summary>
        /// 
        /// </summary>
        ChainEnvironmentUpdated,
        /// <summary>
        /// 
        /// </summary>
        DirectoryGroupRoleUpdated,
        /// <summary>
        /// 
        /// </summary>
        EnvironmentCreated,
        /// <summary>
        /// 
        /// </summary>
        EnvironmentDeleted,
        /// <summary>
        /// 
        /// </summary>
        EnvironmentUpdated,
        /// <summary>
        /// 
        /// </summary>
        GatewayEndpointCreated,
        /// <summary>
        /// 
        /// </summary>
        GatewayEndpointDeleted,
        /// <summary>
        /// 
        /// </summary>
        GatewayEndpointUpdated,
        /// <summary>
        /// 
        /// </summary>
        ModelDeleted,
        /// <summary>
        /// 
        /// </summary>
        ModelDeployed,
        /// <summary>
        /// 
        /// </summary>
        ModelDeploymentActivated,
        /// <summary>
        /// 
        /// </summary>
        ModelDeploymentAutoscalingSettingsChanged,
        /// <summary>
        /// 
        /// </summary>
        ModelDeploymentDeactivated,
        /// <summary>
        /// 
        /// </summary>
        ModelDeploymentDeleted,
        /// <summary>
        /// 
        /// </summary>
        ModelDeploymentInstanceTypeChanged,
        /// <summary>
        /// 
        /// </summary>
        ModelDeploymentPromoted,
        /// <summary>
        /// 
        /// </summary>
        ModelDeploymentRetried,
        /// <summary>
        /// 
        /// </summary>
        ModelPromotionControlAction,
        /// <summary>
        /// 
        /// </summary>
        ReplicaTerminated,
        /// <summary>
        /// 
        /// </summary>
        RequireGroupBasedAdminsEnabled,
        /// <summary>
        /// 
        /// </summary>
        SecretDeleted,
        /// <summary>
        /// 
        /// </summary>
        SecretUpdated,
        /// <summary>
        /// 
        /// </summary>
        SshCertificateSigned,
        /// <summary>
        /// 
        /// </summary>
        UserInvited,
        /// <summary>
        /// 
        /// </summary>
        UserJoinedOrganization,
        /// <summary>
        /// 
        /// </summary>
        UserRemoved,
        /// <summary>
        /// 
        /// </summary>
        UserRoleUpdated,
        /// <summary>
        /// 
        /// </summary>
        UserTeamRoleUpdated,
        /// <summary>
        /// 
        /// </summary>
        WebhookSigningSecretCreated,
        /// <summary>
        /// 
        /// </summary>
        WebhookSigningSecretDeleted,
        /// <summary>
        /// 
        /// </summary>
        WebhookSigningSecretRotated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogEventTypeV1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogEventTypeV1 value)
        {
            return value switch
            {
                AuditLogEventTypeV1.ApiKeyCreated => "API_KEY_CREATED",
                AuditLogEventTypeV1.ApiKeyDeleted => "API_KEY_DELETED",
                AuditLogEventTypeV1.ChainletAutoscalingSettingsChanged => "CHAINLET_AUTOSCALING_SETTINGS_CHANGED",
                AuditLogEventTypeV1.ChainletInstanceTypeChanged => "CHAINLET_INSTANCE_TYPE_CHANGED",
                AuditLogEventTypeV1.ChainDeleted => "CHAIN_DELETED",
                AuditLogEventTypeV1.ChainDeployed => "CHAIN_DEPLOYED",
                AuditLogEventTypeV1.ChainDeploymentActivated => "CHAIN_DEPLOYMENT_ACTIVATED",
                AuditLogEventTypeV1.ChainDeploymentDeactivated => "CHAIN_DEPLOYMENT_DEACTIVATED",
                AuditLogEventTypeV1.ChainDeploymentDeleted => "CHAIN_DEPLOYMENT_DELETED",
                AuditLogEventTypeV1.ChainDeploymentPromoted => "CHAIN_DEPLOYMENT_PROMOTED",
                AuditLogEventTypeV1.ChainEnvironmentCreated => "CHAIN_ENVIRONMENT_CREATED",
                AuditLogEventTypeV1.ChainEnvironmentUpdated => "CHAIN_ENVIRONMENT_UPDATED",
                AuditLogEventTypeV1.DirectoryGroupRoleUpdated => "DIRECTORY_GROUP_ROLE_UPDATED",
                AuditLogEventTypeV1.EnvironmentCreated => "ENVIRONMENT_CREATED",
                AuditLogEventTypeV1.EnvironmentDeleted => "ENVIRONMENT_DELETED",
                AuditLogEventTypeV1.EnvironmentUpdated => "ENVIRONMENT_UPDATED",
                AuditLogEventTypeV1.GatewayEndpointCreated => "GATEWAY_ENDPOINT_CREATED",
                AuditLogEventTypeV1.GatewayEndpointDeleted => "GATEWAY_ENDPOINT_DELETED",
                AuditLogEventTypeV1.GatewayEndpointUpdated => "GATEWAY_ENDPOINT_UPDATED",
                AuditLogEventTypeV1.ModelDeleted => "MODEL_DELETED",
                AuditLogEventTypeV1.ModelDeployed => "MODEL_DEPLOYED",
                AuditLogEventTypeV1.ModelDeploymentActivated => "MODEL_DEPLOYMENT_ACTIVATED",
                AuditLogEventTypeV1.ModelDeploymentAutoscalingSettingsChanged => "MODEL_DEPLOYMENT_AUTOSCALING_SETTINGS_CHANGED",
                AuditLogEventTypeV1.ModelDeploymentDeactivated => "MODEL_DEPLOYMENT_DEACTIVATED",
                AuditLogEventTypeV1.ModelDeploymentDeleted => "MODEL_DEPLOYMENT_DELETED",
                AuditLogEventTypeV1.ModelDeploymentInstanceTypeChanged => "MODEL_DEPLOYMENT_INSTANCE_TYPE_CHANGED",
                AuditLogEventTypeV1.ModelDeploymentPromoted => "MODEL_DEPLOYMENT_PROMOTED",
                AuditLogEventTypeV1.ModelDeploymentRetried => "MODEL_DEPLOYMENT_RETRIED",
                AuditLogEventTypeV1.ModelPromotionControlAction => "MODEL_PROMOTION_CONTROL_ACTION",
                AuditLogEventTypeV1.ReplicaTerminated => "REPLICA_TERMINATED",
                AuditLogEventTypeV1.RequireGroupBasedAdminsEnabled => "REQUIRE_GROUP_BASED_ADMINS_ENABLED",
                AuditLogEventTypeV1.SecretDeleted => "SECRET_DELETED",
                AuditLogEventTypeV1.SecretUpdated => "SECRET_UPDATED",
                AuditLogEventTypeV1.SshCertificateSigned => "SSH_CERTIFICATE_SIGNED",
                AuditLogEventTypeV1.UserInvited => "USER_INVITED",
                AuditLogEventTypeV1.UserJoinedOrganization => "USER_JOINED_ORGANIZATION",
                AuditLogEventTypeV1.UserRemoved => "USER_REMOVED",
                AuditLogEventTypeV1.UserRoleUpdated => "USER_ROLE_UPDATED",
                AuditLogEventTypeV1.UserTeamRoleUpdated => "USER_TEAM_ROLE_UPDATED",
                AuditLogEventTypeV1.WebhookSigningSecretCreated => "WEBHOOK_SIGNING_SECRET_CREATED",
                AuditLogEventTypeV1.WebhookSigningSecretDeleted => "WEBHOOK_SIGNING_SECRET_DELETED",
                AuditLogEventTypeV1.WebhookSigningSecretRotated => "WEBHOOK_SIGNING_SECRET_ROTATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogEventTypeV1? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY_CREATED" => AuditLogEventTypeV1.ApiKeyCreated,
                "API_KEY_DELETED" => AuditLogEventTypeV1.ApiKeyDeleted,
                "CHAINLET_AUTOSCALING_SETTINGS_CHANGED" => AuditLogEventTypeV1.ChainletAutoscalingSettingsChanged,
                "CHAINLET_INSTANCE_TYPE_CHANGED" => AuditLogEventTypeV1.ChainletInstanceTypeChanged,
                "CHAIN_DELETED" => AuditLogEventTypeV1.ChainDeleted,
                "CHAIN_DEPLOYED" => AuditLogEventTypeV1.ChainDeployed,
                "CHAIN_DEPLOYMENT_ACTIVATED" => AuditLogEventTypeV1.ChainDeploymentActivated,
                "CHAIN_DEPLOYMENT_DEACTIVATED" => AuditLogEventTypeV1.ChainDeploymentDeactivated,
                "CHAIN_DEPLOYMENT_DELETED" => AuditLogEventTypeV1.ChainDeploymentDeleted,
                "CHAIN_DEPLOYMENT_PROMOTED" => AuditLogEventTypeV1.ChainDeploymentPromoted,
                "CHAIN_ENVIRONMENT_CREATED" => AuditLogEventTypeV1.ChainEnvironmentCreated,
                "CHAIN_ENVIRONMENT_UPDATED" => AuditLogEventTypeV1.ChainEnvironmentUpdated,
                "DIRECTORY_GROUP_ROLE_UPDATED" => AuditLogEventTypeV1.DirectoryGroupRoleUpdated,
                "ENVIRONMENT_CREATED" => AuditLogEventTypeV1.EnvironmentCreated,
                "ENVIRONMENT_DELETED" => AuditLogEventTypeV1.EnvironmentDeleted,
                "ENVIRONMENT_UPDATED" => AuditLogEventTypeV1.EnvironmentUpdated,
                "GATEWAY_ENDPOINT_CREATED" => AuditLogEventTypeV1.GatewayEndpointCreated,
                "GATEWAY_ENDPOINT_DELETED" => AuditLogEventTypeV1.GatewayEndpointDeleted,
                "GATEWAY_ENDPOINT_UPDATED" => AuditLogEventTypeV1.GatewayEndpointUpdated,
                "MODEL_DELETED" => AuditLogEventTypeV1.ModelDeleted,
                "MODEL_DEPLOYED" => AuditLogEventTypeV1.ModelDeployed,
                "MODEL_DEPLOYMENT_ACTIVATED" => AuditLogEventTypeV1.ModelDeploymentActivated,
                "MODEL_DEPLOYMENT_AUTOSCALING_SETTINGS_CHANGED" => AuditLogEventTypeV1.ModelDeploymentAutoscalingSettingsChanged,
                "MODEL_DEPLOYMENT_DEACTIVATED" => AuditLogEventTypeV1.ModelDeploymentDeactivated,
                "MODEL_DEPLOYMENT_DELETED" => AuditLogEventTypeV1.ModelDeploymentDeleted,
                "MODEL_DEPLOYMENT_INSTANCE_TYPE_CHANGED" => AuditLogEventTypeV1.ModelDeploymentInstanceTypeChanged,
                "MODEL_DEPLOYMENT_PROMOTED" => AuditLogEventTypeV1.ModelDeploymentPromoted,
                "MODEL_DEPLOYMENT_RETRIED" => AuditLogEventTypeV1.ModelDeploymentRetried,
                "MODEL_PROMOTION_CONTROL_ACTION" => AuditLogEventTypeV1.ModelPromotionControlAction,
                "REPLICA_TERMINATED" => AuditLogEventTypeV1.ReplicaTerminated,
                "REQUIRE_GROUP_BASED_ADMINS_ENABLED" => AuditLogEventTypeV1.RequireGroupBasedAdminsEnabled,
                "SECRET_DELETED" => AuditLogEventTypeV1.SecretDeleted,
                "SECRET_UPDATED" => AuditLogEventTypeV1.SecretUpdated,
                "SSH_CERTIFICATE_SIGNED" => AuditLogEventTypeV1.SshCertificateSigned,
                "USER_INVITED" => AuditLogEventTypeV1.UserInvited,
                "USER_JOINED_ORGANIZATION" => AuditLogEventTypeV1.UserJoinedOrganization,
                "USER_REMOVED" => AuditLogEventTypeV1.UserRemoved,
                "USER_ROLE_UPDATED" => AuditLogEventTypeV1.UserRoleUpdated,
                "USER_TEAM_ROLE_UPDATED" => AuditLogEventTypeV1.UserTeamRoleUpdated,
                "WEBHOOK_SIGNING_SECRET_CREATED" => AuditLogEventTypeV1.WebhookSigningSecretCreated,
                "WEBHOOK_SIGNING_SECRET_DELETED" => AuditLogEventTypeV1.WebhookSigningSecretDeleted,
                "WEBHOOK_SIGNING_SECRET_ROTATED" => AuditLogEventTypeV1.WebhookSigningSecretRotated,
                _ => null,
            };
        }
    }
}