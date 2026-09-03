
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PaginationResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.VolumeTagV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.VolumeV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.VolumeVersionSummaryV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.VolumeTagV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListVolumesResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.VolumeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListVolumesRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.VolumeTokenScopeV1), TypeInfoPropertyName = "VolumeTokenScopeV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateVolumeTokenRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.VolumeTokenScopeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateVolumeTokenResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListVolumeNamespacesResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListVolumeNamespacesRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.VolumeVersionV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListVolumeVersionsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.VolumeVersionV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SecretV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SecretsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SecretV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpsertSecretRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SecretTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EnvironmentGroupManageAccessV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.EnvironmentGroupUserV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EnvironmentGroupUserV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EnvironmentGroupV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EnvironmentGroupsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.EnvironmentGroupV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateEnvironmentGroupManageAccessV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateEnvironmentGroupRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TeamV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TeamsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TeamV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TeamsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RegionV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RegionsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.RegionV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.InstanceTypeV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.InstanceTypesV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.InstanceTypeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsUserConfigV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetLoopsUserConfigResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PatchLoopsUserConfigRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PatchLoopsUserConfigResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.InstanceTypeWithPriceV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.InstanceTypePricesV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.InstanceTypeWithPriceV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentArchivePayloadV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PrepareModelUploadRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AWSCredentialsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PrepareModelUploadResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogActorTypeV1), TypeInfoPropertyName = "AuditLogActorTypeV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogActorV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogApiKeyTypeV1), TypeInfoPropertyName = "AuditLogApiKeyTypeV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEntryV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventTypeV1), TypeInfoPropertyName = "AuditLogEventTypeV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EventData), TypeInfoPropertyName = "EventData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventModelDeployedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventModelDeploymentActivatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventModelDeploymentDeactivatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventModelDeploymentRetriedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventModelDeploymentPromotedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventModelDeploymentRequestBackpressureSettingsChangedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventModelDeploymentDeletedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventModelDeletedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventChainDeployedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventChainDeploymentActivatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventChainDeploymentDeactivatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventChainDeploymentPromotedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventChainletInstanceTypeChangedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventChainDeploymentDeletedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventChainDeletedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventChainEnvironmentCreatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventChainEnvironmentUpdatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventSecretUpdatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventSecretDeletedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventApiKeyCreatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventApiKeyDeletedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventGatewayEndpointCreatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventGatewayEndpointUpdatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventGatewayEndpointDeletedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventUserInvitedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventUserJoinedOrganizationV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventUserRoleUpdatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventUserTeamRoleUpdatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventUserRemovedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventEnvironmentCreatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventEnvironmentUpdatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventEnvironmentDeletedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventReplicaTerminatedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventModelPromotionControlActionV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventSshCertificateSignedV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEntryV1EventDataDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType), TypeInfoPropertyName = "AuditLogEntryV1EventDataDiscriminatorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogSourceV1), TypeInfoPropertyName = "AuditLogSourceV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventAutoscalingScheduleActionV1), TypeInfoPropertyName = "AuditLogEventAutoscalingScheduleActionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventAutoscalingScheduleChangeV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventAutoscalingScheduleSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventAutoscalingSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventEnvironmentSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.AuditLogEventAutoscalingScheduleChangeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogPromotionControlActionV1), TypeInfoPropertyName = "AuditLogPromotionControlActionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListAuditLogsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.AuditLogEntryV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventTypeGroupV1), TypeInfoPropertyName = "AuditLogEventTypeGroupV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogSortDirectionV1), TypeInfoPropertyName = "AuditLogSortDirectionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListAuditLogsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.AuditLogEventTypeGroupV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.AuditLogSourceV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ModelV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LibraryListingSourceV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelArchiveSourceV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateModelRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.Source), TypeInfoPropertyName = "Source2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateModelRequestV1SourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateModelRequestV1SourceDiscriminatorKind), TypeInfoPropertyName = "CreateModelRequestV1SourceDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AutoscalingSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentStatusV1), TypeInfoPropertyName = "DeploymentStatusV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RequestBackpressureSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RequestBackpressurePolicyV1), TypeInfoPropertyName = "RequestBackpressurePolicyV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreatedModelDeploymentV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.DeploymentV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentArchiveSourceV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateModelDeploymentRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateModelDeploymentRequestV1SourceDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateModelDeploymentRequestV1SourceDiscriminatorKind), TypeInfoPropertyName = "CreateModelDeploymentRequestV1SourceDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateDeploymentRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateAutoscalingSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateAutoscalingSettingsStatusV1), TypeInfoPropertyName = "UpdateAutoscalingSettingsStatusV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateAutoscalingSettingsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateRequestBackpressureSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PromoteRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ActivateResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeactivateResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RetryDeploymentResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DownloadDeploymentResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentConfigResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentConfigOutputFormat), TypeInfoPropertyName = "DeploymentConfigOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetDeploymentConfigRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LogLevelV1), TypeInfoPropertyName = "LogLevelV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LogV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetLogsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.LogV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SortOrderV1), TypeInfoPropertyName = "SortOrderV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetDeploymentLogsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentPatchActionV1), TypeInfoPropertyName = "DeploymentPatchActionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentPatchOpConfigV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentPatchOpEnvVarV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentPatchOpExternalDataV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentPatchOpModelCodeV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentPatchOpPackageV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentPatchOpPythonRequirementV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentPatchPointV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateDeploymentPatchRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.PatchOpsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PatchOpsItem), TypeInfoPropertyName = "PatchOpsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType), TypeInfoPropertyName = "CreateDeploymentPatchRequestV1PatchOpDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentPatchPointWithHashV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateDeploymentPatchResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetDeploymentPatchesStateResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SyncDeploymentPatchesRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SyncDeploymentPatchesResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelMetricDescriptorV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelMetricUnitHintV1), TypeInfoPropertyName = "ModelMetricUnitHintV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelMetricKindV1), TypeInfoPropertyName = "ModelMetricKindV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelMetricModeV1), TypeInfoPropertyName = "ModelMetricModeV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelMetricValueSetV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetModelMetricsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ModelMetricDescriptorV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ModelMetricValueSetV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetDeploymentMetricsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TerminateReplicaResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SignSSHCertificateRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SignSSHCertificateResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AutoscalingScheduleSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AutoscalingScheduleStateV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AutoscalingScheduleV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AutoscalingScheduleV1Cadence), TypeInfoPropertyName = "AutoscalingScheduleV1Cadence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.AutoscalingScheduleWeekdayV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AutoscalingScheduleWeekdayV1), TypeInfoPropertyName = "AutoscalingScheduleWeekdayV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EnvironmentAutoscalingSchedulesV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SchedulesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SchedulesItem), TypeInfoPropertyName = "SchedulesItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.OneTimeAutoscalingScheduleV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence), TypeInfoPropertyName = "EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EnvironmentV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.InProgressPromotionV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PromotionSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.InProgressPromotionStatusV1), TypeInfoPropertyName = "InProgressPromotionStatusV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PromotionCleanupStrategyV1), TypeInfoPropertyName = "PromotionCleanupStrategyV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RollingDeployConfigV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RollingDeployStrategyV1), TypeInfoPropertyName = "RollingDeployStrategyV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EnvironmentsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.EnvironmentV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdatePromotionSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateRollingDeployConfigV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateEnvironmentRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EnvironmentTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AutoscalingScheduleSettingsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AutoscalingScheduleUpsertV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AutoscalingScheduleUpsertV1Cadence), TypeInfoPropertyName = "AutoscalingScheduleUpsertV1Cadence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.OneTimeAutoscalingScheduleUpsertV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateAutoscalingScheduleSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SchedulesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SchedulesItem2), TypeInfoPropertyName = "SchedulesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence), TypeInfoPropertyName = "UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateEnvironmentRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateEnvironmentResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetEnvironmentLogsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetEnvironmentMetricsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PromoteToEnvironmentRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CancelPromotionStatusV1), TypeInfoPropertyName = "CancelPromotionStatusV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CancelPromotionResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SignalPromotionResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ChainV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ChainsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ChainV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ChainTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ChainDeploymentV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ChainletV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ChainletV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ChainDeploymentsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ChainDeploymentV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ChainDeploymentTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ChainletEnvironmentSettingsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateChainEnvironmentRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentSettingsRequestV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ChainletEnvironmentSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ChainEnvironmentV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentSettingsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateChainEnvironmentRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateChainEnvironmentResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PromoteToChainEnvironmentRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ChainletEnvironmentAutoscalingSettingsUpdateV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateChainletEnvironmentAutoscalingSettingsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentAutoscalingSettingsUpdateV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ChainletEnvironmentInstanceTypeUpdateV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateChainletEnvironmentInstanceTypeRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentInstanceTypeUpdateV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateChainletEnvironmentInstanceTypeResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpsertTrainingProjectV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpsertTrainingProjectRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CheckpointSyncStatus), TypeInfoPropertyName = "CheckpointSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingJobV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingProjectSummaryV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.V1AvailabilityModel), TypeInfoPropertyName = "V1AvailabilityModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UserV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingProjectV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpsertTrainingProjectResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListTrainingProjectsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TrainingProjectV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListTrainingJobsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TrainingJobV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AwsAssumeRoleDockerAuthV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AwsIamDockerAuthV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SecretReferenceV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AwsOidcDockerAuthV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.BasetenLatestCheckpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.BasetenNamedCheckpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateJobWeightConfigV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateTrainingJobAcceleratorV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateTrainingJobCacheConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateTrainingJobCheckpointingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateTrainingJobComputeV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateTrainingJobImageV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DockerAuthV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateTrainingJobRuntimeV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AnyOf<string, global::Baseten.SecretReferenceV1>), TypeInfoPropertyName = "AnyOfStringSecretReferenceV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.CreateTrainingJobS3Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateTrainingJobS3Artifact))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoadCheckpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateTrainingJobV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrussUserEnv))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.InteractiveSessionConfigV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.CreateJobWeightConfigV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DockerAuthType), TypeInfoPropertyName = "DockerAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GcpServiceAccountJsonDockerAuthV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GcpOidcDockerAuthV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RegistrySecretDockerAuthV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GitInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.V1InteractiveSessionTrigger), TypeInfoPropertyName = "V1InteractiveSessionTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.V1InteractiveSessionProvider), TypeInfoPropertyName = "V1InteractiveSessionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.V1InteractiveSessionAuthProvider), TypeInfoPropertyName = "V1InteractiveSessionAuthProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.CheckpointsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CheckpointsItem), TypeInfoPropertyName = "CheckpointsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsCheckpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoadCheckpointConfigCheckpointDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp), TypeInfoPropertyName = "LoadCheckpointConfigCheckpointDiscriminatorTyp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsCheckpointConfigTarget), TypeInfoPropertyName = "LoopsCheckpointConfigTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateTrainingJobRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateTrainingJobResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingJobTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingJobResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateTrainingJobRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateTrainingJobResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DownloadTrainingJobResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RecreateTrainingJobResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingJobLogsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.StorageMetricsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingJobMetricV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingJobMetricsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingJobNodeMetricsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingJobMetricsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TrainingJobNodeMetricsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingJobMetricsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.StopTrainingJobRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.StopTrainingJobResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingJobCheckpointV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingJobCheckpointsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TrainingJobCheckpointV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CheckpointFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingJobCheckpointFilesResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.CheckpointFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingJobCheckpointFilesRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuthCodeV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetAuthCodesResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.AuthCodeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PatchInteractiveSessionRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.InteractiveSessionV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PatchInteractiveSessionResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.FileSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetCacheSummaryResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.FileSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingProjectTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingProjectResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.OrderByV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SearchTrainingJobsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.OrderByV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SearchTrainingJobsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SupportedModelV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetLoopsCapabilitiesResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SupportedModelV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsSessionV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateLoopsSessionResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetLoopsSessionResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsRunStatusNameV1), TypeInfoPropertyName = "LoopsRunStatusNameV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsRunStatusV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsRunV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsSamplerV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsSamplerStatusV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListLoopsRunsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.LoopsRunV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListLoopsRunsQueryParamsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateLoopsRunRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateLoopsRunResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeactivateLoopsRunResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetLoopsRunResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListLoopsSamplersResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.LoopsSamplerV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListLoopsSamplersRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateLoopsSamplerRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateLoopsSamplerResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetLoopsSamplerResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsCheckpointV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainerCheckpointTarget), TypeInfoPropertyName = "TrainerCheckpointTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListLoopsCheckpointsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.LoopsCheckpointV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListLoopsCheckpointsQueryParamsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ValidateLoopsCheckpointRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ValidateLoopsCheckpointResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsCheckpointFilesResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetLoopsCheckpointFilesRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsDeploymentStatusV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.Name), TypeInfoPropertyName = "Name2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsDeploymentV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListLoopsDeploymentsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.LoopsDeploymentV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListLoopsDeploymentsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeactivateLoopsDeploymentResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetLoopsDeploymentResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsDebugArchiveFilesResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetLoopsDebugArchiveFilesRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetLoopsDeploymentMetricsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.InferenceVolumeByStatusDatapointV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsDeploymentMetricsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ResponseTimeDatapointV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ResponseTimeDatapointV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.InferenceVolumeByStatusDatapointV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.LoopsDeploymentNodeMetricsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsDeploymentNodeMetricsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetLoopsDeploymentMetricsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetLoopsDeploymentLogsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TeamTrainingGpuCapacityItemV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingGpuCapacityItemV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingGpuCapacityResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TrainingGpuCapacityItemV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TeamTrainingGpuCapacityItemV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PatchTeamTrainingGpuCapacityRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PatchTeamTrainingGpuCapacityResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ActiveJobAtSubmitV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CapacityAtSubmitV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PendingJobAheadAtSubmitV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.QueueEventV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingJobQueueContextResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ActiveJobAtSubmitV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.PendingJobAheadAtSubmitV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.QueueEventV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetBlobCredentialsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.APIKeyCategory), TypeInfoPropertyName = "APIKeyCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateAPIKeyRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.APIKeyV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.APIKeyInfoV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.APIKeyOwnerV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.APIKeysV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.APIKeyInfoV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.APIKeyTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LimitTypeV1), TypeInfoPropertyName = "LimitTypeV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelAPIOrgDetailsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelAPIV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AnyOf<double?, string, object>), TypeInfoPropertyName = "AnyOfDoubleStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.RateLimitV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RateLimitV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RateLimitUnitV1), TypeInfoPropertyName = "RateLimitUnitV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelAPIsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ModelAPIV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelAPIsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelApisUsageBucketV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ModelApisUsageResultV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelApisUsageResultV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelApisUsageResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ModelApisUsageBucketV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.BucketWidth), TypeInfoPropertyName = "BucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UsageDimensionV1), TypeInfoPropertyName = "UsageDimensionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelApisUsageRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.UsageDimensionV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateLLMModelRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LLMModelHandleV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateLLMModelVersionRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LibraryListingMetadataV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.LibraryListingMetadataV1InputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LibraryListingMetadataV1InputModalitie), TypeInfoPropertyName = "LibraryListingMetadataV1InputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.LibraryListingMetadataV1OutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LibraryListingMetadataV1OutputModalitie), TypeInfoPropertyName = "LibraryListingMetadataV1OutputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LibraryListingV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LibraryListingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.LibraryListingV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateLibraryListingRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LibraryListingTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateLibraryListingRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.BenchmarkSnapshotV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LLMBenchmarkMetricsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TTSBenchmarkMetricsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EmbeddingBenchmarkMetricsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LibraryListingVersionV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LibraryListingVersionsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.LibraryListingVersionV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateLibraryListingVersionRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LibraryListingVersionTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateLibraryListingVersionRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.BillableResourceV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ResourceKind), TypeInfoPropertyName = "ResourceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ChainMetadataV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DailyDedicatedUsageV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AnyOf<double?, string>), TypeInfoPropertyName = "AnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DailyModelApiUsageV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DailyTrainingUsageV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DedicatedItemV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.DailyDedicatedUsageV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DedicatedUsageV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.DedicatedItemV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelApiItemV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.DailyModelApiUsageV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelApisUsageV1))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ModelApiItemV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingItemV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.DailyTrainingUsageV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingUsageV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TrainingItemV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UsageSummaryV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UsageSummaryRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UserInfoV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UsersResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.UserInfoV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UsersRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GatewayEventTokensV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GatewayEventV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GatewayEventsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.GatewayEventV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GatewayEventsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EndpointTargetV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GatewayProvider), TypeInfoPropertyName = "GatewayProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.VertexTargetConfigV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EndpointV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SharedEndpointRegionV1), TypeInfoPropertyName = "SharedEndpointRegionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.EndpointTargetV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EndpointsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.EndpointV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EndpointTargetRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateEndpointRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.EndpointTargetRequestV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EndpointTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateEndpointRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EffectiveModelConfigV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.EffectiveRateLimitV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EffectiveRateLimitV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.EffectiveUsageLimitV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EffectiveUsageLimitV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UsageLimitUnitV1), TypeInfoPropertyName = "UsageLimitUnitV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GroupHierarchyV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LimitEnforcementV1), TypeInfoPropertyName = "LimitEnforcementV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GroupMetadataV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GroupV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ModelConfigV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelConfigV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.EffectiveModelConfigV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.UsageLimitV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UsageLimitV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GroupsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.GroupV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateGroupHierarchyV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateGroupRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateGroupMetadataV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateGroupRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GatewayKeyInfoV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.KeysForGroupResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.GatewayKeyInfoV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateApiKeyForGroupRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateApiKeyForGroupResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RegisterAPIKeyRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RegisterAPIKeyResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.VolumeTokenScopeV1?), TypeInfoPropertyName = "NullableVolumeTokenScopeV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogActorTypeV1?), TypeInfoPropertyName = "NullableAuditLogActorTypeV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogApiKeyTypeV1?), TypeInfoPropertyName = "NullableAuditLogApiKeyTypeV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventTypeV1?), TypeInfoPropertyName = "NullableAuditLogEventTypeV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EventData?), TypeInfoPropertyName = "NullableEventData2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType?), TypeInfoPropertyName = "NullableAuditLogEntryV1EventDataDiscriminatorEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogSourceV1?), TypeInfoPropertyName = "NullableAuditLogSourceV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventAutoscalingScheduleActionV1?), TypeInfoPropertyName = "NullableAuditLogEventAutoscalingScheduleActionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogPromotionControlActionV1?), TypeInfoPropertyName = "NullableAuditLogPromotionControlActionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogEventTypeGroupV1?), TypeInfoPropertyName = "NullableAuditLogEventTypeGroupV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuditLogSortDirectionV1?), TypeInfoPropertyName = "NullableAuditLogSortDirectionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.Source?), TypeInfoPropertyName = "NullableSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateModelRequestV1SourceDiscriminatorKind?), TypeInfoPropertyName = "NullableCreateModelRequestV1SourceDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentStatusV1?), TypeInfoPropertyName = "NullableDeploymentStatusV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RequestBackpressurePolicyV1?), TypeInfoPropertyName = "NullableRequestBackpressurePolicyV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateModelDeploymentRequestV1SourceDiscriminatorKind?), TypeInfoPropertyName = "NullableCreateModelDeploymentRequestV1SourceDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateAutoscalingSettingsStatusV1?), TypeInfoPropertyName = "NullableUpdateAutoscalingSettingsStatusV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentConfigOutputFormat?), TypeInfoPropertyName = "NullableDeploymentConfigOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LogLevelV1?), TypeInfoPropertyName = "NullableLogLevelV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SortOrderV1?), TypeInfoPropertyName = "NullableSortOrderV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentPatchActionV1?), TypeInfoPropertyName = "NullableDeploymentPatchActionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PatchOpsItem?), TypeInfoPropertyName = "NullablePatchOpsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType?), TypeInfoPropertyName = "NullableCreateDeploymentPatchRequestV1PatchOpDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelMetricUnitHintV1?), TypeInfoPropertyName = "NullableModelMetricUnitHintV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelMetricKindV1?), TypeInfoPropertyName = "NullableModelMetricKindV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelMetricModeV1?), TypeInfoPropertyName = "NullableModelMetricModeV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AutoscalingScheduleV1Cadence?), TypeInfoPropertyName = "NullableAutoscalingScheduleV1Cadence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AutoscalingScheduleWeekdayV1?), TypeInfoPropertyName = "NullableAutoscalingScheduleWeekdayV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SchedulesItem?), TypeInfoPropertyName = "NullableSchedulesItem2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence?), TypeInfoPropertyName = "NullableEnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.InProgressPromotionStatusV1?), TypeInfoPropertyName = "NullableInProgressPromotionStatusV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PromotionCleanupStrategyV1?), TypeInfoPropertyName = "NullablePromotionCleanupStrategyV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RollingDeployStrategyV1?), TypeInfoPropertyName = "NullableRollingDeployStrategyV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AutoscalingScheduleUpsertV1Cadence?), TypeInfoPropertyName = "NullableAutoscalingScheduleUpsertV1Cadence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SchedulesItem2?), TypeInfoPropertyName = "NullableSchedulesItem22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence?), TypeInfoPropertyName = "NullableUpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CancelPromotionStatusV1?), TypeInfoPropertyName = "NullableCancelPromotionStatusV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CheckpointSyncStatus?), TypeInfoPropertyName = "NullableCheckpointSyncStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.V1AvailabilityModel?), TypeInfoPropertyName = "NullableV1AvailabilityModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AnyOf<string, global::Baseten.SecretReferenceV1>?), TypeInfoPropertyName = "NullableAnyOfStringSecretReferenceV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DockerAuthType?), TypeInfoPropertyName = "NullableDockerAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.V1InteractiveSessionTrigger?), TypeInfoPropertyName = "NullableV1InteractiveSessionTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.V1InteractiveSessionProvider?), TypeInfoPropertyName = "NullableV1InteractiveSessionProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.V1InteractiveSessionAuthProvider?), TypeInfoPropertyName = "NullableV1InteractiveSessionAuthProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CheckpointsItem?), TypeInfoPropertyName = "NullableCheckpointsItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp?), TypeInfoPropertyName = "NullableLoadCheckpointConfigCheckpointDiscriminatorTyp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsCheckpointConfigTarget?), TypeInfoPropertyName = "NullableLoopsCheckpointConfigTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoopsRunStatusNameV1?), TypeInfoPropertyName = "NullableLoopsRunStatusNameV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainerCheckpointTarget?), TypeInfoPropertyName = "NullableTrainerCheckpointTarget2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.Name?), TypeInfoPropertyName = "NullableName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.APIKeyCategory?), TypeInfoPropertyName = "NullableAPIKeyCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LimitTypeV1?), TypeInfoPropertyName = "NullableLimitTypeV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AnyOf<double?, string, object>?), TypeInfoPropertyName = "NullableAnyOfDoubleStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RateLimitUnitV1?), TypeInfoPropertyName = "NullableRateLimitUnitV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.BucketWidth?), TypeInfoPropertyName = "NullableBucketWidth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UsageDimensionV1?), TypeInfoPropertyName = "NullableUsageDimensionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LibraryListingMetadataV1InputModalitie?), TypeInfoPropertyName = "NullableLibraryListingMetadataV1InputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LibraryListingMetadataV1OutputModalitie?), TypeInfoPropertyName = "NullableLibraryListingMetadataV1OutputModalitie2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ResourceKind?), TypeInfoPropertyName = "NullableResourceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AnyOf<double?, string>?), TypeInfoPropertyName = "NullableAnyOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GatewayProvider?), TypeInfoPropertyName = "NullableGatewayProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SharedEndpointRegionV1?), TypeInfoPropertyName = "NullableSharedEndpointRegionV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UsageLimitUnitV1?), TypeInfoPropertyName = "NullableUsageLimitUnitV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LimitEnforcementV1?), TypeInfoPropertyName = "NullableLimitEnforcementV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.VolumeTagV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.VolumeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.VolumeTokenScopeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.VolumeVersionV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SecretV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.EnvironmentGroupUserV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.EnvironmentGroupV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.TeamV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.RegionV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.InstanceTypeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.InstanceTypeWithPriceV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.AuditLogEventAutoscalingScheduleChangeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.AuditLogEntryV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.AuditLogEventTypeGroupV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.AuditLogSourceV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ModelV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.DeploymentV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.LogV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.PatchOpsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ModelMetricDescriptorV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ModelMetricValueSetV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.AutoscalingScheduleWeekdayV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SchedulesItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.EnvironmentV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SchedulesItem2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ChainV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ChainletV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ChainDeploymentV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentSettingsRequestV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentSettingsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentAutoscalingSettingsUpdateV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentInstanceTypeUpdateV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.TrainingProjectV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.TrainingJobV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.CreateTrainingJobS3Artifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.CreateJobWeightConfigV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.CheckpointsItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.TrainingJobMetricV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Baseten.TrainingJobMetricV1>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.TrainingJobNodeMetricsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.TrainingJobCheckpointV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.CheckpointFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.AuthCodeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.FileSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.OrderByV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SupportedModelV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.LoopsRunV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.LoopsSamplerV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.LoopsCheckpointV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.LoopsDeploymentV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ResponseTimeDatapointV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.InferenceVolumeByStatusDatapointV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.LoopsDeploymentNodeMetricsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.TrainingGpuCapacityItemV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.TeamTrainingGpuCapacityItemV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ActiveJobAtSubmitV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.PendingJobAheadAtSubmitV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.QueueEventV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.APIKeyInfoV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.RateLimitV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ModelAPIV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ModelApisUsageResultV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ModelApisUsageBucketV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.UsageDimensionV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.LibraryListingMetadataV1InputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.LibraryListingMetadataV1OutputModalitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.LibraryListingV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.LibraryListingVersionV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.DailyDedicatedUsageV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.DedicatedItemV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.DailyModelApiUsageV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ModelApiItemV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.DailyTrainingUsageV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.TrainingItemV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.UserInfoV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.GatewayEventV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.EndpointTargetV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.EndpointV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.EndpointTargetRequestV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.EffectiveRateLimitV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.EffectiveUsageLimitV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ModelConfigV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.EffectiveModelConfigV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.UsageLimitV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.GroupV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.GatewayKeyInfoV1>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Baseten.JsonConverters.EventDataJsonConverter());
            options.Converters.Add(new global::Baseten.JsonConverters.SourceJsonConverter());
            options.Converters.Add(new global::Baseten.JsonConverters.PatchOpsItemJsonConverter());
            options.Converters.Add(new global::Baseten.JsonConverters.SchedulesItemJsonConverter());
            options.Converters.Add(new global::Baseten.JsonConverters.SchedulesItem2JsonConverter());
            options.Converters.Add(new global::Baseten.JsonConverters.CheckpointsItemJsonConverter());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<string, global::Baseten.SecretReferenceV1>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string, object>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>());
            options.Converters.Add(new global::Baseten.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Baseten.VolumeTokenScopeV1)

                    || typeToConvert == typeof(global::Baseten.VolumeTokenScopeV1?)

                    || typeToConvert == typeof(global::Baseten.AuditLogActorTypeV1)

                    || typeToConvert == typeof(global::Baseten.AuditLogActorTypeV1?)

                    || typeToConvert == typeof(global::Baseten.AuditLogApiKeyTypeV1)

                    || typeToConvert == typeof(global::Baseten.AuditLogApiKeyTypeV1?)

                    || typeToConvert == typeof(global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType)

                    || typeToConvert == typeof(global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType?)

                    || typeToConvert == typeof(global::Baseten.AuditLogEventAutoscalingScheduleActionV1)

                    || typeToConvert == typeof(global::Baseten.AuditLogEventAutoscalingScheduleActionV1?)

                    || typeToConvert == typeof(global::Baseten.AuditLogEventTypeV1)

                    || typeToConvert == typeof(global::Baseten.AuditLogEventTypeV1?)

                    || typeToConvert == typeof(global::Baseten.AuditLogPromotionControlActionV1)

                    || typeToConvert == typeof(global::Baseten.AuditLogPromotionControlActionV1?)

                    || typeToConvert == typeof(global::Baseten.AuditLogSourceV1)

                    || typeToConvert == typeof(global::Baseten.AuditLogSourceV1?)

                    || typeToConvert == typeof(global::Baseten.AuditLogEventTypeGroupV1)

                    || typeToConvert == typeof(global::Baseten.AuditLogEventTypeGroupV1?)

                    || typeToConvert == typeof(global::Baseten.AuditLogSortDirectionV1)

                    || typeToConvert == typeof(global::Baseten.AuditLogSortDirectionV1?)

                    || typeToConvert == typeof(global::Baseten.CreateModelRequestV1SourceDiscriminatorKind)

                    || typeToConvert == typeof(global::Baseten.CreateModelRequestV1SourceDiscriminatorKind?)

                    || typeToConvert == typeof(global::Baseten.DeploymentStatusV1)

                    || typeToConvert == typeof(global::Baseten.DeploymentStatusV1?)

                    || typeToConvert == typeof(global::Baseten.RequestBackpressurePolicyV1)

                    || typeToConvert == typeof(global::Baseten.RequestBackpressurePolicyV1?)

                    || typeToConvert == typeof(global::Baseten.CreateModelDeploymentRequestV1SourceDiscriminatorKind)

                    || typeToConvert == typeof(global::Baseten.CreateModelDeploymentRequestV1SourceDiscriminatorKind?)

                    || typeToConvert == typeof(global::Baseten.UpdateAutoscalingSettingsStatusV1)

                    || typeToConvert == typeof(global::Baseten.UpdateAutoscalingSettingsStatusV1?)

                    || typeToConvert == typeof(global::Baseten.DeploymentConfigOutputFormat)

                    || typeToConvert == typeof(global::Baseten.DeploymentConfigOutputFormat?)

                    || typeToConvert == typeof(global::Baseten.LogLevelV1)

                    || typeToConvert == typeof(global::Baseten.LogLevelV1?)

                    || typeToConvert == typeof(global::Baseten.SortOrderV1)

                    || typeToConvert == typeof(global::Baseten.SortOrderV1?)

                    || typeToConvert == typeof(global::Baseten.DeploymentPatchActionV1)

                    || typeToConvert == typeof(global::Baseten.DeploymentPatchActionV1?)

                    || typeToConvert == typeof(global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType)

                    || typeToConvert == typeof(global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType?)

                    || typeToConvert == typeof(global::Baseten.ModelMetricKindV1)

                    || typeToConvert == typeof(global::Baseten.ModelMetricKindV1?)

                    || typeToConvert == typeof(global::Baseten.ModelMetricModeV1)

                    || typeToConvert == typeof(global::Baseten.ModelMetricModeV1?)

                    || typeToConvert == typeof(global::Baseten.ModelMetricUnitHintV1)

                    || typeToConvert == typeof(global::Baseten.ModelMetricUnitHintV1?)

                    || typeToConvert == typeof(global::Baseten.AutoscalingScheduleV1Cadence)

                    || typeToConvert == typeof(global::Baseten.AutoscalingScheduleV1Cadence?)

                    || typeToConvert == typeof(global::Baseten.AutoscalingScheduleWeekdayV1)

                    || typeToConvert == typeof(global::Baseten.AutoscalingScheduleWeekdayV1?)

                    || typeToConvert == typeof(global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence)

                    || typeToConvert == typeof(global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence?)

                    || typeToConvert == typeof(global::Baseten.InProgressPromotionStatusV1)

                    || typeToConvert == typeof(global::Baseten.InProgressPromotionStatusV1?)

                    || typeToConvert == typeof(global::Baseten.PromotionCleanupStrategyV1)

                    || typeToConvert == typeof(global::Baseten.PromotionCleanupStrategyV1?)

                    || typeToConvert == typeof(global::Baseten.RollingDeployStrategyV1)

                    || typeToConvert == typeof(global::Baseten.RollingDeployStrategyV1?)

                    || typeToConvert == typeof(global::Baseten.AutoscalingScheduleUpsertV1Cadence)

                    || typeToConvert == typeof(global::Baseten.AutoscalingScheduleUpsertV1Cadence?)

                    || typeToConvert == typeof(global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence)

                    || typeToConvert == typeof(global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence?)

                    || typeToConvert == typeof(global::Baseten.CancelPromotionStatusV1)

                    || typeToConvert == typeof(global::Baseten.CancelPromotionStatusV1?)

                    || typeToConvert == typeof(global::Baseten.CheckpointSyncStatus)

                    || typeToConvert == typeof(global::Baseten.CheckpointSyncStatus?)

                    || typeToConvert == typeof(global::Baseten.V1AvailabilityModel)

                    || typeToConvert == typeof(global::Baseten.V1AvailabilityModel?)

                    || typeToConvert == typeof(global::Baseten.DockerAuthType)

                    || typeToConvert == typeof(global::Baseten.DockerAuthType?)

                    || typeToConvert == typeof(global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp)

                    || typeToConvert == typeof(global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp?)

                    || typeToConvert == typeof(global::Baseten.LoopsCheckpointConfigTarget)

                    || typeToConvert == typeof(global::Baseten.LoopsCheckpointConfigTarget?)

                    || typeToConvert == typeof(global::Baseten.V1InteractiveSessionAuthProvider)

                    || typeToConvert == typeof(global::Baseten.V1InteractiveSessionAuthProvider?)

                    || typeToConvert == typeof(global::Baseten.V1InteractiveSessionProvider)

                    || typeToConvert == typeof(global::Baseten.V1InteractiveSessionProvider?)

                    || typeToConvert == typeof(global::Baseten.V1InteractiveSessionTrigger)

                    || typeToConvert == typeof(global::Baseten.V1InteractiveSessionTrigger?)

                    || typeToConvert == typeof(global::Baseten.LoopsRunStatusNameV1)

                    || typeToConvert == typeof(global::Baseten.LoopsRunStatusNameV1?)

                    || typeToConvert == typeof(global::Baseten.TrainerCheckpointTarget)

                    || typeToConvert == typeof(global::Baseten.TrainerCheckpointTarget?)

                    || typeToConvert == typeof(global::Baseten.Name)

                    || typeToConvert == typeof(global::Baseten.Name?)

                    || typeToConvert == typeof(global::Baseten.APIKeyCategory)

                    || typeToConvert == typeof(global::Baseten.APIKeyCategory?)

                    || typeToConvert == typeof(global::Baseten.LimitTypeV1)

                    || typeToConvert == typeof(global::Baseten.LimitTypeV1?)

                    || typeToConvert == typeof(global::Baseten.RateLimitUnitV1)

                    || typeToConvert == typeof(global::Baseten.RateLimitUnitV1?)

                    || typeToConvert == typeof(global::Baseten.BucketWidth)

                    || typeToConvert == typeof(global::Baseten.BucketWidth?)

                    || typeToConvert == typeof(global::Baseten.UsageDimensionV1)

                    || typeToConvert == typeof(global::Baseten.UsageDimensionV1?)

                    || typeToConvert == typeof(global::Baseten.LibraryListingMetadataV1InputModalitie)

                    || typeToConvert == typeof(global::Baseten.LibraryListingMetadataV1InputModalitie?)

                    || typeToConvert == typeof(global::Baseten.LibraryListingMetadataV1OutputModalitie)

                    || typeToConvert == typeof(global::Baseten.LibraryListingMetadataV1OutputModalitie?)

                    || typeToConvert == typeof(global::Baseten.ResourceKind)

                    || typeToConvert == typeof(global::Baseten.ResourceKind?)

                    || typeToConvert == typeof(global::Baseten.GatewayProvider)

                    || typeToConvert == typeof(global::Baseten.GatewayProvider?)

                    || typeToConvert == typeof(global::Baseten.SharedEndpointRegionV1)

                    || typeToConvert == typeof(global::Baseten.SharedEndpointRegionV1?)

                    || typeToConvert == typeof(global::Baseten.LimitEnforcementV1)

                    || typeToConvert == typeof(global::Baseten.LimitEnforcementV1?)

                    || typeToConvert == typeof(global::Baseten.UsageLimitUnitV1)

                    || typeToConvert == typeof(global::Baseten.UsageLimitUnitV1?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Baseten.VolumeTokenScopeV1))
                {
                    return new global::Baseten.JsonConverters.VolumeTokenScopeV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.VolumeTokenScopeV1?))
                {
                    return new global::Baseten.JsonConverters.VolumeTokenScopeV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogActorTypeV1))
                {
                    return new global::Baseten.JsonConverters.AuditLogActorTypeV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogActorTypeV1?))
                {
                    return new global::Baseten.JsonConverters.AuditLogActorTypeV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogApiKeyTypeV1))
                {
                    return new global::Baseten.JsonConverters.AuditLogApiKeyTypeV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogApiKeyTypeV1?))
                {
                    return new global::Baseten.JsonConverters.AuditLogApiKeyTypeV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType))
                {
                    return new global::Baseten.JsonConverters.AuditLogEntryV1EventDataDiscriminatorEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType?))
                {
                    return new global::Baseten.JsonConverters.AuditLogEntryV1EventDataDiscriminatorEventTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogEventAutoscalingScheduleActionV1))
                {
                    return new global::Baseten.JsonConverters.AuditLogEventAutoscalingScheduleActionV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogEventAutoscalingScheduleActionV1?))
                {
                    return new global::Baseten.JsonConverters.AuditLogEventAutoscalingScheduleActionV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogEventTypeV1))
                {
                    return new global::Baseten.JsonConverters.AuditLogEventTypeV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogEventTypeV1?))
                {
                    return new global::Baseten.JsonConverters.AuditLogEventTypeV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogPromotionControlActionV1))
                {
                    return new global::Baseten.JsonConverters.AuditLogPromotionControlActionV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogPromotionControlActionV1?))
                {
                    return new global::Baseten.JsonConverters.AuditLogPromotionControlActionV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogSourceV1))
                {
                    return new global::Baseten.JsonConverters.AuditLogSourceV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogSourceV1?))
                {
                    return new global::Baseten.JsonConverters.AuditLogSourceV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogEventTypeGroupV1))
                {
                    return new global::Baseten.JsonConverters.AuditLogEventTypeGroupV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogEventTypeGroupV1?))
                {
                    return new global::Baseten.JsonConverters.AuditLogEventTypeGroupV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogSortDirectionV1))
                {
                    return new global::Baseten.JsonConverters.AuditLogSortDirectionV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AuditLogSortDirectionV1?))
                {
                    return new global::Baseten.JsonConverters.AuditLogSortDirectionV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.CreateModelRequestV1SourceDiscriminatorKind))
                {
                    return new global::Baseten.JsonConverters.CreateModelRequestV1SourceDiscriminatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.CreateModelRequestV1SourceDiscriminatorKind?))
                {
                    return new global::Baseten.JsonConverters.CreateModelRequestV1SourceDiscriminatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.DeploymentStatusV1))
                {
                    return new global::Baseten.JsonConverters.DeploymentStatusV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.DeploymentStatusV1?))
                {
                    return new global::Baseten.JsonConverters.DeploymentStatusV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.RequestBackpressurePolicyV1))
                {
                    return new global::Baseten.JsonConverters.RequestBackpressurePolicyV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.RequestBackpressurePolicyV1?))
                {
                    return new global::Baseten.JsonConverters.RequestBackpressurePolicyV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.CreateModelDeploymentRequestV1SourceDiscriminatorKind))
                {
                    return new global::Baseten.JsonConverters.CreateModelDeploymentRequestV1SourceDiscriminatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.CreateModelDeploymentRequestV1SourceDiscriminatorKind?))
                {
                    return new global::Baseten.JsonConverters.CreateModelDeploymentRequestV1SourceDiscriminatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.UpdateAutoscalingSettingsStatusV1))
                {
                    return new global::Baseten.JsonConverters.UpdateAutoscalingSettingsStatusV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.UpdateAutoscalingSettingsStatusV1?))
                {
                    return new global::Baseten.JsonConverters.UpdateAutoscalingSettingsStatusV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.DeploymentConfigOutputFormat))
                {
                    return new global::Baseten.JsonConverters.DeploymentConfigOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.DeploymentConfigOutputFormat?))
                {
                    return new global::Baseten.JsonConverters.DeploymentConfigOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LogLevelV1))
                {
                    return new global::Baseten.JsonConverters.LogLevelV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LogLevelV1?))
                {
                    return new global::Baseten.JsonConverters.LogLevelV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SortOrderV1))
                {
                    return new global::Baseten.JsonConverters.SortOrderV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SortOrderV1?))
                {
                    return new global::Baseten.JsonConverters.SortOrderV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.DeploymentPatchActionV1))
                {
                    return new global::Baseten.JsonConverters.DeploymentPatchActionV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.DeploymentPatchActionV1?))
                {
                    return new global::Baseten.JsonConverters.DeploymentPatchActionV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType))
                {
                    return new global::Baseten.JsonConverters.CreateDeploymentPatchRequestV1PatchOpDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType?))
                {
                    return new global::Baseten.JsonConverters.CreateDeploymentPatchRequestV1PatchOpDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.ModelMetricKindV1))
                {
                    return new global::Baseten.JsonConverters.ModelMetricKindV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.ModelMetricKindV1?))
                {
                    return new global::Baseten.JsonConverters.ModelMetricKindV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.ModelMetricModeV1))
                {
                    return new global::Baseten.JsonConverters.ModelMetricModeV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.ModelMetricModeV1?))
                {
                    return new global::Baseten.JsonConverters.ModelMetricModeV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.ModelMetricUnitHintV1))
                {
                    return new global::Baseten.JsonConverters.ModelMetricUnitHintV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.ModelMetricUnitHintV1?))
                {
                    return new global::Baseten.JsonConverters.ModelMetricUnitHintV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AutoscalingScheduleV1Cadence))
                {
                    return new global::Baseten.JsonConverters.AutoscalingScheduleV1CadenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AutoscalingScheduleV1Cadence?))
                {
                    return new global::Baseten.JsonConverters.AutoscalingScheduleV1CadenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AutoscalingScheduleWeekdayV1))
                {
                    return new global::Baseten.JsonConverters.AutoscalingScheduleWeekdayV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AutoscalingScheduleWeekdayV1?))
                {
                    return new global::Baseten.JsonConverters.AutoscalingScheduleWeekdayV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence))
                {
                    return new global::Baseten.JsonConverters.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence?))
                {
                    return new global::Baseten.JsonConverters.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.InProgressPromotionStatusV1))
                {
                    return new global::Baseten.JsonConverters.InProgressPromotionStatusV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.InProgressPromotionStatusV1?))
                {
                    return new global::Baseten.JsonConverters.InProgressPromotionStatusV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.PromotionCleanupStrategyV1))
                {
                    return new global::Baseten.JsonConverters.PromotionCleanupStrategyV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.PromotionCleanupStrategyV1?))
                {
                    return new global::Baseten.JsonConverters.PromotionCleanupStrategyV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.RollingDeployStrategyV1))
                {
                    return new global::Baseten.JsonConverters.RollingDeployStrategyV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.RollingDeployStrategyV1?))
                {
                    return new global::Baseten.JsonConverters.RollingDeployStrategyV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AutoscalingScheduleUpsertV1Cadence))
                {
                    return new global::Baseten.JsonConverters.AutoscalingScheduleUpsertV1CadenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.AutoscalingScheduleUpsertV1Cadence?))
                {
                    return new global::Baseten.JsonConverters.AutoscalingScheduleUpsertV1CadenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence))
                {
                    return new global::Baseten.JsonConverters.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadenceJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence?))
                {
                    return new global::Baseten.JsonConverters.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.CancelPromotionStatusV1))
                {
                    return new global::Baseten.JsonConverters.CancelPromotionStatusV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.CancelPromotionStatusV1?))
                {
                    return new global::Baseten.JsonConverters.CancelPromotionStatusV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.CheckpointSyncStatus))
                {
                    return new global::Baseten.JsonConverters.CheckpointSyncStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.CheckpointSyncStatus?))
                {
                    return new global::Baseten.JsonConverters.CheckpointSyncStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.V1AvailabilityModel))
                {
                    return new global::Baseten.JsonConverters.V1AvailabilityModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.V1AvailabilityModel?))
                {
                    return new global::Baseten.JsonConverters.V1AvailabilityModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.DockerAuthType))
                {
                    return new global::Baseten.JsonConverters.DockerAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.DockerAuthType?))
                {
                    return new global::Baseten.JsonConverters.DockerAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp))
                {
                    return new global::Baseten.JsonConverters.LoadCheckpointConfigCheckpointDiscriminatorTypJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp?))
                {
                    return new global::Baseten.JsonConverters.LoadCheckpointConfigCheckpointDiscriminatorTypNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LoopsCheckpointConfigTarget))
                {
                    return new global::Baseten.JsonConverters.LoopsCheckpointConfigTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LoopsCheckpointConfigTarget?))
                {
                    return new global::Baseten.JsonConverters.LoopsCheckpointConfigTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.V1InteractiveSessionAuthProvider))
                {
                    return new global::Baseten.JsonConverters.V1InteractiveSessionAuthProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.V1InteractiveSessionAuthProvider?))
                {
                    return new global::Baseten.JsonConverters.V1InteractiveSessionAuthProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.V1InteractiveSessionProvider))
                {
                    return new global::Baseten.JsonConverters.V1InteractiveSessionProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.V1InteractiveSessionProvider?))
                {
                    return new global::Baseten.JsonConverters.V1InteractiveSessionProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.V1InteractiveSessionTrigger))
                {
                    return new global::Baseten.JsonConverters.V1InteractiveSessionTriggerJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.V1InteractiveSessionTrigger?))
                {
                    return new global::Baseten.JsonConverters.V1InteractiveSessionTriggerNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LoopsRunStatusNameV1))
                {
                    return new global::Baseten.JsonConverters.LoopsRunStatusNameV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LoopsRunStatusNameV1?))
                {
                    return new global::Baseten.JsonConverters.LoopsRunStatusNameV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.TrainerCheckpointTarget))
                {
                    return new global::Baseten.JsonConverters.TrainerCheckpointTargetJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.TrainerCheckpointTarget?))
                {
                    return new global::Baseten.JsonConverters.TrainerCheckpointTargetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.Name))
                {
                    return new global::Baseten.JsonConverters.NameJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.Name?))
                {
                    return new global::Baseten.JsonConverters.NameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.APIKeyCategory))
                {
                    return new global::Baseten.JsonConverters.APIKeyCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.APIKeyCategory?))
                {
                    return new global::Baseten.JsonConverters.APIKeyCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LimitTypeV1))
                {
                    return new global::Baseten.JsonConverters.LimitTypeV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LimitTypeV1?))
                {
                    return new global::Baseten.JsonConverters.LimitTypeV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.RateLimitUnitV1))
                {
                    return new global::Baseten.JsonConverters.RateLimitUnitV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.RateLimitUnitV1?))
                {
                    return new global::Baseten.JsonConverters.RateLimitUnitV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.BucketWidth))
                {
                    return new global::Baseten.JsonConverters.BucketWidthJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.BucketWidth?))
                {
                    return new global::Baseten.JsonConverters.BucketWidthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.UsageDimensionV1))
                {
                    return new global::Baseten.JsonConverters.UsageDimensionV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.UsageDimensionV1?))
                {
                    return new global::Baseten.JsonConverters.UsageDimensionV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LibraryListingMetadataV1InputModalitie))
                {
                    return new global::Baseten.JsonConverters.LibraryListingMetadataV1InputModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LibraryListingMetadataV1InputModalitie?))
                {
                    return new global::Baseten.JsonConverters.LibraryListingMetadataV1InputModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LibraryListingMetadataV1OutputModalitie))
                {
                    return new global::Baseten.JsonConverters.LibraryListingMetadataV1OutputModalitieJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LibraryListingMetadataV1OutputModalitie?))
                {
                    return new global::Baseten.JsonConverters.LibraryListingMetadataV1OutputModalitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.ResourceKind))
                {
                    return new global::Baseten.JsonConverters.ResourceKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.ResourceKind?))
                {
                    return new global::Baseten.JsonConverters.ResourceKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.GatewayProvider))
                {
                    return new global::Baseten.JsonConverters.GatewayProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.GatewayProvider?))
                {
                    return new global::Baseten.JsonConverters.GatewayProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SharedEndpointRegionV1))
                {
                    return new global::Baseten.JsonConverters.SharedEndpointRegionV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.SharedEndpointRegionV1?))
                {
                    return new global::Baseten.JsonConverters.SharedEndpointRegionV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LimitEnforcementV1))
                {
                    return new global::Baseten.JsonConverters.LimitEnforcementV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.LimitEnforcementV1?))
                {
                    return new global::Baseten.JsonConverters.LimitEnforcementV1NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.UsageLimitUnitV1))
                {
                    return new global::Baseten.JsonConverters.UsageLimitUnitV1JsonConverter();
                }

                if (typeToConvert == typeof(global::Baseten.UsageLimitUnitV1?))
                {
                    return new global::Baseten.JsonConverters.UsageLimitUnitV1NullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}