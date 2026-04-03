
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
            typeof(global::Baseten.JsonConverters.DeploymentStatusV1JsonConverter),

            typeof(global::Baseten.JsonConverters.DeploymentStatusV1NullableJsonConverter),

            typeof(global::Baseten.JsonConverters.UpdateAutoscalingSettingsStatusV1JsonConverter),

            typeof(global::Baseten.JsonConverters.UpdateAutoscalingSettingsStatusV1NullableJsonConverter),

            typeof(global::Baseten.JsonConverters.SortOrderV1JsonConverter),

            typeof(global::Baseten.JsonConverters.SortOrderV1NullableJsonConverter),

            typeof(global::Baseten.JsonConverters.InProgressPromotionStatusV1JsonConverter),

            typeof(global::Baseten.JsonConverters.InProgressPromotionStatusV1NullableJsonConverter),

            typeof(global::Baseten.JsonConverters.PromotionCleanupStrategyV1JsonConverter),

            typeof(global::Baseten.JsonConverters.PromotionCleanupStrategyV1NullableJsonConverter),

            typeof(global::Baseten.JsonConverters.RollingDeployStrategyV1JsonConverter),

            typeof(global::Baseten.JsonConverters.RollingDeployStrategyV1NullableJsonConverter),

            typeof(global::Baseten.JsonConverters.CancelPromotionStatusV1JsonConverter),

            typeof(global::Baseten.JsonConverters.CancelPromotionStatusV1NullableJsonConverter),

            typeof(global::Baseten.JsonConverters.CheckpointSyncStatusJsonConverter),

            typeof(global::Baseten.JsonConverters.CheckpointSyncStatusNullableJsonConverter),

            typeof(global::Baseten.JsonConverters.DockerAuthTypeJsonConverter),

            typeof(global::Baseten.JsonConverters.DockerAuthTypeNullableJsonConverter),

            typeof(global::Baseten.JsonConverters.LoadCheckpointConfigCheckpointDiscriminatorTypJsonConverter),

            typeof(global::Baseten.JsonConverters.LoadCheckpointConfigCheckpointDiscriminatorTypNullableJsonConverter),

            typeof(global::Baseten.JsonConverters.V1InteractiveSessionAuthProviderJsonConverter),

            typeof(global::Baseten.JsonConverters.V1InteractiveSessionAuthProviderNullableJsonConverter),

            typeof(global::Baseten.JsonConverters.V1InteractiveSessionProviderJsonConverter),

            typeof(global::Baseten.JsonConverters.V1InteractiveSessionProviderNullableJsonConverter),

            typeof(global::Baseten.JsonConverters.V1InteractiveSessionTriggerJsonConverter),

            typeof(global::Baseten.JsonConverters.V1InteractiveSessionTriggerNullableJsonConverter),

            typeof(global::Baseten.JsonConverters.APIKeyCategoryJsonConverter),

            typeof(global::Baseten.JsonConverters.APIKeyCategoryNullableJsonConverter),

            typeof(global::Baseten.JsonConverters.ResourceKindJsonConverter),

            typeof(global::Baseten.JsonConverters.ResourceKindNullableJsonConverter),

            typeof(global::Baseten.JsonConverters.CheckpointsItemJsonConverter),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<string, global::Baseten.SecretReferenceV1>),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>),

            typeof(global::Baseten.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SecretV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SecretsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.SecretV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpsertSecretRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TeamV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TeamsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TeamV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.InstanceTypeV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.InstanceTypesV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.InstanceTypeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.InstanceTypeWithPriceV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.InstanceTypePricesV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.InstanceTypeWithPriceV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ModelV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AutoscalingSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentStatusV1), TypeInfoPropertyName = "DeploymentStatusV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.DeploymentV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeploymentTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateAutoscalingSettingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateAutoscalingSettingsStatusV1), TypeInfoPropertyName = "UpdateAutoscalingSettingsStatusV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateAutoscalingSettingsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PromoteRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ActivateResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DeactivateResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RetryDeploymentResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SortOrderV1), TypeInfoPropertyName = "SortOrderV12")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetDeploymentLogsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LogV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetLogsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.LogV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TerminateReplicaResponseV1))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateEnvironmentRequestV1))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UserV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingProjectV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpsertTrainingProjectResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListTrainingProjectsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TrainingProjectV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ListTrainingJobsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TrainingJobV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AwsIamDockerAuthV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SecretReferenceV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AwsOidcDockerAuthV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.BasetenLatestCheckpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.BasetenNamedCheckpointConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateJobWeightConfigV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoadCheckpointConfigCheckpointDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LoadCheckpointConfigCheckpointDiscriminatorTyp), TypeInfoPropertyName = "LoadCheckpointConfigCheckpointDiscriminatorTyp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateTrainingJobRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateTrainingJobResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingJobTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingJobResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.DownloadTrainingJobResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.RecreateTrainingJobResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingJobLogsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingJobMetricsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.StorageMetricsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingJobMetricV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingJobMetricsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Baseten.TrainingJobMetricV1>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingJobNodeMetricsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingJobMetricsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TrainingJobNodeMetricsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.StopTrainingJobRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.StopTrainingJobResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingJobCheckpointV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingJobCheckpointsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TrainingJobCheckpointV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CheckpointFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingJobCheckpointFilesResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.CheckpointFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AuthCodeV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetAuthCodesResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.AuthCodeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PatchInteractiveSessionRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.InteractiveSessionV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.PatchInteractiveSessionResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SignSSHCertificateRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SignSSHCertificateResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.FileSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetCacheSummaryResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.FileSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingProjectTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetTrainingProjectResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.OrderByV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SearchTrainingJobsRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.OrderByV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.SearchTrainingJobsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.AWSCredentialsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.GetBlobCredentialsResponseV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.APIKeyCategory), TypeInfoPropertyName = "APIKeyCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateAPIKeyRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.APIKeyV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.APIKeyInfoV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.APIKeysV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.APIKeyInfoV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.APIKeyTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.ModelWeightSnapshotV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateModelWeightSnapshotRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateLLMModelRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LLMModelV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateLLMModelVersionRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LLMModelVersionV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LibraryListingV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LibraryListingsV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.LibraryListingV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.CreateLibraryListingRequestV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.LibraryListingTombstoneV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UpdateLibraryListingRequestV1))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.ModelApiItemV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingItemV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.DailyTrainingUsageV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.TrainingUsageV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Baseten.TrainingItemV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Baseten.UsageSummaryV1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.SecretV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.TeamV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.InstanceTypeV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.InstanceTypeWithPriceV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ModelV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.DeploymentV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.LogV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.EnvironmentV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ChainV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ChainletV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ChainDeploymentV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentSettingsRequestV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentSettingsV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentAutoscalingSettingsUpdateV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ChainletEnvironmentInstanceTypeUpdateV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.TrainingProjectV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.TrainingJobV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.APIKeyInfoV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.LibraryListingV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.LibraryListingVersionV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.DailyDedicatedUsageV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.DedicatedItemV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.DailyModelApiUsageV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.ModelApiItemV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.DailyTrainingUsageV1>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Baseten.TrainingItemV1>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}