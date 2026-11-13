
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        /// String arrays used by dynamic JSON option values.
        /// </summary>
        public string[]? StringArray { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PaginationResponseV1? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeTagV1? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeV1? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeVersionSummaryV1? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.VolumeTagV1>? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListVolumesResponseV1? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.VolumeV1>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListVolumesRequestV1? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeTokenScopeV1? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateVolumeTokenRequestV1? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.VolumeTokenScopeV1>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateVolumeTokenResponseV1? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListVolumeNamespacesResponseV1? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListVolumeNamespacesRequestV1? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncAuthenticationAWSAssumeRoleV1? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncAuthenticationAWSOIDCV1? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncAuthenticationGCPOIDCV1? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncAuthenticationHuggingFaceOIDCV1? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncDestinationV1? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncErrorV1? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceAzureV1? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceBasetenTrainingV1? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceCoreWeaveV1? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceGCSV1? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceHuggingFaceV1? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceR2V1? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceS3V1? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncStatusV1? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncV1? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Source? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncV1SourceDiscriminator? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncV1SourceDiscriminatorType? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncsV1? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.VolumeSyncV1>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncsRequestV1? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateVolumeSyncRequestV1? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Source2? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminator? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminatorType? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeleteVolumeRequestV1? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeleteVolumeResponseV1? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchVolumeRequestV1? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchVolumeResponseV1? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeVersionV1? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListVolumeVersionsResponseV1? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.VolumeVersionV1>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListVolumeVersionsRequestV1? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeleteVolumeVersionRequestV1? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeleteVolumeVersionResponseV1? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeVersionDetailV1? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RestoreVolumeVersionRequestV1? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RestoreVolumeVersionResponseV1? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SetVolumeTagRequestV1? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SetVolumeTagResponseV1? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeleteVolumeTagRequestV1? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeleteVolumeTagResponseV1? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TokenScopeV1? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTokenRequestV1? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TokenScopeV1>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TokenV1? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SecretV1? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SecretsV1? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SecretV1>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertSecretRequestV1? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SecretTombstoneV1? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentGroupManageAccessV1? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EnvironmentGroupUserV1>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentGroupUserV1? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentGroupV1? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentGroupsV1? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EnvironmentGroupV1>? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateEnvironmentGroupManageAccessV1? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateEnvironmentGroupRequestV1? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TeamV1? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TeamsV1? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TeamV1>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TeamsRequestV1? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RegionV1? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RegionsV1? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.RegionV1>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InstanceTypeV1? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InstanceTypesV1? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.InstanceTypeV1>? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsUserConfigV1? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsUserConfigResponseV1? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchLoopsUserConfigRequestV1? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchLoopsUserConfigResponseV1? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InstanceTypeWithPriceV1? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InstanceTypePricesV1? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.InstanceTypeWithPriceV1>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleSettingsRequestV1? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleUpsertV1? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleUpsertV1Cadence? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.AutoscalingScheduleWeekdayV1>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleWeekdayV1? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentArchivePayloadV1? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateAutoscalingSettingsV1? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateRequestBackpressureSettingsV1? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateAutoscalingScheduleSettingsV1? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdatePromotionSettingsV1? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.OneTimeAutoscalingScheduleUpsertV1? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PromotionCleanupStrategyV1? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RequestBackpressurePolicyV1? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RollingDeployStrategyV1? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SchedulesItem>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SchedulesItem? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminator? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateRollingDeployConfigV1? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PrepareModelUploadRequestV1? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AWSCredentialsV1? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PrepareModelUploadResponseV1? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogActorTypeV1? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogActorV1? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogApiKeyRevocationReasonV1? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogApiKeyTypeV1? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEntryV1? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventTypeV1? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EventData? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeployedV1? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentActivatedV1? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentDeactivatedV1? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentRetriedV1? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentPromotedV1? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentRequestBackpressureSettingsChangedV1? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentDeletedV1? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeletedV1? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelRenamedV1? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainDeployedV1? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainDeploymentActivatedV1? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainDeploymentDeactivatedV1? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainDeploymentPromotedV1? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainletInstanceTypeChangedV1? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainDeploymentDeletedV1? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainDeletedV1? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainEnvironmentCreatedV1? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainEnvironmentUpdatedV1? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventSecretUpdatedV1? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventSecretDeletedV1? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventApiKeyCreatedV1? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventApiKeyDeletedV1? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventApiKeyLifetimeLimitsUpdatedV1? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventOrganizationApiKeySettingsUpdatedV1? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventGatewayEndpointCreatedV1? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventGatewayEndpointUpdatedV1? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventGatewayEndpointDeletedV1? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventProviderConnectionCreatedV1? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventProviderConnectionUpdatedV1? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventProviderConnectionDeletedV1? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventGridMachineUserCreatedV1? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventGridMachineUserUpdatedV1? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventGridMachineUserDeletedV1? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventUserInvitedV1? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventUserJoinedOrganizationV1? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventUserRoleUpdatedV1? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventUserTeamRoleUpdatedV1? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventUserRemovedV1? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventEnvironmentCreatedV1? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventEnvironmentUpdatedV1? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventEnvironmentDeletedV1? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventReplicaTerminatedV1? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelPromotionControlActionV1? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventSshCertificateSignedV1? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventVolumeDeletedV1? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventVolumeVersionDeletedV1? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventVolumeVersionRestoredV1? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventVolumeTagSetV1? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventVolumeTagDeletedV1? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventVolumeUpdatedV1? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventTelemetryExportCreatedV1? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventTelemetryExportUpdatedV1? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventTelemetryExportDeletedV1? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEntryV1EventDataDiscriminator? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogSourceV1? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventAutoscalingScheduleActionV1? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventAutoscalingScheduleChangeV1? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventAutoscalingScheduleSettingsV1? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventAutoscalingScheduleOperationsV1? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.AuditLogEventAutoscalingScheduleUpsertV1>? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventAutoscalingScheduleUpsertV1? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventAutoscalingSettingsUpdateV1? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventAutoscalingSettingsV1? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventEnvironmentSettingsV1? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.AuditLogEventAutoscalingScheduleChangeV1>? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventPromotionSettingsOverrideV1? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventRequestBackpressureSettingsUpdateV1? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogPromotionControlActionV1? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListAuditLogsResponseV1? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.AuditLogEntryV1>? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventTypeGroupV1? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogSortDirectionV1? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListAuditLogsRequestV1? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.AuditLogEventTypeGroupV1>? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.AuditLogSourceV1>? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelV1? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelsV1? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelV1>? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelsRequestV1? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingSourceV1? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelArchiveSourceV1? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateModelRequestV1? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Source3? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateModelRequestV1SourceDiscriminator? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateModelRequestV1SourceDiscriminatorKind? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingSettingsV1? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentStatusV1? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentV1? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RequestBackpressureSettingsV1? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreatedModelDeploymentV1? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelTombstoneV1? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateModelRequestV1? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentsV1? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.DeploymentV1>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentsRequestV1? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentArchiveSourceV1? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateModelDeploymentRequestV1? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateModelDeploymentRequestV1SourceDiscriminator? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateModelDeploymentRequestV1SourceDiscriminatorKind? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentTombstoneV1? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateDeploymentRequestV1? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateAutoscalingSettingsStatusV1? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateAutoscalingSettingsResponseV1? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PromotionEnvironmentSettingsUpdateV1? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PromoteRequestV1? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ActivateResponseV1? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeactivateResponseV1? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RetryDeploymentResponseV1? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DownloadDeploymentResponseV1? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentConfigResponseV1? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentConfigOutputFormat? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetDeploymentConfigRequestV1? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LogLevelV1? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LogV1? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLogsResponseV1? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LogV1>? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SortOrderV1? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetDeploymentLogsRequestV1? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchActionV1? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchOpConfigV1? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchOpEnvVarV1? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchOpExternalDataV1? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchOpModelCodeV1? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchOpPackageV1? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchOpPythonRequirementV1? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchPointV1? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateDeploymentPatchRequestV1? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.PatchOpsItem>? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchOpsItem? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminator? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchPointWithHashV1? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateDeploymentPatchResponseV1? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetDeploymentPatchesStateResponseV1? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SyncDeploymentPatchesRequestV1? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SyncDeploymentPatchesResponseV1? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.MetricDescriptorV1? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.MetricUnitHintV1? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.MetricKindV1? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.MetricModeV1? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.MetricValueSetV1? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double?>>? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double?>? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetMetricsResponseV1? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.MetricDescriptorV1>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.MetricValueSetV1>? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetDeploymentMetricsRequestV1? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StartupAttemptV1? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StartupOutcomeV1? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.StartupPhaseSummaryV1>? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StartupPhaseSummaryV1? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StartupPhaseStatusV1? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StartupPhaseV1? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StartupAttemptsV1? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.StartupAttemptV1>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StartupSortFieldV1? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetStartupAttemptsRequestV1? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.StartupOutcomeV1>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StartupPercentilesV1? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StartupPhasePercentilesV1? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StartupSummaryV1? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.StartupPhasePercentilesV1>? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetStartupSummaryRequestV1? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TerminateReplicaResponseV1? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SignSSHCertificateRequestV1? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SignSSHCertificateResponseV1? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleSettingsV1? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleStateV1? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleV1? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleV1Cadence? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentAutoscalingSchedulesV1? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SchedulesItem2>? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SchedulesItem2? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.OneTimeAutoscalingScheduleV1? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminator? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentTrafficRoutingV1? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrafficRoutingRuleV1>? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrafficRoutingRuleV1? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentV1? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InProgressPromotionV1? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelPromotionSettingsV1? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InProgressPromotionStatusV1? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RollingDeployConfigV1? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrafficRoutingRuleShadowSamplingModeV1? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrafficRoutingTargetV1>? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrafficRoutingTargetV1? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentsV1? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EnvironmentV1>? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateModelPromotionSettingsV1? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateEnvironmentRequestV1? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentTombstoneV1? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrafficRoutingRuleUpsertV1? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrafficRoutingTargetUpsertV1>? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrafficRoutingTargetUpsertV1? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateTrafficRoutingSettingsV1? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrafficRoutingRuleUpsertV1>? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateEnvironmentRequestV1? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateEnvironmentResponseV1? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetEnvironmentLogsRequestV1? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetEnvironmentMetricsRequestV1? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PromoteToEnvironmentRequestV1? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CancelPromotionStatusV1? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CancelPromotionResponseV1? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SignalPromotionResponseV1? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainV1? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainsV1? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ChainV1>? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainTombstoneV1? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainDeploymentV1? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ChainletV1>? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainletV1? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainDeploymentsV1? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ChainDeploymentV1>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainDeploymentTombstoneV1? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainletEnvironmentSettingsRequestV1? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateChainEnvironmentRequestV1? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentSettingsRequestV1>? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainletEnvironmentSettingsV1? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PromotionSettingsV1? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainEnvironmentV1? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentSettingsV1>? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateChainEnvironmentRequestV1? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateChainEnvironmentResponseV1? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PromoteToChainEnvironmentRequestV1? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainletEnvironmentAutoscalingSettingsUpdateV1? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateChainletEnvironmentAutoscalingSettingsRequestV1? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentAutoscalingSettingsUpdateV1>? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainletEnvironmentInstanceTypeUpdateV1? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateChainletEnvironmentInstanceTypeRequestV1? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentInstanceTypeUpdateV1>? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateChainletEnvironmentInstanceTypeResponseV1? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertTrainingProjectV1? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertTrainingProjectRequestV1? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AvailabilityModelV1? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CheckpointSyncStatus? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingJobV1? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingProjectSummaryV1? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UserV1? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingProjectV1? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertTrainingProjectResponseV1? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListTrainingProjectsResponseV1? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrainingProjectV1>? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListTrainingProjectsRequestV1? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListTrainingJobsResponseV1? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrainingJobV1>? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuthMethod? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AwsAssumeRoleDockerAuthV1? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AwsIamDockerAuthV1? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SecretReferenceV1? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AwsOidcDockerAuthV1? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.BasetenLatestCheckpointConfig? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.BasetenNamedCheckpointConfig? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateJobWeightConfigV1? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingWeightAuthV1? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobAcceleratorV1? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobCacheConfig? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobCheckpointingConfig? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobComputeV1? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobImageV1? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DockerAuthV1? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobRuntimeV1? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AnyOf<string, global::Baseten.SecretReferenceV1>? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.CreateTrainingJobS3Artifact>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobS3Artifact? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoadCheckpointConfig? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobV1? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrussUserEnv? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InteractiveSessionConfigV1? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.CreateJobWeightConfigV1>? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DockerAuthType? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GcpServiceAccountJsonDockerAuthV1? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GcpOidcDockerAuthV1? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RegistrySecretDockerAuthV1? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GitInfo? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.V1InteractiveSessionTrigger? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.V1InteractiveSessionProvider? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.V1InteractiveSessionAuthProvider? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.CheckpointsItem>? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CheckpointsItem? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointConfig? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoadCheckpointConfigCheckpointDiscriminator? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointConfigTarget? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobRequestV1? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobResponseV1? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingJobTombstoneV1? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobResponseV1? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateTrainingJobRequestV1? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateTrainingJobResponseV1? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DownloadTrainingJobResponseV1? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RecreateTrainingJobResponseV1? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobLogsRequestV1? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StorageMetricsV1? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingJobMetricV1? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingJobMetricsV1? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>>? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingJobNodeMetricsV1? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobMetricsResponseV1? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrainingJobNodeMetricsV1>? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobMetricsRequestV1? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StopTrainingJobRequestV1? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StopTrainingJobResponseV1? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingJobCheckpointV1? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobCheckpointsResponseV1? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrainingJobCheckpointV1>? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CheckpointFile? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobCheckpointFilesResponseV1? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.CheckpointFile>? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobCheckpointFilesRequestV1? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuthCodeV1? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetAuthCodesResponseV1? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.AuthCodeV1>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchInteractiveSessionRequestV1? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InteractiveSessionV1? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchInteractiveSessionResponseV1? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.FileSummary? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetCacheSummaryResponseV1? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.FileSummary>? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingProjectTombstoneV1? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingProjectResponseV1? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.OrderByV1? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SearchTrainingJobsRequestV1? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.OrderByV1>? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SearchTrainingJobsResponseV1? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnablementDetailsV1? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SupportedModelV1? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsCapabilitiesResponseV1? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SupportedModelV1>? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsUseCaseV1? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsCapabilitiesQueryParamsV1? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsSessionV1? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLoopsSessionResponseV1? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsSessionResponseV1? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsRunStatusNameV1? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsRunStatusV1? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsRunV1? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsSamplerV1? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsSamplerStatusV1? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsRunsResponseV1? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LoopsRunV1>? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsRunsQueryParamsV1? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLoopsRunRequestV1? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLoopsRunResponseV1? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeactivateLoopsRunResponseV1? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointV1? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsLoRAConfigV1? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainerCheckpointTarget? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsLoRAConfigV1ExpertLayout? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeleteLoopsRunResponseV1? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LoopsCheckpointV1>? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsRunResponseV1? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsPlacementScopeV1? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLoopsTrainerRequestV1? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsSamplersResponseV1? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LoopsSamplerV1>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsSamplersRequestV1? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLoopsSamplerRequestV1? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLoopsSamplerResponseV1? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeactivateLoopsSamplerResponseV1? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsSamplerResponseV1? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsCheckpointsResponseV1? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsCheckpointsQueryParamsV1? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ValidateLoopsCheckpointRequestV1? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ValidateLoopsCheckpointResponseV1? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeployLoopsCheckpointRequestV1? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeployLoopsCheckpointResponseV1? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointTombstoneV1? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointFilesResponseV1? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsCheckpointFilesRequestV1? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointS3SourceV1? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointVolumeSourceV1? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointSourceResponseV1? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Source4? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminator? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminatorKind? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsDeploymentStatusV1? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Name? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsDeploymentV1? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsDeploymentsResponseV1? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LoopsDeploymentV1>? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsDeploymentsRequestV1? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeactivateLoopsDeploymentResponseV1? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsDeploymentResponseV1? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsDebugArchiveFilesResponseV1? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsDebugArchiveFilesRequestV1? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsDeploymentMetricsRequestV1? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InferenceVolumeByStatusDatapointV1? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsDeploymentMetricsV1? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ResponseTimeDatapointV1>? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ResponseTimeDatapointV1? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.InferenceVolumeByStatusDatapointV1>? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LoopsDeploymentNodeMetricsV1>? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsDeploymentNodeMetricsV1? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsDeploymentMetricsResponseV1? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsDeploymentLogsRequestV1? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TeamTrainingGpuCapacityItemV1? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingGpuCapacityItemV1? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingGpuCapacityResponseV1? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrainingGpuCapacityItemV1>? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TeamTrainingGpuCapacityItemV1>? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchTeamTrainingGpuCapacityRequestV1? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchTeamTrainingGpuCapacityResponseV1? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ActiveJobAtSubmitV1? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CapacityAtSubmitV1? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PendingJobAheadAtSubmitV1? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.QueueEventV1? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobQueueContextResponseV1? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ActiveJobAtSubmitV1>? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.PendingJobAheadAtSubmitV1>? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.QueueEventV1>? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetBlobCredentialsResponseV1? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.APIKeyCategory? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateAPIKeyRequestV1? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.APIKeyV1? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.APIKeyInfoV1? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.APIKeyOwnerV1? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.APIKeysV1? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.APIKeyInfoV1>? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.APIKeysRequestV1? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.APIKeyTombstoneV1? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LimitTypeV1? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelAPIOrgDetailsV1? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelAPIRateLimitV1? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RateLimitUnitV1? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelAPIServiceTierV1? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelAPITeamDetailsV1? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelAPIRateLimitV1>? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AnyOf<double?, string>? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelAPIV1? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelAPITeamDetailsV1>? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelAPIsResponseV1? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelAPIV1>? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelAPIsRequestV1? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisUsageBucketV1? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelApisUsageResultV1>? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisUsageResultV1? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisUsageResponseV1? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelApisUsageBucketV1>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.BucketWidth? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UsageDimensionV1? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisUsageRequestV1? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.UsageDimensionV1>? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetModelAPIMetricsRequestV1? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelAPIRequestV1? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EgressRestrictionsV1? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LLMRuntimeV1? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RuntimeOidcV1? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLLMModelRequestV1? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LLMModelHandleV1? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLLMModelVersionRequestV1? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingMetadataV1? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LibraryListingModality>? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingModality? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingV1? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingsV1? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LibraryListingV1>? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLibraryListingRequestV1? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingTombstoneV1? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateLibraryListingRequestV1? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.BenchmarkSnapshotV1? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LLMBenchmarkMetricsV1? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TTSBenchmarkMetricsV1? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EmbeddingBenchmarkMetricsV1? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingVersionV1? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingVersionsV1? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LibraryListingVersionV1>? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLibraryListingVersionRequestV1? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingVersionTombstoneV1? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateLibraryListingVersionRequestV1? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisCostBucketV1? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelApisCostResultV1>? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisCostResultV1? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisCostsResponseV1? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelApisCostBucketV1>? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApiCostDimensionV1? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisCostsRequestV1? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelApiCostDimensionV1>? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.BillableResourceV1? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ResourceKind? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainMetadataV1? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DailyDedicatedUsageV1? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DailyLoopsUsageV1? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsMeterUsageV1? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DailyModelApiUsageV1? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DailyTrainingUsageV1? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DedicatedItemV1? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.DailyDedicatedUsageV1>? Type627 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DedicatedUsageV1? Type628 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.DedicatedItemV1>? Type629 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsBaseModelItemV1? Type630 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.DailyLoopsUsageV1>? Type631 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LoopsResourceItemV1>? Type632 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsResourceItemV1? Type633 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsUsageV1? Type634 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LoopsBaseModelItemV1>? Type635 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApiItemV1? Type636 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.DailyModelApiUsageV1>? Type637 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisUsageV1? Type638 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelApiItemV1>? Type639 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingItemV1? Type640 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.DailyTrainingUsageV1>? Type641 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingUsageV1? Type642 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrainingItemV1>? Type643 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UsageSummaryV1? Type644 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UsageSummaryRequestV1? Type645 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ToolCallUsageBucketV1? Type646 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ToolCallUsageResponseV1? Type647 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ToolCallUsageBucketV1>? Type648 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ToolCallUsageDimensionV1? Type649 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ToolCallUsageRequestV1? Type650 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ToolCallUsageDimensionV1>? Type651 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UserInfoV1? Type652 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UsersResponseV1? Type653 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.UserInfoV1>? Type654 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UsersRequestV1? Type655 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AwsAssumeRoleV1? Type656 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.OrganizationInfoV1? Type657 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateOrganizationRequestV1? Type658 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ServiceAccountPresetPermissionsV1? Type659 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ServiceAccountPresetTypeV1? Type660 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ServiceAccountV1? Type661 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ServiceAccountsV1? Type662 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ServiceAccountV1>? Type663 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ServiceAccountsRequestV1? Type664 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ServiceAccountPresetPermissionsRequestV1? Type665 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateServiceAccountRequestV1? Type666 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeletedServiceAccountV1? Type667 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateServiceAccountRequestV1? Type668 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PredefinedIdentityProviderKindV1? Type669 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PredefinedIdentityProviderV1? Type670 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PredefinedIdentityProvidersV1? Type671 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.PredefinedIdentityProviderV1>? Type672 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.IdentityProviderV1? Type673 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PredefinedIdentityProviderConfigV1? Type674 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.IdentityProvidersV1? Type675 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.IdentityProviderV1>? Type676 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.IdentityProvidersRequestV1? Type677 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreatePredefinedIdentityProviderConfigV1? Type678 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateIdentityProviderRequestV1? Type679 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeletedIdentityProviderV1? Type680 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateIdentityProviderRequestV1? Type681 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AccessTrustRuleV1? Type682 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AccessTrustRulesV1? Type683 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.AccessTrustRuleV1>? Type684 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AccessTrustRulesRequestV1? Type685 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateAccessTrustRuleRequestV1? Type686 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeletedAccessTrustRuleV1? Type687 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateAccessTrustRuleRequestV1? Type688 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GatewayEventTokensV1? Type689 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GatewayEventV1? Type690 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GatewayEventsResponseV1? Type691 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GatewayEventV1>? Type692 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GatewayEventsRequestV1? Type693 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ExploreCostV1? Type694 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ExploreCostValuesV1? Type695 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ExploreMetadataAPIFormatsV1? Type696 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ExploreMetadataV1? Type697 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ExploreMetadataResponseV1? Type698 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ExploreMetadataV1>? Type699 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ExploreMetadataRequestV1? Type700 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateGridTokenRequestV1? Type701 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridTokenV1? Type702 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteClassifierV1? Type703 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GridRouteClassifierV1SupportedTradeoff>? Type704 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteClassifierV1SupportedTradeoff? Type705 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteMetadataV1? Type706 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GridRouteMetadataV1ApiFormat>? Type707 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteMetadataV1ApiFormat? Type708 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteTargetBasetenModelAPIV1? Type709 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteTargetConnectionV1? Type710 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteTargetIntelligentV1? Type711 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteTargetIntelligentV1Tradeoff? Type712 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteV1? Type713 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Target? Type714 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteV1TargetDiscriminator? Type715 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteV1TargetDiscriminatorType? Type716 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRoutesResponseV1? Type717 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GridRouteV1>? Type718 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRoutesRequestV1? Type719 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridRouteTargetBasetenModelAPIV1? Type720 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridRouteTargetConnectionV1? Type721 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridRouteTargetIntelligentV1? Type722 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridRouteTargetIntelligentV1Tradeoff? Type723 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateGridRouteRequestV1? Type724 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Target2? Type725 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateGridRouteRequestV1TargetDiscriminator? Type726 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateGridRouteRequestV1TargetDiscriminatorType? Type727 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridProviderV1? Type728 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteUsageBucketV1? Type729 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GridRouteUsageResultV1>? Type730 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteUsageResultV1? Type731 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteUsageHarnessV1? Type732 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteUsageResponseV1? Type733 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GridRouteUsageBucketV1>? Type734 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteUsageDimensionV1? Type735 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteUsageRequestV1? Type736 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GridRouteUsageDimensionV1>? Type737 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GridProviderV1>? Type738 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GridRouteUsageHarnessV1>? Type739 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteTombstoneV1? Type740 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateGridRouteRequestV1? Type741 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridHarnessDefaultsV1? Type742 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridHarnessModelsV1? Type743 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridHarnessModelV1? Type744 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridSettingSourceV1? Type745 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridTeamSpendLimitSettingV1? Type746 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridTeamSettingsV1? Type747 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridTeamSettingsRequestV1? Type748 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateGridHarnessDefaultsV1? Type749 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateGridHarnessModelsV1? Type750 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateGridTeamSpendLimitSettingV1? Type751 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateGridTeamSettingsRequestV1? Type752 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridEffectiveSpendLimitV1? Type753 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridSpendBlockedByV1? Type754 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridSpendLimitSettingV1? Type755 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridSpendLimitTeamDefaultV1? Type756 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridTeamUserSettingsV1? Type757 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridTeamUserSettingsListV1? Type758 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GridTeamUserSettingsV1>? Type759 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridTeamUserSettingsListRequestV1? Type760 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateGridSpendLimitSettingV1? Type761 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateGridUserSettingsRequestV1? Type762 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionBedrockAccessKeysAuthV1? Type763 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionBedrockApiKeyAuthV1? Type764 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionConfigAnthropicV1? Type765 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionConfigAzureV1? Type766 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionConfigBedrockV1? Type767 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Auth? Type768 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionConfigBedrockV1AuthDiscriminator? Type769 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionConfigBedrockV1AuthDiscriminatorMethod? Type770 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionConfigOpenAIV1? Type771 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionConfigVertexV1? Type772 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionConfigXAIV1? Type773 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionV1? Type774 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Config? Type775 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionV1ConfigDiscriminator? Type776 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionV1ConfigDiscriminatorProvider? Type777 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionsResponseV1? Type778 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GridConnectionV1>? Type779 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionsRequestV1? Type780 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridConnectionBedrockAccessKeysAuthV1? Type781 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridConnectionBedrockApiKeyAuthV1? Type782 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridConnectionConfigAnthropicV1? Type783 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridConnectionConfigAzureV1? Type784 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridConnectionConfigBedrockV1? Type785 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Auth2? Type786 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridConnectionConfigBedrockV1AuthDiscriminator? Type787 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridConnectionConfigBedrockV1AuthDiscriminatorMethod? Type788 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridConnectionConfigOpenAIV1? Type789 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridConnectionConfigVertexV1? Type790 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertGridConnectionConfigXAIV1? Type791 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateGridConnectionRequestV1? Type792 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Config2? Type793 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateGridConnectionRequestV1ConfigDiscriminator? Type794 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateGridConnectionRequestV1ConfigDiscriminatorProvider? Type795 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridConnectionTombstoneV1? Type796 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateGridConnectionRequestV1? Type797 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Config3? Type798 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateGridConnectionRequestV1ConfigDiscriminator? Type799 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateGridConnectionRequestV1ConfigDiscriminatorProvider? Type800 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteClassifiersResponseV1? Type801 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GridRouteClassifierV1>? Type802 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridRouteClassifiersRequestV1? Type803 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridMachineUserV1? Type804 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridMachineUsersResponseV1? Type805 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GridMachineUserV1>? Type806 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridMachineUsersRequestV1? Type807 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateGridMachineUserAPIKeyRequestV1? Type808 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateGridMachineUserRequestV1? Type809 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreatedGridMachineUserV1? Type810 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GridMachineUserTombstoneV1? Type811 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateGridMachineUserRequestV1? Type812 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EndpointTargetV1? Type813 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GatewayEndpointProviderV1? Type814 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VertexTargetConfigV1? Type815 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EndpointV1? Type816 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SharedEndpointRegionV1? Type817 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EndpointTargetV1>? Type818 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EndpointsResponseV1? Type819 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EndpointV1>? Type820 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EndpointTargetRequestV1? Type821 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateEndpointRequestV1? Type822 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EndpointTargetRequestV1>? Type823 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EndpointTombstoneV1? Type824 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateEndpointRequestV1? Type825 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EffectiveModelConfigV1? Type826 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EffectiveRateLimitV1>? Type827 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EffectiveRateLimitV1? Type828 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EffectiveUsageLimitV1>? Type829 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EffectiveUsageLimitV1? Type830 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UsageLimitUnitV1? Type831 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GroupHierarchyV1? Type832 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LimitEnforcementV1? Type833 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GroupMetadataV1? Type834 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GroupV1? Type835 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelConfigV1>? Type836 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelConfigV1? Type837 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EffectiveModelConfigV1>? Type838 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.RateLimitV1>? Type839 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RateLimitV1? Type840 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.UsageLimitV1>? Type841 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UsageLimitV1? Type842 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GroupsResponseV1? Type843 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GroupV1>? Type844 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateGroupHierarchyV1? Type845 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateGroupRequestV1? Type846 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateGroupMetadataV1? Type847 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateGroupRequestV1? Type848 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GatewayKeyInfoV1? Type849 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.KeysForGroupResponseV1? Type850 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GatewayKeyInfoV1>? Type851 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateApiKeyForGroupRequestV1? Type852 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateApiKeyForGroupResponseV1? Type853 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RegisterAPIKeyRequestV1? Type854 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RegisterAPIKeyResponseV1? Type855 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxLogsV1? Type856 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxLogEntryV1>? Type857 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxLogEntryV1? Type858 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxMetricModeV1? Type859 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxMetricNameV1? Type860 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxMetricsV1? Type861 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxMetricDescriptorV1>? Type862 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxMetricDescriptorV1? Type863 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxMetricValueSetV1>? Type864 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxMetricValueSetV1? Type865 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxMetricDescriptorV1UnitHint? Type866 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxMetricDescriptorV1Kind? Type867 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetSandboxConfigurationResponseV1? Type868 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxRegionV1>? Type869 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxRegionV1? Type870 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxRegionV1InfoGeneration? Type871 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxImageBuildLogV1? Type872 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxImageBuildLogsResponseV1? Type873 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxImageBuildLogV1>? Type874 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxLifecycleV1? Type875 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxExpirationPolicyV1>? Type876 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxExpirationPolicyV1? Type877 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxTTLIdleExpirationPolicyV1? Type878 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1? Type879 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxDateExpirationPolicyV1? Type880 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxExpirationPolicyV1Discriminator? Type881 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxExpirationPolicyV1DiscriminatorType? Type882 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxTTLIdleExpirationPolicyV1Action? Type883 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxTTLIdleExpirationPolicyV1Type? Type884 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Action? Type885 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxTTLMaxAgeExpirationPolicyV1Type? Type886 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxDateExpirationPolicyV1Action? Type887 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxDateExpirationPolicyV1Type? Type888 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxEnvV1? Type889 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxPortV1>? Type890 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxPortV1? Type891 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxPortV1Protocol? Type892 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxFilesystemV1? Type893 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.OneOf<string, int?>? Type894 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxConfigurationV1? Type895 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxEnvV1>? Type896 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxVolumeAttachmentV1>? Type897 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxVolumeAttachmentV1? Type898 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateSandboxRequestV1? Type899 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateSandboxRequestV1? Type900 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxV1? Type901 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxV1Variant2? Type902 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxStatusV1? Type903 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxApiPaginationV1? Type904 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListSandboxesResponseV1? Type905 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxV1>? Type906 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListSandboxImagesResponseV1? Type907 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxImageV1>? Type908 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxImageV1? Type909 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListSandboxImageTagsResponseV1? Type910 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxImageTagV1>? Type911 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxImageTagV1? Type912 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxImageStatusV1? Type913 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PushSandboxImageRequestV1? Type914 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PushSandboxImageResponseV1? Type915 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxLibraryImageVolumeV1? Type916 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxLibraryImageCreationOptionsV1? Type917 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxLibraryImageVolumeV1>? Type918 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxLibraryImageV1? Type919 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListSandboxLibraryImagesResponseV1? Type920 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxLibraryImageV1>? Type921 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CleanupSandboxImagesResponseV1? Type922 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxPreviewStatusV1? Type923 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxPreviewConfigurationV1? Type924 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateSandboxPreviewRequestV1? Type925 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateSandboxPreviewRequestV1Variant2? Type926 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateSandboxPreviewRequestV1? Type927 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateSandboxPreviewRequestV1Variant2? Type928 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxPreviewV1? Type929 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxPreviewV1Variant2? Type930 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListSandboxPreviewsResponseV1? Type931 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxPreviewV1>? Type932 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateSandboxPreviewTokenRequestV1? Type933 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxPreviewTokenV1? Type934 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListSandboxPreviewTokensResponseV1? Type935 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxPreviewTokenV1>? Type936 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxVolumeStatusV1? Type937 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateSandboxVolumeRequestV1? Type938 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateSandboxVolumeRequestV1? Type939 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SandboxVolumeV1? Type940 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListSandboxVolumesResponseV1? Type941 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxVolumeV1>? Type942 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxMetricNameV1>? Type943 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SandboxVolumeStatusV1>? Type944 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.VolumeTagV1>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.VolumeV1>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.VolumeTokenScopeV1>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.VolumeSyncV1>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.VolumeVersionV1>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TokenScopeV1>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SecretV1>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EnvironmentGroupUserV1>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EnvironmentGroupV1>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TeamV1>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.RegionV1>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.InstanceTypeV1>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.InstanceTypeWithPriceV1>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.AutoscalingScheduleWeekdayV1>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SchedulesItem>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.AuditLogEventAutoscalingScheduleUpsertV1>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.AuditLogEventAutoscalingScheduleChangeV1>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.AuditLogEntryV1>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.AuditLogEventTypeGroupV1>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.AuditLogSourceV1>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelV1>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.DeploymentV1>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LogV1>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.PatchOpsItem>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double?>>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double?>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.MetricDescriptorV1>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.MetricValueSetV1>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.StartupPhaseSummaryV1>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.StartupAttemptV1>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.StartupOutcomeV1>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.StartupPhasePercentilesV1>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SchedulesItem2>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrafficRoutingRuleV1>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrafficRoutingTargetV1>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EnvironmentV1>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrafficRoutingTargetUpsertV1>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrafficRoutingRuleUpsertV1>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ChainV1>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ChainletV1>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ChainDeploymentV1>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentSettingsRequestV1>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentSettingsV1>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentAutoscalingSettingsUpdateV1>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentInstanceTypeUpdateV1>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrainingProjectV1>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrainingJobV1>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.CreateTrainingJobS3Artifact>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.CreateJobWeightConfigV1>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.CheckpointsItem>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrainingJobMetricV1>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Baseten.TrainingJobMetricV1>>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrainingJobNodeMetricsV1>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrainingJobCheckpointV1>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.CheckpointFile>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.AuthCodeV1>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.FileSummary>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.OrderByV1>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SupportedModelV1>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LoopsRunV1>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LoopsCheckpointV1>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LoopsSamplerV1>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LoopsDeploymentV1>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ResponseTimeDatapointV1>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.InferenceVolumeByStatusDatapointV1>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LoopsDeploymentNodeMetricsV1>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrainingGpuCapacityItemV1>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TeamTrainingGpuCapacityItemV1>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ActiveJobAtSubmitV1>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.PendingJobAheadAtSubmitV1>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.QueueEventV1>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.APIKeyInfoV1>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelAPIRateLimitV1>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelAPITeamDetailsV1>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelAPIV1>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelApisUsageResultV1>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelApisUsageBucketV1>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.UsageDimensionV1>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LibraryListingModality>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LibraryListingV1>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LibraryListingVersionV1>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelApisCostResultV1>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelApisCostBucketV1>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelApiCostDimensionV1>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.DailyDedicatedUsageV1>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.DedicatedItemV1>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.DailyLoopsUsageV1>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LoopsResourceItemV1>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LoopsBaseModelItemV1>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.DailyModelApiUsageV1>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelApiItemV1>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.DailyTrainingUsageV1>? ListType94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrainingItemV1>? ListType95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ToolCallUsageBucketV1>? ListType96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ToolCallUsageDimensionV1>? ListType97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.UserInfoV1>? ListType98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ServiceAccountV1>? ListType99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.PredefinedIdentityProviderV1>? ListType100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.IdentityProviderV1>? ListType101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.AccessTrustRuleV1>? ListType102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GatewayEventV1>? ListType103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ExploreMetadataV1>? ListType104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GridRouteClassifierV1SupportedTradeoff>? ListType105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GridRouteMetadataV1ApiFormat>? ListType106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GridRouteV1>? ListType107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GridRouteUsageResultV1>? ListType108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GridRouteUsageBucketV1>? ListType109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GridRouteUsageDimensionV1>? ListType110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GridProviderV1>? ListType111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GridRouteUsageHarnessV1>? ListType112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GridTeamUserSettingsV1>? ListType113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GridConnectionV1>? ListType114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GridRouteClassifierV1>? ListType115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GridMachineUserV1>? ListType116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EndpointTargetV1>? ListType117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EndpointV1>? ListType118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EndpointTargetRequestV1>? ListType119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EffectiveRateLimitV1>? ListType120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EffectiveUsageLimitV1>? ListType121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelConfigV1>? ListType122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EffectiveModelConfigV1>? ListType123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.RateLimitV1>? ListType124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.UsageLimitV1>? ListType125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GroupV1>? ListType126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GatewayKeyInfoV1>? ListType127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxLogEntryV1>? ListType128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxMetricDescriptorV1>? ListType129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxMetricValueSetV1>? ListType130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxRegionV1>? ListType131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxImageBuildLogV1>? ListType132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxExpirationPolicyV1>? ListType133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxPortV1>? ListType134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxEnvV1>? ListType135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxVolumeAttachmentV1>? ListType136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxV1>? ListType137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxImageV1>? ListType138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxImageTagV1>? ListType139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxLibraryImageVolumeV1>? ListType140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxLibraryImageV1>? ListType141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxPreviewV1>? ListType142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxPreviewTokenV1>? ListType143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxVolumeV1>? ListType144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxMetricNameV1>? ListType145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SandboxVolumeStatusV1>? ListType146 { get; set; }
    }
}