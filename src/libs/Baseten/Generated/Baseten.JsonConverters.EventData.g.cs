#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten.JsonConverters
{
    /// <inheritdoc />
    public class EventDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Baseten.EventData>
    {
        /// <inheritdoc />
        public override global::Baseten.EventData Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEntryV1EventDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEntryV1EventDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEntryV1EventDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Baseten.AuditLogEventModelDeployedV1? modelDeployed = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeployed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeployedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeployedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventModelDeployedV1)}");
                modelDeployed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventModelDeploymentActivatedV1? modelDeploymentActivated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentActivated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeploymentActivatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeploymentActivatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventModelDeploymentActivatedV1)}");
                modelDeploymentActivated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventModelDeploymentDeactivatedV1? modelDeploymentDeactivated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentDeactivated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeploymentDeactivatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeploymentDeactivatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventModelDeploymentDeactivatedV1)}");
                modelDeploymentDeactivated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventModelDeploymentRetriedV1? modelDeploymentRetried = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentRetried)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeploymentRetriedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeploymentRetriedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventModelDeploymentRetriedV1)}");
                modelDeploymentRetried = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventModelDeploymentPromotedV1? modelDeploymentPromoted = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentPromoted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeploymentPromotedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeploymentPromotedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventModelDeploymentPromotedV1)}");
                modelDeploymentPromoted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1? modelDeploymentAutoscalingSettingsChanged = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentAutoscalingSettingsChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1)}");
                modelDeploymentAutoscalingSettingsChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1? modelDeploymentInstanceTypeChanged = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentInstanceTypeChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1)}");
                modelDeploymentInstanceTypeChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventModelDeploymentDeletedV1? modelDeploymentDeleted = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeploymentDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeploymentDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeploymentDeletedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventModelDeploymentDeletedV1)}");
                modelDeploymentDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventModelDeletedV1? modelDeleted = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ModelDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeletedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventModelDeletedV1)}");
                modelDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventChainDeployedV1? chainDeployed = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeployed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainDeployedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainDeployedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventChainDeployedV1)}");
                chainDeployed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventChainDeploymentActivatedV1? chainDeploymentActivated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeploymentActivated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainDeploymentActivatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainDeploymentActivatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventChainDeploymentActivatedV1)}");
                chainDeploymentActivated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventChainDeploymentDeactivatedV1? chainDeploymentDeactivated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeploymentDeactivated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainDeploymentDeactivatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainDeploymentDeactivatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventChainDeploymentDeactivatedV1)}");
                chainDeploymentDeactivated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventChainDeploymentPromotedV1? chainDeploymentPromoted = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeploymentPromoted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainDeploymentPromotedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainDeploymentPromotedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventChainDeploymentPromotedV1)}");
                chainDeploymentPromoted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1? chainletAutoscalingSettingsChanged = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ChainletAutoscalingSettingsChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1)}");
                chainletAutoscalingSettingsChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventChainletInstanceTypeChangedV1? chainletInstanceTypeChanged = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ChainletInstanceTypeChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainletInstanceTypeChangedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainletInstanceTypeChangedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventChainletInstanceTypeChangedV1)}");
                chainletInstanceTypeChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventChainDeploymentDeletedV1? chainDeploymentDeleted = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeploymentDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainDeploymentDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainDeploymentDeletedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventChainDeploymentDeletedV1)}");
                chainDeploymentDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventChainDeletedV1? chainDeleted = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ChainDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainDeletedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventChainDeletedV1)}");
                chainDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventChainEnvironmentCreatedV1? chainEnvironmentCreated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ChainEnvironmentCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainEnvironmentCreatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainEnvironmentCreatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventChainEnvironmentCreatedV1)}");
                chainEnvironmentCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventChainEnvironmentUpdatedV1? chainEnvironmentUpdated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ChainEnvironmentUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainEnvironmentUpdatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainEnvironmentUpdatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventChainEnvironmentUpdatedV1)}");
                chainEnvironmentUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventSecretUpdatedV1? secretUpdated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.SecretUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventSecretUpdatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventSecretUpdatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventSecretUpdatedV1)}");
                secretUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventSecretDeletedV1? secretDeleted = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.SecretDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventSecretDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventSecretDeletedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventSecretDeletedV1)}");
                secretDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventApiKeyCreatedV1? apiKeyCreated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ApiKeyCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventApiKeyCreatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventApiKeyCreatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventApiKeyCreatedV1)}");
                apiKeyCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventApiKeyDeletedV1? apiKeyDeleted = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ApiKeyDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventApiKeyDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventApiKeyDeletedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventApiKeyDeletedV1)}");
                apiKeyDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventGatewayEndpointCreatedV1? gatewayEndpointCreated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.GatewayEndpointCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventGatewayEndpointCreatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventGatewayEndpointCreatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventGatewayEndpointCreatedV1)}");
                gatewayEndpointCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventGatewayEndpointUpdatedV1? gatewayEndpointUpdated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.GatewayEndpointUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventGatewayEndpointUpdatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventGatewayEndpointUpdatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventGatewayEndpointUpdatedV1)}");
                gatewayEndpointUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventGatewayEndpointDeletedV1? gatewayEndpointDeleted = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.GatewayEndpointDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventGatewayEndpointDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventGatewayEndpointDeletedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventGatewayEndpointDeletedV1)}");
                gatewayEndpointDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventUserInvitedV1? userInvited = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.UserInvited)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventUserInvitedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventUserInvitedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventUserInvitedV1)}");
                userInvited = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventUserJoinedOrganizationV1? userJoinedOrganization = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.UserJoinedOrganization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventUserJoinedOrganizationV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventUserJoinedOrganizationV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventUserJoinedOrganizationV1)}");
                userJoinedOrganization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1? webhookSigningSecretCreated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.WebhookSigningSecretCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1)}");
                webhookSigningSecretCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1? webhookSigningSecretRotated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.WebhookSigningSecretRotated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1)}");
                webhookSigningSecretRotated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1? webhookSigningSecretDeleted = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.WebhookSigningSecretDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1)}");
                webhookSigningSecretDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventUserRoleUpdatedV1? userRoleUpdated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.UserRoleUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventUserRoleUpdatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventUserRoleUpdatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventUserRoleUpdatedV1)}");
                userRoleUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventUserTeamRoleUpdatedV1? userTeamRoleUpdated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.UserTeamRoleUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventUserTeamRoleUpdatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventUserTeamRoleUpdatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventUserTeamRoleUpdatedV1)}");
                userTeamRoleUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventUserRemovedV1? userRemoved = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.UserRemoved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventUserRemovedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventUserRemovedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventUserRemovedV1)}");
                userRemoved = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1? directoryGroupRoleUpdated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.DirectoryGroupRoleUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1)}");
                directoryGroupRoleUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1? requireGroupBasedAdminsEnabled = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.RequireGroupBasedAdminsEnabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1)}");
                requireGroupBasedAdminsEnabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventEnvironmentCreatedV1? environmentCreated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.EnvironmentCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventEnvironmentCreatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventEnvironmentCreatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventEnvironmentCreatedV1)}");
                environmentCreated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventEnvironmentUpdatedV1? environmentUpdated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.EnvironmentUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventEnvironmentUpdatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventEnvironmentUpdatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventEnvironmentUpdatedV1)}");
                environmentUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventEnvironmentDeletedV1? environmentDeleted = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.EnvironmentDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventEnvironmentDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventEnvironmentDeletedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventEnvironmentDeletedV1)}");
                environmentDeleted = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventReplicaTerminatedV1? replicaTerminated = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ReplicaTerminated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventReplicaTerminatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventReplicaTerminatedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventReplicaTerminatedV1)}");
                replicaTerminated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventModelPromotionControlActionV1? modelPromotionControlAction = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.ModelPromotionControlAction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelPromotionControlActionV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelPromotionControlActionV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventModelPromotionControlActionV1)}");
                modelPromotionControlAction = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Baseten.AuditLogEventSshCertificateSignedV1? sshCertificateSigned = default;
            if (discriminator?.EventType == global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType.SshCertificateSigned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventSshCertificateSignedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventSshCertificateSignedV1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Baseten.AuditLogEventSshCertificateSignedV1)}");
                sshCertificateSigned = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Baseten.EventData(
                discriminator?.EventType,
                modelDeployed,

                modelDeploymentActivated,

                modelDeploymentDeactivated,

                modelDeploymentRetried,

                modelDeploymentPromoted,

                modelDeploymentAutoscalingSettingsChanged,

                modelDeploymentInstanceTypeChanged,

                modelDeploymentDeleted,

                modelDeleted,

                chainDeployed,

                chainDeploymentActivated,

                chainDeploymentDeactivated,

                chainDeploymentPromoted,

                chainletAutoscalingSettingsChanged,

                chainletInstanceTypeChanged,

                chainDeploymentDeleted,

                chainDeleted,

                chainEnvironmentCreated,

                chainEnvironmentUpdated,

                secretUpdated,

                secretDeleted,

                apiKeyCreated,

                apiKeyDeleted,

                gatewayEndpointCreated,

                gatewayEndpointUpdated,

                gatewayEndpointDeleted,

                userInvited,

                userJoinedOrganization,

                webhookSigningSecretCreated,

                webhookSigningSecretRotated,

                webhookSigningSecretDeleted,

                userRoleUpdated,

                userTeamRoleUpdated,

                userRemoved,

                directoryGroupRoleUpdated,

                requireGroupBasedAdminsEnabled,

                environmentCreated,

                environmentUpdated,

                environmentDeleted,

                replicaTerminated,

                modelPromotionControlAction,

                sshCertificateSigned
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Baseten.EventData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsModelDeployed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeployedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeployedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventModelDeployedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelDeployed!, typeInfo);
            }
            else if (value.IsModelDeploymentActivated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeploymentActivatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeploymentActivatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventModelDeploymentActivatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelDeploymentActivated!, typeInfo);
            }
            else if (value.IsModelDeploymentDeactivated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeploymentDeactivatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeploymentDeactivatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventModelDeploymentDeactivatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelDeploymentDeactivated!, typeInfo);
            }
            else if (value.IsModelDeploymentRetried)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeploymentRetriedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeploymentRetriedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventModelDeploymentRetriedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelDeploymentRetried!, typeInfo);
            }
            else if (value.IsModelDeploymentPromoted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeploymentPromotedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeploymentPromotedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventModelDeploymentPromotedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelDeploymentPromoted!, typeInfo);
            }
            else if (value.IsModelDeploymentAutoscalingSettingsChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelDeploymentAutoscalingSettingsChanged!, typeInfo);
            }
            else if (value.IsModelDeploymentInstanceTypeChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelDeploymentInstanceTypeChanged!, typeInfo);
            }
            else if (value.IsModelDeploymentDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeploymentDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeploymentDeletedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventModelDeploymentDeletedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelDeploymentDeleted!, typeInfo);
            }
            else if (value.IsModelDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelDeletedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventModelDeletedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelDeleted!, typeInfo);
            }
            else if (value.IsChainDeployed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainDeployedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainDeployedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventChainDeployedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChainDeployed!, typeInfo);
            }
            else if (value.IsChainDeploymentActivated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainDeploymentActivatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainDeploymentActivatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventChainDeploymentActivatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChainDeploymentActivated!, typeInfo);
            }
            else if (value.IsChainDeploymentDeactivated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainDeploymentDeactivatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainDeploymentDeactivatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventChainDeploymentDeactivatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChainDeploymentDeactivated!, typeInfo);
            }
            else if (value.IsChainDeploymentPromoted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainDeploymentPromotedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainDeploymentPromotedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventChainDeploymentPromotedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChainDeploymentPromoted!, typeInfo);
            }
            else if (value.IsChainletAutoscalingSettingsChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChainletAutoscalingSettingsChanged!, typeInfo);
            }
            else if (value.IsChainletInstanceTypeChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainletInstanceTypeChangedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainletInstanceTypeChangedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventChainletInstanceTypeChangedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChainletInstanceTypeChanged!, typeInfo);
            }
            else if (value.IsChainDeploymentDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainDeploymentDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainDeploymentDeletedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventChainDeploymentDeletedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChainDeploymentDeleted!, typeInfo);
            }
            else if (value.IsChainDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainDeletedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventChainDeletedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChainDeleted!, typeInfo);
            }
            else if (value.IsChainEnvironmentCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainEnvironmentCreatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainEnvironmentCreatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventChainEnvironmentCreatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChainEnvironmentCreated!, typeInfo);
            }
            else if (value.IsChainEnvironmentUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventChainEnvironmentUpdatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventChainEnvironmentUpdatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventChainEnvironmentUpdatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChainEnvironmentUpdated!, typeInfo);
            }
            else if (value.IsSecretUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventSecretUpdatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventSecretUpdatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventSecretUpdatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SecretUpdated!, typeInfo);
            }
            else if (value.IsSecretDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventSecretDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventSecretDeletedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventSecretDeletedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SecretDeleted!, typeInfo);
            }
            else if (value.IsApiKeyCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventApiKeyCreatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventApiKeyCreatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventApiKeyCreatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKeyCreated!, typeInfo);
            }
            else if (value.IsApiKeyDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventApiKeyDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventApiKeyDeletedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventApiKeyDeletedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKeyDeleted!, typeInfo);
            }
            else if (value.IsGatewayEndpointCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventGatewayEndpointCreatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventGatewayEndpointCreatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventGatewayEndpointCreatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GatewayEndpointCreated!, typeInfo);
            }
            else if (value.IsGatewayEndpointUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventGatewayEndpointUpdatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventGatewayEndpointUpdatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventGatewayEndpointUpdatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GatewayEndpointUpdated!, typeInfo);
            }
            else if (value.IsGatewayEndpointDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventGatewayEndpointDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventGatewayEndpointDeletedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventGatewayEndpointDeletedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GatewayEndpointDeleted!, typeInfo);
            }
            else if (value.IsUserInvited)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventUserInvitedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventUserInvitedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventUserInvitedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserInvited!, typeInfo);
            }
            else if (value.IsUserJoinedOrganization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventUserJoinedOrganizationV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventUserJoinedOrganizationV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventUserJoinedOrganizationV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserJoinedOrganization!, typeInfo);
            }
            else if (value.IsWebhookSigningSecretCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebhookSigningSecretCreated!, typeInfo);
            }
            else if (value.IsWebhookSigningSecretRotated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebhookSigningSecretRotated!, typeInfo);
            }
            else if (value.IsWebhookSigningSecretDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebhookSigningSecretDeleted!, typeInfo);
            }
            else if (value.IsUserRoleUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventUserRoleUpdatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventUserRoleUpdatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventUserRoleUpdatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserRoleUpdated!, typeInfo);
            }
            else if (value.IsUserTeamRoleUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventUserTeamRoleUpdatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventUserTeamRoleUpdatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventUserTeamRoleUpdatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserTeamRoleUpdated!, typeInfo);
            }
            else if (value.IsUserRemoved)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventUserRemovedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventUserRemovedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventUserRemovedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UserRemoved!, typeInfo);
            }
            else if (value.IsDirectoryGroupRoleUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DirectoryGroupRoleUpdated!, typeInfo);
            }
            else if (value.IsRequireGroupBasedAdminsEnabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RequireGroupBasedAdminsEnabled!, typeInfo);
            }
            else if (value.IsEnvironmentCreated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventEnvironmentCreatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventEnvironmentCreatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventEnvironmentCreatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EnvironmentCreated!, typeInfo);
            }
            else if (value.IsEnvironmentUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventEnvironmentUpdatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventEnvironmentUpdatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventEnvironmentUpdatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EnvironmentUpdated!, typeInfo);
            }
            else if (value.IsEnvironmentDeleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventEnvironmentDeletedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventEnvironmentDeletedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventEnvironmentDeletedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EnvironmentDeleted!, typeInfo);
            }
            else if (value.IsReplicaTerminated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventReplicaTerminatedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventReplicaTerminatedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventReplicaTerminatedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReplicaTerminated!, typeInfo);
            }
            else if (value.IsModelPromotionControlAction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventModelPromotionControlActionV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventModelPromotionControlActionV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventModelPromotionControlActionV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelPromotionControlAction!, typeInfo);
            }
            else if (value.IsSshCertificateSigned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Baseten.AuditLogEventSshCertificateSignedV1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Baseten.AuditLogEventSshCertificateSignedV1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Baseten.AuditLogEventSshCertificateSignedV1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SshCertificateSigned!, typeInfo);
            }
        }
    }
}