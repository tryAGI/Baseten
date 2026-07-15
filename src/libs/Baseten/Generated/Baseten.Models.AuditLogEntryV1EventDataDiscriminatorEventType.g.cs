
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuditLogEntryV1EventDataDiscriminatorEventType
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
    public static class AuditLogEntryV1EventDataDiscriminatorEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogEntryV1EventDataDiscriminatorEventType value)
        {
            return value switch
            {
                AuditLogEntryV1EventDataDiscriminatorEventType.ApiKeyCreated => "API_KEY_CREATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ApiKeyDeleted => "API_KEY_DELETED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ChainletAutoscalingSettingsChanged => "CHAINLET_AUTOSCALING_SETTINGS_CHANGED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ChainletInstanceTypeChanged => "CHAINLET_INSTANCE_TYPE_CHANGED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeleted => "CHAIN_DELETED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeployed => "CHAIN_DEPLOYED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeploymentActivated => "CHAIN_DEPLOYMENT_ACTIVATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeploymentDeactivated => "CHAIN_DEPLOYMENT_DEACTIVATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeploymentDeleted => "CHAIN_DEPLOYMENT_DELETED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeploymentPromoted => "CHAIN_DEPLOYMENT_PROMOTED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ChainEnvironmentCreated => "CHAIN_ENVIRONMENT_CREATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ChainEnvironmentUpdated => "CHAIN_ENVIRONMENT_UPDATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.DirectoryGroupRoleUpdated => "DIRECTORY_GROUP_ROLE_UPDATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.EnvironmentCreated => "ENVIRONMENT_CREATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.EnvironmentDeleted => "ENVIRONMENT_DELETED",
                AuditLogEntryV1EventDataDiscriminatorEventType.EnvironmentUpdated => "ENVIRONMENT_UPDATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.GatewayEndpointCreated => "GATEWAY_ENDPOINT_CREATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.GatewayEndpointDeleted => "GATEWAY_ENDPOINT_DELETED",
                AuditLogEntryV1EventDataDiscriminatorEventType.GatewayEndpointUpdated => "GATEWAY_ENDPOINT_UPDATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeleted => "MODEL_DELETED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeployed => "MODEL_DEPLOYED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentActivated => "MODEL_DEPLOYMENT_ACTIVATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentAutoscalingSettingsChanged => "MODEL_DEPLOYMENT_AUTOSCALING_SETTINGS_CHANGED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentDeactivated => "MODEL_DEPLOYMENT_DEACTIVATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentDeleted => "MODEL_DEPLOYMENT_DELETED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentInstanceTypeChanged => "MODEL_DEPLOYMENT_INSTANCE_TYPE_CHANGED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentPromoted => "MODEL_DEPLOYMENT_PROMOTED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentRetried => "MODEL_DEPLOYMENT_RETRIED",
                AuditLogEntryV1EventDataDiscriminatorEventType.ModelPromotionControlAction => "MODEL_PROMOTION_CONTROL_ACTION",
                AuditLogEntryV1EventDataDiscriminatorEventType.ReplicaTerminated => "REPLICA_TERMINATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.RequireGroupBasedAdminsEnabled => "REQUIRE_GROUP_BASED_ADMINS_ENABLED",
                AuditLogEntryV1EventDataDiscriminatorEventType.SecretDeleted => "SECRET_DELETED",
                AuditLogEntryV1EventDataDiscriminatorEventType.SecretUpdated => "SECRET_UPDATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.SshCertificateSigned => "SSH_CERTIFICATE_SIGNED",
                AuditLogEntryV1EventDataDiscriminatorEventType.UserInvited => "USER_INVITED",
                AuditLogEntryV1EventDataDiscriminatorEventType.UserJoinedOrganization => "USER_JOINED_ORGANIZATION",
                AuditLogEntryV1EventDataDiscriminatorEventType.UserRemoved => "USER_REMOVED",
                AuditLogEntryV1EventDataDiscriminatorEventType.UserRoleUpdated => "USER_ROLE_UPDATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.UserTeamRoleUpdated => "USER_TEAM_ROLE_UPDATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.WebhookSigningSecretCreated => "WEBHOOK_SIGNING_SECRET_CREATED",
                AuditLogEntryV1EventDataDiscriminatorEventType.WebhookSigningSecretDeleted => "WEBHOOK_SIGNING_SECRET_DELETED",
                AuditLogEntryV1EventDataDiscriminatorEventType.WebhookSigningSecretRotated => "WEBHOOK_SIGNING_SECRET_ROTATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogEntryV1EventDataDiscriminatorEventType? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY_CREATED" => AuditLogEntryV1EventDataDiscriminatorEventType.ApiKeyCreated,
                "API_KEY_DELETED" => AuditLogEntryV1EventDataDiscriminatorEventType.ApiKeyDeleted,
                "CHAINLET_AUTOSCALING_SETTINGS_CHANGED" => AuditLogEntryV1EventDataDiscriminatorEventType.ChainletAutoscalingSettingsChanged,
                "CHAINLET_INSTANCE_TYPE_CHANGED" => AuditLogEntryV1EventDataDiscriminatorEventType.ChainletInstanceTypeChanged,
                "CHAIN_DELETED" => AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeleted,
                "CHAIN_DEPLOYED" => AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeployed,
                "CHAIN_DEPLOYMENT_ACTIVATED" => AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeploymentActivated,
                "CHAIN_DEPLOYMENT_DEACTIVATED" => AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeploymentDeactivated,
                "CHAIN_DEPLOYMENT_DELETED" => AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeploymentDeleted,
                "CHAIN_DEPLOYMENT_PROMOTED" => AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeploymentPromoted,
                "CHAIN_ENVIRONMENT_CREATED" => AuditLogEntryV1EventDataDiscriminatorEventType.ChainEnvironmentCreated,
                "CHAIN_ENVIRONMENT_UPDATED" => AuditLogEntryV1EventDataDiscriminatorEventType.ChainEnvironmentUpdated,
                "DIRECTORY_GROUP_ROLE_UPDATED" => AuditLogEntryV1EventDataDiscriminatorEventType.DirectoryGroupRoleUpdated,
                "ENVIRONMENT_CREATED" => AuditLogEntryV1EventDataDiscriminatorEventType.EnvironmentCreated,
                "ENVIRONMENT_DELETED" => AuditLogEntryV1EventDataDiscriminatorEventType.EnvironmentDeleted,
                "ENVIRONMENT_UPDATED" => AuditLogEntryV1EventDataDiscriminatorEventType.EnvironmentUpdated,
                "GATEWAY_ENDPOINT_CREATED" => AuditLogEntryV1EventDataDiscriminatorEventType.GatewayEndpointCreated,
                "GATEWAY_ENDPOINT_DELETED" => AuditLogEntryV1EventDataDiscriminatorEventType.GatewayEndpointDeleted,
                "GATEWAY_ENDPOINT_UPDATED" => AuditLogEntryV1EventDataDiscriminatorEventType.GatewayEndpointUpdated,
                "MODEL_DELETED" => AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeleted,
                "MODEL_DEPLOYED" => AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeployed,
                "MODEL_DEPLOYMENT_ACTIVATED" => AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentActivated,
                "MODEL_DEPLOYMENT_AUTOSCALING_SETTINGS_CHANGED" => AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentAutoscalingSettingsChanged,
                "MODEL_DEPLOYMENT_DEACTIVATED" => AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentDeactivated,
                "MODEL_DEPLOYMENT_DELETED" => AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentDeleted,
                "MODEL_DEPLOYMENT_INSTANCE_TYPE_CHANGED" => AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentInstanceTypeChanged,
                "MODEL_DEPLOYMENT_PROMOTED" => AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentPromoted,
                "MODEL_DEPLOYMENT_RETRIED" => AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentRetried,
                "MODEL_PROMOTION_CONTROL_ACTION" => AuditLogEntryV1EventDataDiscriminatorEventType.ModelPromotionControlAction,
                "REPLICA_TERMINATED" => AuditLogEntryV1EventDataDiscriminatorEventType.ReplicaTerminated,
                "REQUIRE_GROUP_BASED_ADMINS_ENABLED" => AuditLogEntryV1EventDataDiscriminatorEventType.RequireGroupBasedAdminsEnabled,
                "SECRET_DELETED" => AuditLogEntryV1EventDataDiscriminatorEventType.SecretDeleted,
                "SECRET_UPDATED" => AuditLogEntryV1EventDataDiscriminatorEventType.SecretUpdated,
                "SSH_CERTIFICATE_SIGNED" => AuditLogEntryV1EventDataDiscriminatorEventType.SshCertificateSigned,
                "USER_INVITED" => AuditLogEntryV1EventDataDiscriminatorEventType.UserInvited,
                "USER_JOINED_ORGANIZATION" => AuditLogEntryV1EventDataDiscriminatorEventType.UserJoinedOrganization,
                "USER_REMOVED" => AuditLogEntryV1EventDataDiscriminatorEventType.UserRemoved,
                "USER_ROLE_UPDATED" => AuditLogEntryV1EventDataDiscriminatorEventType.UserRoleUpdated,
                "USER_TEAM_ROLE_UPDATED" => AuditLogEntryV1EventDataDiscriminatorEventType.UserTeamRoleUpdated,
                "WEBHOOK_SIGNING_SECRET_CREATED" => AuditLogEntryV1EventDataDiscriminatorEventType.WebhookSigningSecretCreated,
                "WEBHOOK_SIGNING_SECRET_DELETED" => AuditLogEntryV1EventDataDiscriminatorEventType.WebhookSigningSecretDeleted,
                "WEBHOOK_SIGNING_SECRET_ROTATED" => AuditLogEntryV1EventDataDiscriminatorEventType.WebhookSigningSecretRotated,
                _ => null,
            };
        }
    }
}