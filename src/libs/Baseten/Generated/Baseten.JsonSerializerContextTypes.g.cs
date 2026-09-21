
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
        public global::Baseten.VolumeV1? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type7 { get; set; }
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
        public global::Baseten.VolumeSyncDestinationV1? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncErrorV1? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceAzureV1? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceBasetenTrainingV1? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceCoreWeaveV1? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceGCSV1? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceHuggingFaceV1? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceR2V1? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncSourceS3V1? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncStatusV1? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncV1? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Source? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncV1SourceDiscriminator? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncV1SourceDiscriminatorType? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncsV1? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.VolumeSyncV1>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeSyncsRequestV1? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateVolumeSyncRequestV1? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Source2? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminator? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateVolumeSyncRequestV1SourceDiscriminatorType? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeleteVolumeRequestV1? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeleteVolumeResponseV1? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeVersionV1? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListVolumeVersionsResponseV1? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.VolumeVersionV1>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListVolumeVersionsRequestV1? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeleteVolumeVersionRequestV1? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeleteVolumeVersionResponseV1? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VolumeVersionDetailV1? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RestoreVolumeVersionRequestV1? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RestoreVolumeVersionResponseV1? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SecretV1? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SecretsV1? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SecretV1>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertSecretRequestV1? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SecretTombstoneV1? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentGroupManageAccessV1? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EnvironmentGroupUserV1>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentGroupUserV1? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentGroupV1? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentGroupsV1? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EnvironmentGroupV1>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateEnvironmentGroupManageAccessV1? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateEnvironmentGroupRequestV1? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TeamV1? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TeamsV1? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TeamV1>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TeamsRequestV1? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RegionV1? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RegionsV1? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.RegionV1>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InstanceTypeV1? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InstanceTypesV1? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.InstanceTypeV1>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsUserConfigV1? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsUserConfigResponseV1? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchLoopsUserConfigRequestV1? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchLoopsUserConfigResponseV1? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InstanceTypeWithPriceV1? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InstanceTypePricesV1? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.InstanceTypeWithPriceV1>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentArchivePayloadV1? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PrepareModelUploadRequestV1? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AWSCredentialsV1? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PrepareModelUploadResponseV1? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogActorTypeV1? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogActorV1? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogApiKeyTypeV1? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEntryV1? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventTypeV1? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EventData? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeployedV1? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentActivatedV1? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentDeactivatedV1? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentRetriedV1? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentPromotedV1? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentAutoscalingSettingsChangedV1? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentRequestBackpressureSettingsChangedV1? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentInstanceTypeChangedV1? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeploymentDeletedV1? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelDeletedV1? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelRenamedV1? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainDeployedV1? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainDeploymentActivatedV1? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainDeploymentDeactivatedV1? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainDeploymentPromotedV1? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainletAutoscalingSettingsChangedV1? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainletInstanceTypeChangedV1? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainDeploymentDeletedV1? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainDeletedV1? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainEnvironmentCreatedV1? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventChainEnvironmentUpdatedV1? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventSecretUpdatedV1? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventSecretDeletedV1? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventApiKeyCreatedV1? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventApiKeyDeletedV1? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventGatewayEndpointCreatedV1? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventGatewayEndpointUpdatedV1? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventGatewayEndpointDeletedV1? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventUserInvitedV1? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventUserJoinedOrganizationV1? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventWebhookSigningSecretCreatedV1? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventWebhookSigningSecretRotatedV1? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventWebhookSigningSecretDeletedV1? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventUserRoleUpdatedV1? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventUserTeamRoleUpdatedV1? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventUserRemovedV1? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventDirectoryGroupRoleUpdatedV1? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventRequireGroupBasedAdminsEnabledV1? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventEnvironmentCreatedV1? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventEnvironmentUpdatedV1? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventEnvironmentDeletedV1? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventReplicaTerminatedV1? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventModelPromotionControlActionV1? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventSshCertificateSignedV1? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventVolumeDeletedV1? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventVolumeVersionDeletedV1? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventVolumeVersionRestoredV1? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEntryV1EventDataDiscriminator? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEntryV1EventDataDiscriminatorEventType? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogSourceV1? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventAutoscalingScheduleActionV1? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventAutoscalingScheduleChangeV1? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventAutoscalingScheduleSettingsV1? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventAutoscalingSettingsV1? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventEnvironmentSettingsV1? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.AuditLogEventAutoscalingScheduleChangeV1>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogPromotionControlActionV1? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListAuditLogsResponseV1? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.AuditLogEntryV1>? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogEventTypeGroupV1? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuditLogSortDirectionV1? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListAuditLogsRequestV1? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.AuditLogEventTypeGroupV1>? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.AuditLogSourceV1>? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelV1? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelsV1? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelV1>? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelsRequestV1? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingSourceV1? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelArchiveSourceV1? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateModelRequestV1? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Source3? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateModelRequestV1SourceDiscriminator? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateModelRequestV1SourceDiscriminatorKind? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingSettingsV1? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentStatusV1? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentV1? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RequestBackpressureSettingsV1? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RequestBackpressurePolicyV1? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreatedModelDeploymentV1? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelTombstoneV1? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateModelRequestV1? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentsV1? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.DeploymentV1>? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentsRequestV1? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentArchiveSourceV1? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateModelDeploymentRequestV1? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateModelDeploymentRequestV1SourceDiscriminator? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateModelDeploymentRequestV1SourceDiscriminatorKind? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentTombstoneV1? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateDeploymentRequestV1? Type185 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateAutoscalingSettingsV1? Type186 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateAutoscalingSettingsStatusV1? Type187 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateAutoscalingSettingsResponseV1? Type188 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateRequestBackpressureSettingsV1? Type189 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PromoteRequestV1? Type190 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ActivateResponseV1? Type191 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeactivateResponseV1? Type192 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RetryDeploymentResponseV1? Type193 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DownloadDeploymentResponseV1? Type194 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentConfigResponseV1? Type195 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentConfigOutputFormat? Type196 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetDeploymentConfigRequestV1? Type197 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LogLevelV1? Type198 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LogV1? Type199 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLogsResponseV1? Type200 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LogV1>? Type201 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SortOrderV1? Type202 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetDeploymentLogsRequestV1? Type203 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchActionV1? Type204 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchOpConfigV1? Type205 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchOpEnvVarV1? Type206 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchOpExternalDataV1? Type207 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type208 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchOpModelCodeV1? Type209 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchOpPackageV1? Type210 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchOpPythonRequirementV1? Type211 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchPointV1? Type212 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateDeploymentPatchRequestV1? Type213 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.PatchOpsItem>? Type214 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchOpsItem? Type215 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminator? Type216 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateDeploymentPatchRequestV1PatchOpDiscriminatorType? Type217 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeploymentPatchPointWithHashV1? Type218 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateDeploymentPatchResponseV1? Type219 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetDeploymentPatchesStateResponseV1? Type220 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SyncDeploymentPatchesRequestV1? Type221 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SyncDeploymentPatchesResponseV1? Type222 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelMetricDescriptorV1? Type223 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelMetricUnitHintV1? Type224 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelMetricKindV1? Type225 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>>? Type226 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelMetricModeV1? Type227 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelMetricValueSetV1? Type228 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double?>>? Type229 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double?>? Type230 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetModelMetricsResponseV1? Type231 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelMetricDescriptorV1>? Type232 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelMetricValueSetV1>? Type233 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetDeploymentMetricsRequestV1? Type234 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TerminateReplicaResponseV1? Type235 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SignSSHCertificateRequestV1? Type236 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SignSSHCertificateResponseV1? Type237 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleSettingsV1? Type238 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleStateV1? Type239 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleV1? Type240 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleV1Cadence? Type241 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.AutoscalingScheduleWeekdayV1>? Type242 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleWeekdayV1? Type243 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentAutoscalingSchedulesV1? Type244 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SchedulesItem>? Type245 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SchedulesItem? Type246 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.OneTimeAutoscalingScheduleV1? Type247 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminator? Type248 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentAutoscalingSchedulesV1ScheduleDiscriminatorCadence? Type249 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentV1? Type250 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InProgressPromotionV1? Type251 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PromotionSettingsV1? Type252 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InProgressPromotionStatusV1? Type253 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PromotionCleanupStrategyV1? Type254 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RollingDeployConfigV1? Type255 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RollingDeployStrategyV1? Type256 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentsV1? Type257 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EnvironmentV1>? Type258 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdatePromotionSettingsV1? Type259 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateRollingDeployConfigV1? Type260 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateEnvironmentRequestV1? Type261 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EnvironmentTombstoneV1? Type262 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleSettingsRequestV1? Type263 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleUpsertV1? Type264 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AutoscalingScheduleUpsertV1Cadence? Type265 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.OneTimeAutoscalingScheduleUpsertV1? Type266 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateAutoscalingScheduleSettingsV1? Type267 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SchedulesItem2>? Type268 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SchedulesItem2? Type269 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminator? Type270 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateAutoscalingScheduleSettingsV1ScheduleDiscriminatorCadence? Type271 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateEnvironmentRequestV1? Type272 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateEnvironmentResponseV1? Type273 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetEnvironmentLogsRequestV1? Type274 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetEnvironmentMetricsRequestV1? Type275 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PromoteToEnvironmentRequestV1? Type276 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CancelPromotionStatusV1? Type277 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CancelPromotionResponseV1? Type278 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SignalPromotionResponseV1? Type279 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainV1? Type280 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainsV1? Type281 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ChainV1>? Type282 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainTombstoneV1? Type283 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainDeploymentV1? Type284 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ChainletV1>? Type285 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainletV1? Type286 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainDeploymentsV1? Type287 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ChainDeploymentV1>? Type288 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainDeploymentTombstoneV1? Type289 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainletEnvironmentSettingsRequestV1? Type290 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateChainEnvironmentRequestV1? Type291 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentSettingsRequestV1>? Type292 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainletEnvironmentSettingsV1? Type293 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainEnvironmentV1? Type294 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentSettingsV1>? Type295 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateChainEnvironmentRequestV1? Type296 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateChainEnvironmentResponseV1? Type297 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PromoteToChainEnvironmentRequestV1? Type298 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainletEnvironmentAutoscalingSettingsUpdateV1? Type299 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateChainletEnvironmentAutoscalingSettingsRequestV1? Type300 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentAutoscalingSettingsUpdateV1>? Type301 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainletEnvironmentInstanceTypeUpdateV1? Type302 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateChainletEnvironmentInstanceTypeRequestV1? Type303 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentInstanceTypeUpdateV1>? Type304 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateChainletEnvironmentInstanceTypeResponseV1? Type305 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertTrainingProjectV1? Type306 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertTrainingProjectRequestV1? Type307 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CheckpointSyncStatus? Type308 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingJobV1? Type309 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingProjectSummaryV1? Type310 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.V1AvailabilityModel? Type311 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UserV1? Type312 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingProjectV1? Type313 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpsertTrainingProjectResponseV1? Type314 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListTrainingProjectsResponseV1? Type315 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrainingProjectV1>? Type316 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListTrainingJobsResponseV1? Type317 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrainingJobV1>? Type318 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuthMethod? Type319 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AwsAssumeRoleDockerAuthV1? Type320 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AwsIamDockerAuthV1? Type321 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SecretReferenceV1? Type322 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AwsOidcDockerAuthV1? Type323 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.BasetenLatestCheckpointConfig? Type324 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.BasetenNamedCheckpointConfig? Type325 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateJobWeightConfigV1? Type326 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingWeightAuthV1? Type327 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobAcceleratorV1? Type328 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobCacheConfig? Type329 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobCheckpointingConfig? Type330 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobComputeV1? Type331 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobImageV1? Type332 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DockerAuthV1? Type333 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobRuntimeV1? Type334 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AnyOf<string, global::Baseten.SecretReferenceV1>? Type335 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.CreateTrainingJobS3Artifact>? Type336 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobS3Artifact? Type337 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoadCheckpointConfig? Type338 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobV1? Type339 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrussUserEnv? Type340 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InteractiveSessionConfigV1? Type341 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.CreateJobWeightConfigV1>? Type342 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DockerAuthType? Type343 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GcpServiceAccountJsonDockerAuthV1? Type344 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GcpOidcDockerAuthV1? Type345 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RegistrySecretDockerAuthV1? Type346 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GitInfo? Type347 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.V1InteractiveSessionTrigger? Type348 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.V1InteractiveSessionProvider? Type349 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.V1InteractiveSessionAuthProvider? Type350 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.CheckpointsItem>? Type351 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CheckpointsItem? Type352 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointConfig? Type353 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoadCheckpointConfigCheckpointDiscriminator? Type354 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp? Type355 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointConfigTarget? Type356 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobRequestV1? Type357 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateTrainingJobResponseV1? Type358 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingJobTombstoneV1? Type359 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobResponseV1? Type360 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateTrainingJobRequestV1? Type361 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateTrainingJobResponseV1? Type362 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DownloadTrainingJobResponseV1? Type363 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RecreateTrainingJobResponseV1? Type364 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobLogsRequestV1? Type365 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StorageMetricsV1? Type366 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>? Type367 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingJobMetricV1? Type368 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingJobMetricsV1? Type369 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>>? Type370 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingJobNodeMetricsV1? Type371 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobMetricsResponseV1? Type372 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrainingJobNodeMetricsV1>? Type373 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobMetricsRequestV1? Type374 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StopTrainingJobRequestV1? Type375 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.StopTrainingJobResponseV1? Type376 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingJobCheckpointV1? Type377 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobCheckpointsResponseV1? Type378 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrainingJobCheckpointV1>? Type379 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CheckpointFile? Type380 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobCheckpointFilesResponseV1? Type381 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.CheckpointFile>? Type382 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobCheckpointFilesRequestV1? Type383 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AuthCodeV1? Type384 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetAuthCodesResponseV1? Type385 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.AuthCodeV1>? Type386 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchInteractiveSessionRequestV1? Type387 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InteractiveSessionV1? Type388 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchInteractiveSessionResponseV1? Type389 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.FileSummary? Type390 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetCacheSummaryResponseV1? Type391 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.FileSummary>? Type392 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingProjectTombstoneV1? Type393 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingProjectResponseV1? Type394 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.OrderByV1? Type395 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SearchTrainingJobsRequestV1? Type396 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.OrderByV1>? Type397 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SearchTrainingJobsResponseV1? Type398 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SupportedModelV1? Type399 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsCapabilitiesResponseV1? Type400 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.SupportedModelV1>? Type401 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsSessionV1? Type402 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLoopsSessionResponseV1? Type403 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsSessionResponseV1? Type404 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsRunStatusNameV1? Type405 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsRunStatusV1? Type406 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsRunV1? Type407 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsSamplerV1? Type408 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsSamplerStatusV1? Type409 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsRunsResponseV1? Type410 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LoopsRunV1>? Type411 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsRunsQueryParamsV1? Type412 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLoopsRunRequestV1? Type413 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLoopsRunResponseV1? Type414 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeactivateLoopsRunResponseV1? Type415 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsRunResponseV1? Type416 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsSamplersResponseV1? Type417 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LoopsSamplerV1>? Type418 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsSamplersRequestV1? Type419 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLoopsSamplerRequestV1? Type420 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLoopsSamplerResponseV1? Type421 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsSamplerResponseV1? Type422 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointV1? Type423 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainerCheckpointTarget? Type424 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsCheckpointsResponseV1? Type425 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LoopsCheckpointV1>? Type426 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsCheckpointsQueryParamsV1? Type427 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ValidateLoopsCheckpointRequestV1? Type428 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ValidateLoopsCheckpointResponseV1? Type429 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointFilesResponseV1? Type430 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsCheckpointFilesRequestV1? Type431 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointS3SourceV1? Type432 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointVolumeSourceV1? Type433 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointSourceResponseV1? Type434 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Source4? Type435 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminator? Type436 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminatorKind? Type437 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsDeploymentStatusV1? Type438 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Name? Type439 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsDeploymentV1? Type440 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsDeploymentsResponseV1? Type441 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LoopsDeploymentV1>? Type442 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ListLoopsDeploymentsRequestV1? Type443 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DeactivateLoopsDeploymentResponseV1? Type444 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsDeploymentResponseV1? Type445 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsDebugArchiveFilesResponseV1? Type446 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsDebugArchiveFilesRequestV1? Type447 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsDeploymentMetricsRequestV1? Type448 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.InferenceVolumeByStatusDatapointV1? Type449 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsDeploymentMetricsV1? Type450 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ResponseTimeDatapointV1>? Type451 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ResponseTimeDatapointV1? Type452 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.InferenceVolumeByStatusDatapointV1>? Type453 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LoopsDeploymentNodeMetricsV1>? Type454 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LoopsDeploymentNodeMetricsV1? Type455 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsDeploymentMetricsResponseV1? Type456 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetLoopsDeploymentLogsRequestV1? Type457 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TeamTrainingGpuCapacityItemV1? Type458 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingGpuCapacityItemV1? Type459 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingGpuCapacityResponseV1? Type460 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrainingGpuCapacityItemV1>? Type461 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TeamTrainingGpuCapacityItemV1>? Type462 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchTeamTrainingGpuCapacityRequestV1? Type463 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PatchTeamTrainingGpuCapacityResponseV1? Type464 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ActiveJobAtSubmitV1? Type465 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CapacityAtSubmitV1? Type466 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.PendingJobAheadAtSubmitV1? Type467 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.QueueEventV1? Type468 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetTrainingJobQueueContextResponseV1? Type469 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ActiveJobAtSubmitV1>? Type470 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.PendingJobAheadAtSubmitV1>? Type471 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.QueueEventV1>? Type472 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GetBlobCredentialsResponseV1? Type473 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.APIKeyCategory? Type474 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateAPIKeyRequestV1? Type475 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.APIKeyV1? Type476 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.APIKeyInfoV1? Type477 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.APIKeyOwnerV1? Type478 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.APIKeysV1? Type479 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.APIKeyInfoV1>? Type480 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.APIKeysRequestV1? Type481 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.APIKeyTombstoneV1? Type482 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LimitTypeV1? Type483 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelAPIOrgDetailsV1? Type484 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelAPIV1? Type485 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AnyOf<double?, string, object>? Type486 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.RateLimitV1>? Type487 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RateLimitV1? Type488 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RateLimitUnitV1? Type489 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelAPIsResponseV1? Type490 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelAPIV1>? Type491 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelAPIsRequestV1? Type492 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisUsageBucketV1? Type493 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelApisUsageResultV1>? Type494 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisUsageResultV1? Type495 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisUsageResponseV1? Type496 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelApisUsageBucketV1>? Type497 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.BucketWidth? Type498 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UsageDimensionV1? Type499 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisUsageRequestV1? Type500 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.UsageDimensionV1>? Type501 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLLMModelRequestV1? Type502 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<object>? Type503 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LLMModelHandleV1? Type504 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLLMModelVersionRequestV1? Type505 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingMetadataV1? Type506 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LibraryListingModality>? Type507 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingModality? Type508 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingV1? Type509 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingsV1? Type510 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LibraryListingV1>? Type511 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLibraryListingRequestV1? Type512 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingTombstoneV1? Type513 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateLibraryListingRequestV1? Type514 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.BenchmarkSnapshotV1? Type515 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LLMBenchmarkMetricsV1? Type516 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TTSBenchmarkMetricsV1? Type517 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EmbeddingBenchmarkMetricsV1? Type518 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingVersionV1? Type519 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingVersionsV1? Type520 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.LibraryListingVersionV1>? Type521 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateLibraryListingVersionRequestV1? Type522 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LibraryListingVersionTombstoneV1? Type523 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateLibraryListingVersionRequestV1? Type524 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisCostBucketV1? Type525 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelApisCostResultV1>? Type526 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisCostResultV1? Type527 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisCostsResponseV1? Type528 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelApisCostBucketV1>? Type529 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApiCostDimensionV1? Type530 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisCostsRequestV1? Type531 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelApiCostDimensionV1>? Type532 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.BillableResourceV1? Type533 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ResourceKind? Type534 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ChainMetadataV1? Type535 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DailyDedicatedUsageV1? Type536 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AnyOf<double?, string>? Type537 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DailyModelApiUsageV1? Type538 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DailyTrainingUsageV1? Type539 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DedicatedItemV1? Type540 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.DailyDedicatedUsageV1>? Type541 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.DedicatedUsageV1? Type542 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.DedicatedItemV1>? Type543 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApiItemV1? Type544 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.DailyModelApiUsageV1>? Type545 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelApisUsageV1? Type546 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelApiItemV1>? Type547 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingItemV1? Type548 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.DailyTrainingUsageV1>? Type549 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TrainingUsageV1? Type550 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.TrainingItemV1>? Type551 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UsageSummaryV1? Type552 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UsageSummaryRequestV1? Type553 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UserInfoV1? Type554 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UsersResponseV1? Type555 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.UserInfoV1>? Type556 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UsersRequestV1? Type557 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.AwsAssumeRoleV1? Type558 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.OrganizationInfoV1? Type559 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GatewayEventTokensV1? Type560 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GatewayEventV1? Type561 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GatewayEventsResponseV1? Type562 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GatewayEventV1>? Type563 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GatewayEventsRequestV1? Type564 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetAnthropicV1? Type565 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetBasetenModelAPIV1? Type566 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetOpenAICompatibleV1? Type567 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetOpenAIV1? Type568 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetVertexV1? Type569 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.VertexTargetConfigV1? Type570 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTargetXAIV1? Type571 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteV1? Type572 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Target? Type573 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteV1TargetDiscriminator? Type574 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteV1TargetDiscriminatorType? Type575 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RoutesResponseV1? Type576 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.RouteV1>? Type577 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RoutesRequestV1? Type578 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateRouteRequestV1? Type579 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.Target2? Type580 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateRouteRequestV1TargetDiscriminator? Type581 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateRouteRequestV1TargetDiscriminatorType? Type582 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RouteTombstoneV1? Type583 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateRouteRequestV1? Type584 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.TargetVariant1? Type585 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateRouteRequestV1TargetVariant1Discriminator? Type586 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateRouteRequestV1TargetVariant1DiscriminatorType? Type587 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EndpointTargetV1? Type588 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GatewayProvider? Type589 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EndpointV1? Type590 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.SharedEndpointRegionV1? Type591 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EndpointTargetV1>? Type592 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EndpointsResponseV1? Type593 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EndpointV1>? Type594 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EndpointTargetRequestV1? Type595 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateEndpointRequestV1? Type596 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EndpointTargetRequestV1>? Type597 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EndpointTombstoneV1? Type598 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateEndpointRequestV1? Type599 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EffectiveModelConfigV1? Type600 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EffectiveRateLimitV1>? Type601 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EffectiveRateLimitV1? Type602 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EffectiveUsageLimitV1>? Type603 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.EffectiveUsageLimitV1? Type604 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UsageLimitUnitV1? Type605 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GroupHierarchyV1? Type606 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.LimitEnforcementV1? Type607 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GroupMetadataV1? Type608 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GroupV1? Type609 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.ModelConfigV1>? Type610 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.ModelConfigV1? Type611 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.EffectiveModelConfigV1>? Type612 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.UsageLimitV1>? Type613 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UsageLimitV1? Type614 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GroupsResponseV1? Type615 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GroupV1>? Type616 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateGroupHierarchyV1? Type617 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateGroupRequestV1? Type618 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateGroupMetadataV1? Type619 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.UpdateGroupRequestV1? Type620 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.GatewayKeyInfoV1? Type621 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.KeysForGroupResponseV1? Type622 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Baseten.GatewayKeyInfoV1>? Type623 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateApiKeyForGroupRequestV1? Type624 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.CreateApiKeyForGroupResponseV1? Type625 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RegisterAPIKeyRequestV1? Type626 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Baseten.RegisterAPIKeyResponseV1? Type627 { get; set; }

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
        public global::System.Collections.Generic.List<global::Baseten.SecretV1>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EnvironmentGroupUserV1>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EnvironmentGroupV1>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TeamV1>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.RegionV1>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.InstanceTypeV1>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.InstanceTypeWithPriceV1>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.AuditLogEventAutoscalingScheduleChangeV1>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.AuditLogEntryV1>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.AuditLogEventTypeGroupV1>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.AuditLogSourceV1>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelV1>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.DeploymentV1>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LogV1>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.PatchOpsItem>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.Dictionary<string, string>>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double?>>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double?>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelMetricDescriptorV1>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelMetricValueSetV1>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.AutoscalingScheduleWeekdayV1>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SchedulesItem>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EnvironmentV1>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SchedulesItem2>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ChainV1>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ChainletV1>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ChainDeploymentV1>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentSettingsRequestV1>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentSettingsV1>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentAutoscalingSettingsUpdateV1>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentInstanceTypeUpdateV1>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrainingProjectV1>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrainingJobV1>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.CreateTrainingJobS3Artifact>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.CreateJobWeightConfigV1>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.CheckpointsItem>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrainingJobMetricV1>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Baseten.TrainingJobMetricV1>>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrainingJobNodeMetricsV1>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrainingJobCheckpointV1>? ListType45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.CheckpointFile>? ListType46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.AuthCodeV1>? ListType47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.FileSummary>? ListType48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.OrderByV1>? ListType49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.SupportedModelV1>? ListType50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LoopsRunV1>? ListType51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LoopsSamplerV1>? ListType52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LoopsCheckpointV1>? ListType53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LoopsDeploymentV1>? ListType54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ResponseTimeDatapointV1>? ListType55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.InferenceVolumeByStatusDatapointV1>? ListType56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LoopsDeploymentNodeMetricsV1>? ListType57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrainingGpuCapacityItemV1>? ListType58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TeamTrainingGpuCapacityItemV1>? ListType59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ActiveJobAtSubmitV1>? ListType60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.PendingJobAheadAtSubmitV1>? ListType61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.QueueEventV1>? ListType62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.APIKeyInfoV1>? ListType63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.RateLimitV1>? ListType64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelAPIV1>? ListType65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelApisUsageResultV1>? ListType66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelApisUsageBucketV1>? ListType67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.UsageDimensionV1>? ListType68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<object>? ListType69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LibraryListingModality>? ListType70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LibraryListingV1>? ListType71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.LibraryListingVersionV1>? ListType72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelApisCostResultV1>? ListType73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelApisCostBucketV1>? ListType74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelApiCostDimensionV1>? ListType75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.DailyDedicatedUsageV1>? ListType76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.DedicatedItemV1>? ListType77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.DailyModelApiUsageV1>? ListType78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelApiItemV1>? ListType79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.DailyTrainingUsageV1>? ListType80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.TrainingItemV1>? ListType81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.UserInfoV1>? ListType82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GatewayEventV1>? ListType83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.RouteV1>? ListType84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EndpointTargetV1>? ListType85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EndpointV1>? ListType86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EndpointTargetRequestV1>? ListType87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EffectiveRateLimitV1>? ListType88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EffectiveUsageLimitV1>? ListType89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.ModelConfigV1>? ListType90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.EffectiveModelConfigV1>? ListType91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.UsageLimitV1>? ListType92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GroupV1>? ListType93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Baseten.GatewayKeyInfoV1>? ListType94 { get; set; }
    }
}